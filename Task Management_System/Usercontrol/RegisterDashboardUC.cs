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

namespace Task_Management_System.Usercontrol
{
    public partial class RegisterDashboardUC : XtraUserControl
    {
        DataBase db = new DataBase();
        string imagePath = "";

        public RegisterDashboardUC()
        {
            InitializeComponent();
            LoadStudent();
        }

        // LOAD DATA
        public void LoadStudent()
        {
            using (SqliteConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM StudentTask";
                var result = con.Query(query).ToList();
                DataTable dt = new DataTable();
                if (result.Count > 0)
                {
                    var first = (IDictionary<string, object>)result[0];
                    foreach (var key in first.Keys)
                        dt.Columns.Add(key);
                    foreach (var row in result)
                    {
                        var dict = (IDictionary<string, object>)row;
                        dt.Rows.Add(dict.Values.ToArray());
                    }
                }
                gvMainView.DataSource = dt;
            }
        }

        // REGISTER
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBStudentId.Text) ||
                string.IsNullOrEmpty(txtBFirstName.Text) ||
                string.IsNullOrEmpty(txtBLastname.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields!");
                return;
            }

            try
            {
                // CONVERT IMAGE TO BYTES
                byte[] photoBytes = null;
                if (!string.IsNullOrEmpty(imagePath))
                    photoBytes = File.ReadAllBytes(imagePath);

                using (SqliteConnection con = db.GetConnection())
                {
                    string query = @"INSERT INTO StudentTask
            (StudentID, FirstName, LastName, Section, Date, Photo)
            VALUES
            (@StudentID, @FirstName, @LastName, @Section, @Date, @Photo)";

                    con.Execute(query, new
                    {
                        StudentID = txtBStudentId.Text,
                        FirstName = txtBFirstName.Text,
                        LastName = txtBLastname.Text,
                        Section = cbSection.Text,
                        Date = DatePicker.Value.ToString("yyyy-MM-dd"),
                        Photo = photoBytes
                    });
                }

                XtraMessageBox.Show("Student Registered Successfully!");
                txtBStudentId.Text = "";
                txtBFirstName.Text = "";
                txtBLastname.Text = "";
                cbSection.SelectedIndex = -1;
                PicBox.Image = null;
                imagePath = "";
                LoadStudent();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        // UPLOAD IMAGE
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