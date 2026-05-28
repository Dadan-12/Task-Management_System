using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class RegisterDashboardUC : XtraUserControl
    {
        private readonly DataBase db = new DataBase();
        private string imagePath = "";

        public RegisterDashboardUC()
        {
            InitializeComponent();
            LoadStudent();
        }

        // LOAD DATA
        public void LoadStudent()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT * FROM Admin";
                    var result = con.Query(query).ToList();
                    DataTable dt = new DataTable();

                    if (result.Count > 0)
                    {
                        var first = (IDictionary<string, object>)result[0];

                        foreach (var key in first.Keys)
                        {
                            if (key == "picture")
                                dt.Columns.Add(key, typeof(byte[]));
                            else
                                dt.Columns.Add(key);
                        }

                        foreach (var row in result)
                        {
                            var dict = (IDictionary<string, object>)row;
                            dt.Rows.Add(dict.Values.ToArray());
                        }
                    }

                    MainViewDashboard.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Load error: " + ex.Message);
            }
        }

        // REGISTER
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ✔ Empty field validation
            if (string.IsNullOrEmpty(txtBStudentId.Text) ||
                string.IsNullOrEmpty(txtBFirstName.Text) ||
                string.IsNullOrEmpty(txtBLastname.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✔ Student ID — numbers only
            if (!txtBStudentId.Text.All(char.IsDigit))
            {
                XtraMessageBox.Show("Student ID must contain numbers only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✔ First Name — letters only
            if (!txtBFirstName.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                XtraMessageBox.Show("First Name must contain letters only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✔ Last Name — letters only
            if (!txtBLastname.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                XtraMessageBox.Show("Last Name must contain letters only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                byte[] photoBytes = null;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    photoBytes = File.ReadAllBytes(imagePath);

                string username = GenerateUsername(txtBFirstName.Text, txtBStudentId.Text);
                string password = GeneratePassword(txtBLastname.Text);
                string hashedPassword = HashPassword(password);

                using (SqliteConnection con = db.GetConnection())
                {
                    // STEP 1 — Insert into Admin table
                    const string insertAdmin = @"
                        INSERT INTO Admin
                            (picture, Student_Id, FirstName, LastName, Section, Date)
                        VALUES
                            (@picture, @Student_Id, @FirstName, @LastName, @Section, @Date)";

                    var adminParams = new DynamicParameters();
                    adminParams.Add("@picture", photoBytes, DbType.Binary);
                    adminParams.Add("@Student_Id", txtBStudentId.Text.Trim());
                    adminParams.Add("@FirstName", txtBFirstName.Text.Trim());
                    adminParams.Add("@LastName", txtBLastname.Text.Trim());
                    adminParams.Add("@Section", cbSection.Text);
                    adminParams.Add("@Date", Date.DateTime.ToString("yyyy-MM-dd"));

                    con.Execute(insertAdmin, adminParams);

                    // STEP 2 — Insert into User table
                    const string insertUser = @"
                        INSERT INTO User
                            (Username, Password)
                        VALUES
                            (@Username, @Password)";

                    var userParams = new DynamicParameters();
                    userParams.Add("@Username", username);
                    userParams.Add("@Password", hashedPassword);

                    con.Execute(insertUser, userParams);
                }

                // STEP 3 — Show credentials to admin
                XtraMessageBox.Show(
                    $"Student Registered Successfully!\n\n" +
                    $"Username : {username}\n" +
                    $"Password : {password}\n\n" +
                    $"Please give these credentials to the student.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadStudent();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✔ Student ID — numbers only (blocks at keypress)
        private void txtBStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // ✔ First Name — letters only (blocks at keypress)
        private void txtBFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        // ✔ Last Name — letters only (blocks at keypress)
        private void txtBLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        // ✔ FirstName + StudentID e.g. "john2024001"
        private string GenerateUsername(string firstName, string studentId)
        {
            return firstName.ToLower().Trim() + studentId.Trim();
        }

        // ✔ LastName + "123" e.g. "Santos123"
        private string GeneratePassword(string lastName)
        {
            return lastName.Trim() + "123";
        }

        // ✔ Hash using SHA256
        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // UPLOAD IMAGE
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var opf = new OpenFileDialog())
            {
                opf.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    imagePath = opf.FileName;
                    PicBox.Image = Image.FromFile(imagePath);
                    PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // CLEAR FORM
        private void ClearForm()
        {
            txtBStudentId.Text = "";
            txtBFirstName.Text = "";
            txtBLastname.Text = "";
            cbSection.SelectedIndex = -1;
            Date.DateTime = DateTime.Today;
            PicBox.Image = null;
            imagePath = "";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}