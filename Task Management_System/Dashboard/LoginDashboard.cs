using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Dashboards
{
    public partial class LoginDashboard : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataBase db = new DataBase();

        public LoginDashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                XtraMessageBox.Show("Please enter username and password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string username = txtBoxUsername.Text.Trim();
                string rawPassword = txtBoxPassword.Text;
                string hashedPassword = HashPassword(rawPassword);

                using var con = db.GetConnection();

                // ✔ Try hashed password first (registered students)
                var user = con.QueryFirstOrDefault(
                    "SELECT * FROM User WHERE Username = @Username AND Password = @Password",
                    new { Username = username, Password = hashedPassword });

                // ✔ Fallback — try plain text (admin account with old password)
                if (user == null)
                {
                    user = con.QueryFirstOrDefault(
                        "SELECT * FROM User WHERE Username = @Username AND Password = @Password",
                        new { Username = username, Password = rawPassword });
                }

                if (user != null)
                {
                    XtraMessageBox.Show("Login Successfully!",
                        "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard dashboard = new AdminDashboard(username);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Invalid Username or Password!",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}