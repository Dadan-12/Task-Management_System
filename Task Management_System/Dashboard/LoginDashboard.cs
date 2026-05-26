using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;  // ✅ Only this, remove System.Data.SQLite
using System;
using System.Windows.Forms;
using Task_Management_System.Dashboard;
using Task_Management_System.Data;

namespace Task_Management_System.Dashboards
{
    public partial class LoginDashboard : XtraForm
    {
        DataBase db = new DataBase();

        public LoginDashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text.Trim();
            string password = txtBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Please enter username and password!");
                return;
            }

            try
            {
                // ✅ Step 1: Check Admin table first
                if (TryAdminLogin(username, password)) return;

                // ✅ Step 2: Check Student login
                if (TryStudentLogin(username, password)) return;

                // ❌ Neither matched
                XtraMessageBox.Show("Invalid Username or Password!",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool TryAdminLogin(string username, string password)
        {
            using (SqliteConnection con = db.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM User WHERE Username=@Username AND Password=@Password";
                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqliteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    XtraMessageBox.Show($"Welcome Admin: {username}!",
                        "Login Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    AdminDashboard dashboard = new AdminDashboard(username);
                    dashboard.Show();
                    this.Hide();
                    return true;
                }
                return false;
            }
        }

        private bool TryStudentLogin(string username, string password)
        {
            using (SqliteConnection con = db.GetConnection())
            {
                con.Open();
                string query = @"
                    SELECT s.StudentID, s.FirstName, s.LastName, s.Section
                    FROM StudentTask s
                    INNER JOIN StudentLogin l ON s.StudentID = l.StudentID
                    WHERE l.Username = @Username AND l.Password = @Password";

                SqliteCommand cmd = new SqliteCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqliteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string studentId = reader["StudentID"].ToString();
                    string firstName = reader["FirstName"].ToString();

                    XtraMessageBox.Show($"Welcome, {firstName}!",
                        "Login Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // ✅ Open StudentDashboard
                    //StudentDashboard sd = new StudentDashboard(studentId);
                    //sd.Show();
                    //this.Hide();
                    //return true;
                }
                return false;
            }
        }
    }
}