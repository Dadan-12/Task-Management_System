using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Dashboards;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Dashboard
{
    // ✅ SUCCESS: LoginDashboard is now the FIRST class declared in the file.
    // The Visual Studio WinForms designer will now open instantly without issues.
    public partial class LoginDashboard : DevExpress.XtraEditors.XtraForm
    {
        // Keep your original database manager instance intact
        DataBase db = new DataBase();

        public LoginDashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Matches your designer inputs perfectly
            string username = txtStudentId.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Please fill out both the Username/Student ID and Password fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqliteConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();

                    // =================================================================
                    // 🎯 FIXED PIPELINE: Check the correct 'Users' table instead of 'User'
                    // =================================================================
                    string loginQuery = @"SELECT * FROM Users 
                                          WHERE Username = @Username 
                                          AND Password = @Password";

                    using (SqliteCommand loginCommand = new SqliteCommand(loginQuery, con))
                    {
                        loginCommand.Parameters.AddWithValue("@Username", username);
                        loginCommand.Parameters.AddWithValue("@Password", password);

                        using (SqliteDataReader loginReader = loginCommand.ExecuteReader())
                        {
                            if (loginReader.Read())
                            {
                                // Route to the appropriate dashboard based on whether they are an Admin or Student
                                if (username.ToLower() == "admin")
                                {
                                    UserSession.CurrentUserRole = "Admin";
                                    UserSession.CurrentStudentId = "STU-2026-0001"; // Administrative fallback ID

                                    XtraMessageBox.Show("Login Successful! Welcome to the Admin panel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    AdminDashboard adminDashboard = new AdminDashboard(username);
                                    adminDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    UserSession.CurrentUserRole = "Student";
                                    UserSession.CurrentStudentId = username;

                                    XtraMessageBox.Show($"Login Successful! Welcome Student {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    StudentDashboard studentDashboard = new StudentDashboard();
                                    studentDashboard.Show();
                                    this.Hide();
                                }
                                return;
                            }
                        }
                    }

                    // Fallback to check the 'Students' table directly in case passwords match PasswordHash directly
                    string studentFallbackQuery = @"SELECT * FROM Students 
                                                    WHERE StudentId = @StudentId 
                                                    AND PasswordHash = @Password";

                    using (SqliteCommand fallbackCommand = new SqliteCommand(studentFallbackQuery, con))
                    {
                        fallbackCommand.Parameters.AddWithValue("@StudentId", username);
                        fallbackCommand.Parameters.AddWithValue("@Password", password);

                        using (SqliteDataReader fallbackReader = fallbackCommand.ExecuteReader())
                        {
                            if (fallbackReader.Read())
                            {
                                UserSession.CurrentUserRole = "Student";
                                UserSession.CurrentStudentId = username;

                                XtraMessageBox.Show($"Login Successful! Welcome Student {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                StudentDashboard studentDashboard = new StudentDashboard();
                                studentDashboard.Show();
                                this.Hide();
                                return;
                            }
                        }
                    }

                    XtraMessageBox.Show("Invalid Username, Student ID, or Password!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Database Connection Error: {ex.Message}", "Critical Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggles the System Password character masking behavior dynamically based on control checked state
            txtPassword.Properties.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        /// <summary>
        /// Event handler for the Cancel button click event.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to close the Task Management System?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}