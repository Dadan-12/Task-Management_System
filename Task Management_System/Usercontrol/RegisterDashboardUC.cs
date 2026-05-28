using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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
        // Koneksyon sa database
        private readonly DataBase db = new DataBase();
        // Iu-save dinhi ang dalan sa litrato nga gipili
        private string imagePath = "";
        private AdminDashboardUC _dashboardUC;
        public RegisterDashboardUC()
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
                    // Kuhaon ang tanan nga datos sa Admin table
                    string query = "SELECT * FROM Admin";
                    var result = con.Query(query).ToList();
                    DataTable dt = new DataTable();

                    if (result.Count > 0)
                    {
                        var first = (IDictionary<string, object>)result[0];

                        // Himuon ang mga kolum base sa datos
                        foreach (var key in first.Keys)
                        {
                            // Ang litrato i-store isip byte array
                            if (key == "picture")
                                dt.Columns.Add(key, typeof(byte[]));
                            else
                                dt.Columns.Add(key);
                        }

                        // I-fill ang matag row sa datos
                        foreach (var row in result)
                        {
                            var dict = (IDictionary<string, object>)row;
                            dt.Rows.Add(dict.Values.ToArray());
                        }
                    }

                    // Ipakita ang datos sa grid
                    MainViewDashboard.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Kung adunay sayop, ipakita ang mensahe
                XtraMessageBox.Show("Load error: " + ex.Message);
            }
        }

        // ── REGISTER ─────────────────────────────────────────────
        // Kini ang mag-save sa bag-ong estudyante sa database
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Susiha kung naa bay wala pa nasulti nga fields
            if (string.IsNullOrEmpty(txtBStudentId.Text) ||
                string.IsNullOrEmpty(txtBFirstName.Text) ||
                string.IsNullOrEmpty(txtBLastname.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Susiha kung numero lang ang Student ID
            if (!txtBStudentId.Text.All(char.IsDigit))
            {
                XtraMessageBox.Show("Student ID must contain numbers only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Susiha kung letra lang ang First Name
            if (!txtBFirstName.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                XtraMessageBox.Show("First Name must contain letters only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Susiha kung letra lang ang Last Name
            if (!txtBLastname.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                XtraMessageBox.Show("Last Name must contain letters only!",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kung adunay litrato, i-convert sa bytes para ma-save
                byte[] photoBytes = null;
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    photoBytes = File.ReadAllBytes(imagePath);

                // Paghimo sa username ug password para sa estudyante
                string username = GenerateUsername(txtBFirstName.Text, txtBStudentId.Text);
                string password = GeneratePassword(txtBLastname.Text);
                string hashedPassword = HashPassword(password); // I-hash ang password para luwas

                using (SqliteConnection con = db.GetConnection())
                {
                    // STEP 1 — I-save ang estudyante sa Admin table
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

                    // STEP 2 — I-save ang username ug password sa User table
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

                // STEP 3 — Ipakita ang credentials sa admin
                // Para mahatag sa estudyante ang iyang login info
                XtraMessageBox.Show(
                    $"Student Registered Successfully!\n\n" +
                    $"Username : {username}\n" +
                    $"Password : {password}\n\n" +
                    $"Studebt credentials .",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpyohi ang form ug i-refresh ang lista
                ClearForm();
                LoadStudent();
            }
            catch (Exception ex)
            {
                // Kung adunay sayop sa pag-save, ipakita ang mensahe
                XtraMessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── VALIDATION SA KEYPRESS ────────────────────────────────
        // Dili tugutan ang letra sa Student ID — numero lang
        private void txtBStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // I-block ang key kung dili numero
        }

        // Dili tugutan ang numero sa First Name — letra lang
        private void txtBFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true; // I-block ang key kung dili letra
        }

        // Dili tugutan ang numero sa Last Name — letra lang
        private void txtBLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true; // I-block ang key kung dili letra
        }

        // ── GENERATE CREDENTIALS ─────────────────────────────────
        // Paghimo sa username: FirstName + StudentID
        // Pananglitan: "john2024001"
        private string GenerateUsername(string firstName, string studentId)
        {
            return firstName.ToLower().Trim() + studentId.Trim();
        }

        // Paghimo sa password: LastName + "123"
        // Pananglitan: "Santos123"
        private string GeneratePassword(string lastName)
        {
            return lastName.Trim() + "123";
        }

        // I-hash ang password gamit SHA256 para luwas sa database
        // Dili na mabasa ang tinuod nga password kung ma-hack
        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(
                    System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // ── UPLOAD IMAGE ─────────────────────────────────────────
        // Pagpili og litrato gikan sa kompyuter
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var opf = new OpenFileDialog())
            {
                // Jpg ug png lang ang pwede
                opf.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    imagePath = opf.FileName; // I-save ang dalan sa litrato
                    PicBox.Image = Image.FromFile(imagePath); // Ipakita ang litrato
                    PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // ── CLEAR FORM ───────────────────────────────────────────
        // Limpyohi ang tanan nga fields pagkahuman mag-register
        private void ClearForm()
        {
            txtBStudentId.Text = "";
            txtBFirstName.Text = "";
            txtBLastname.Text = "";
            cbSection.SelectedIndex = -1;        // Wala'y napili nga seksyon
            Date.DateTime = DateTime.Today; // Ibalik sa karon nga petsa
            PicBox.Image = null;       
            imagePath = "";         
        }

        // ── PRINT REPORT ─────────────────────────────────────────
        // Kung i-click ang Print, ablihi ang print preview
        // Makita nimo ang lista sa mga estudyante antes mag-print
       

        // ── UNUSED EVENTS ────────────────────────────────────────
        // Kini nga mga events wala gigamit pero gikinahanglan sa designer
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}