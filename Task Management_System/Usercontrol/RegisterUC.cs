using Dapper;
using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class RegisterUC : DevExpress.XtraEditors.XtraUserControl
    {
        DataBase db = new DataBase();
        string imagePath = "";

        public RegisterUC()
        {
            InitializeComponent();
            LoadStudent();
        }

        public void LoadStudent()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();

                    // ✅ Verify table exists first
                    string checkTable = "SELECT name FROM sqlite_master WHERE type='table' AND name='StudentTask'";
                    SqliteCommand checkCmd = new SqliteCommand(checkTable, con);
                    var tableName = checkCmd.ExecuteScalar();

                    if (tableName == null)
                    {
                        XtraMessageBox.Show("StudentTask table does not exist!");
                        return;
                    }

                    string query = "SELECT StudentID, FirstName, LastName, Section, Date, Photo FROM StudentTask";
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    SqliteDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("StudentID");
                    dt.Columns.Add("FirstName");
                    dt.Columns.Add("LastName");
                    dt.Columns.Add("Section");
                    dt.Columns.Add("Date");
                    dt.Columns.Add("Photo", typeof(byte[]));

                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["StudentID"] = reader["StudentID"]?.ToString() ?? "";
                        row["FirstName"] = reader["FirstName"]?.ToString() ?? "";
                        row["LastName"] = reader["LastName"]?.ToString() ?? "";
                        row["Section"] = reader["Section"]?.ToString() ?? "";
                        row["Date"] = reader["Date"]?.ToString() ?? "";

                        // ✅ Handle photo bytes safely
                        if (reader["Photo"] != DBNull.Value)
                            row["Photo"] = (byte[])reader["Photo"];
                        else
                            row["Photo"] = DBNull.Value;

                        dt.Rows.Add(row);
                    }

                  
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("LoadStudent Error: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBStudentId.Text) ||
                string.IsNullOrWhiteSpace(txtBFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBLastname.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields!");
                return;
            }

            try
            {
                byte[] photoBytes = null;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    photoBytes = File.ReadAllBytes(imagePath);

                string username = txtBStudentId.Text.Trim();
                string password = txtBLastname.Text.Trim().ToLower() + "123";

                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();

                    // ✅ Check duplicate StudentID
                    string checkDupe = "SELECT COUNT(*) FROM StudentTask WHERE StudentID = @StudentID";
                    SqliteCommand dupeCmd = new SqliteCommand(checkDupe, con);
                    dupeCmd.Parameters.AddWithValue("@StudentID", txtBStudentId.Text.Trim());
                    long count = (long)dupeCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        XtraMessageBox.Show("Student ID already exists!", "Duplicate",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // ✅ Insert student
                    string insertStudent = @"INSERT INTO StudentTask 
                        (StudentID, FirstName, LastName, Section, Date, Photo)
                        VALUES 
                        (@StudentID, @FirstName, @LastName, @Section, @Date, @Photo)";

                    SqliteCommand insertCmd = new SqliteCommand(insertStudent, con);
                    insertCmd.Parameters.AddWithValue("@StudentID", txtBStudentId.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@FirstName", txtBFirstName.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@LastName", txtBLastname.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Section", cbSection.Text);
                    insertCmd.Parameters.AddWithValue("@Date", DatePicker.Value.ToString("yyyy-MM-dd"));
                    insertCmd.Parameters.AddWithValue("@Photo",
                        photoBytes != null ? (object)photoBytes : DBNull.Value);
                    insertCmd.ExecuteNonQuery();

                    // ✅ Insert login credentials
                    string insertLogin = @"INSERT OR IGNORE INTO StudentLogin 
                        (StudentID, Username, Password)
                        VALUES 
                        (@StudentID, @Username, @Password)";

                    SqliteCommand loginCmd = new SqliteCommand(insertLogin, con);
                    loginCmd.Parameters.AddWithValue("@StudentID", txtBStudentId.Text.Trim());
                    loginCmd.Parameters.AddWithValue("@Username", username);
                    loginCmd.Parameters.AddWithValue("@Password", password);
                    loginCmd.ExecuteNonQuery();
                }

                XtraMessageBox.Show(
                    $"Registered Successfully!\n\nUsername: {username}\nPassword: {password}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Clear fields
                txtBStudentId.Text = "";
                txtBFirstName.Text = "";
                txtBLastname.Text = "";
                cbSection.SelectedIndex = -1;
                PicBox.Image = null;
                imagePath = "";

                LoadStudent(); // ✅ Refresh grid immediately
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Register Error: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagePath = opf.FileName;
                PicBox.Image = Image.FromFile(imagePath);
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}