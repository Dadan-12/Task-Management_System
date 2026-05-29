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
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Dashboard
{
    public partial class LoginDashboard : DevExpress.XtraEditors.XtraForm
    {
        public LoginDashboard()
        {
            InitializeComponent();

            // Enforce and validate database schema integrity immediately on startup
            try
            {
                DatabaseContext.InitializeDatabaseSchema();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Database Diagnostics Failure: {ex.Message}", "Initialization Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtStudentId.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Please fill out both the Username/Student ID and Password fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var con = (SqliteConnection)DatabaseContext.CreateConnection())
            {
                try
                {
                    if (con.State != ConnectionState.Open) con.Open();

                    // =================================================================
                    // 🎯 PIPELINE 1: Check the primary 'Admin' master registry table
                    // =================================================================
                    string adminQuery = @"SELECT Student_Id, FirstName, LastName, Section, picture, Password, Date 
                                          FROM Admin 
                                          WHERE Student_Id = @StudentId 
                                          AND Password = @Password 
                                          LIMIT 1;";

                    using (SqliteCommand adminCommand = new SqliteCommand(adminQuery, con))
                    {
                        adminCommand.Parameters.AddWithValue("@StudentId", username);
                        adminCommand.Parameters.AddWithValue("@Password", password);

                        using (SqliteDataReader reader = adminCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 👑 CASE 1: Check if this registration matches an Admin role override
                                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    UserSession.CurrentUserRole = "Admin";
                                    UserSession.CurrentStudentId = "STU-2026-0001";
                                    global::Task_Management_System.Data.SessionContext.ActiveStudentId = "STU-2026-0001";

                                    XtraMessageBox.Show("Login Successful! Welcome to the Admin panel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    global::Task_Management_System.Dashboards.AdminDashboard adminDashboard = new global::Task_Management_System.Dashboards.AdminDashboard(username);
                                    adminDashboard.Show();
                                    this.Hide();
                                    return;
                                }
                                // 🎓 CASE 2: Regular Student found inside the Admin registration schema
                                else
                                {
                                    UserSession.CurrentUserRole = "Student";
                                    UserSession.CurrentStudentId = reader["Student_Id"].ToString();
                                    global::Task_Management_System.Data.SessionContext.ActiveStudentId = reader["Student_Id"].ToString();

                                    // Build the dynamic payload directly from the database record row bounds
                                    dynamic studentProfile = new System.Dynamic.ExpandoObject();
                                    var profileDict = (IDictionary<string, object>)studentProfile;
                                    profileDict["Student_Id"] = reader["Student_Id"].ToString();
                                    profileDict["FirstName"] = reader["FirstName"].ToString();
                                    profileDict["LastName"] = reader["LastName"].ToString();
                                    profileDict["Section"] = reader["Section"].ToString();
                                    profileDict["picture"] = reader["picture"] != DBNull.Value ? (byte[])reader["picture"] : null;
                                    profileDict["Date"] = reader["Date"].ToString();

                                    XtraMessageBox.Show($"Login Successful! Welcome Student {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Pass the payload right into the dynamic argument constructor parameter cleanly
                                    global::Task_Management_System.Dashboard.StudentDashboard studentDashboard = new global::Task_Management_System.Dashboard.StudentDashboard(studentProfile);
                                    studentDashboard.Show();
                                    this.Hide();
                                    return;
                                }
                            }
                        }
                    }

                    // =================================================================
                    // 🎯 PIPELINE 2: Fallback check against legacy 'Users' table
                    // =================================================================
                    string fallbackUserQuery = @"SELECT Username, Password FROM Users 
                                                 WHERE Username LIKE @Username 
                                                 AND Password = @Password 
                                                 LIMIT 1;";

                    using (SqliteCommand userCommand = new SqliteCommand(fallbackUserQuery, con))
                    {
                        userCommand.Parameters.AddWithValue("@Username", username);
                        userCommand.Parameters.AddWithValue("@Password", password);

                        using (SqliteDataReader userReader = userCommand.ExecuteReader())
                        {
                            if (userReader.Read())
                            {
                                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    UserSession.CurrentUserRole = "Admin";
                                    UserSession.CurrentStudentId = "STU-2026-0001";
                                    global::Task_Management_System.Data.SessionContext.ActiveStudentId = "STU-2026-0001";

                                    XtraMessageBox.Show("Login Successful! Welcome to the Admin panel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    global::Task_Management_System.Dashboards.AdminDashboard adminDashboard = new global::Task_Management_System.Dashboards.AdminDashboard(username);
                                    adminDashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    UserSession.CurrentUserRole = "Student";
                                    UserSession.CurrentStudentId = username;
                                    global::Task_Management_System.Data.SessionContext.ActiveStudentId = username;

                                    // Build basic fallback profile structure block
                                    dynamic studentProfile = new System.Dynamic.ExpandoObject();
                                    var profileDict = (IDictionary<string, object>)studentProfile;
                                    profileDict["Student_Id"] = username;
                                    profileDict["FirstName"] = username;
                                    profileDict["LastName"] = "";
                                    profileDict["Section"] = "N/A";
                                    profileDict["picture"] = null;

                                    XtraMessageBox.Show($"Login Successful! Welcome Student {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    global::Task_Management_System.Dashboard.StudentDashboard studentDashboard = new global::Task_Management_System.Dashboard.StudentDashboard(studentProfile);
                                    studentDashboard.Show();
                                    this.Hide();
                                }
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
            txtPassword.Properties.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

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