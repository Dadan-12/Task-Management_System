using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;
using Task_Management_System.Dashboard;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Dashboards
{
    public partial class LoginDashboard : XtraForm
    {
        private readonly DataBase db = new DataBase();

        public LoginDashboard()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            btnLogin.Click += btnLogin_Click;

            // Allow pressing Enter key on password field to login
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    btnLogin.PerformClick();
            };

            // Optional: Focus username on load
            this.Load += (s, e) => txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic Validation
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowStatus("Please enter your username!", Color.Red);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowStatus("Please enter your password!", Color.Red);
                txtPassword.Focus();
                return;
            }

            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = @"
                        SELECT UserID, FullName, Username, UserType 
                        FROM User 
                        WHERE Username = @Username 
                        AND Password = @Password";

                    using (SqliteCommand command = new SqliteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Note: Consider hashing in production

                        using (SqliteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Successful Login
                                string fullName = reader["FullName"].ToString();
                                string userType = reader["UserType"].ToString();

                                ShowStatus($"Welcome, {fullName}!", Color.Green);

                                this.Hide();

                                // Open correct dashboard based on UserType
                                if (userType?.Equals("Admin", StringComparison.OrdinalIgnoreCase) == true)
                                {
                                    new AdminDashboard(username).Show();
                                }
                                else
                                {
                                    new StudentDashboard().Show();
                                }
                            }
                            else
                            {
                                ShowStatus("❌ Invalid username or password!", Color.Red);
                                txtPassword.Focus();
                                txtPassword.SelectAll();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error: {ex.Message}", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to show status
        private void ShowStatus(string message, Color color)
        {
            if (lblStatus != null)
            {
                lblStatus.Text = message;
                lblStatus.Appearance.ForeColor = color;
            }
        }
    }
}



