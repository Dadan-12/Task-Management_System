using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Dapper;
using Task_Management_System.Data;
using Task_Management_System.Dashboards;

namespace Task_Management_System.Usercontrol.admin
{
    public partial class RegisterDashboardUC : UserControl
    {
        // 📍 STORAGE STACK: Dynamic binary container for tracking image upload streams
        private byte[] selectedImageBytes = null;

        // 📍 HOST ROUTE: Pointer referencing the root form canvas container
        private AdminDashboard _parentDashboard = null;

        public RegisterDashboardUC()
        {
            InitializeComponent();
        }

        // 📍 INSTANCE INITIALIZATION: Connects runtime operations to the master dashboard frame context
        public RegisterDashboardUC(AdminDashboard parent) : this()
        {
            _parentDashboard = parent;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshDashboardGrid();

            // 📍 INTERACTION ENGAGEMENT: Listen for row choices to transition focus over to student accounts
            if (gvDashboard != null)
            {
                gvDashboard.DoubleClick += GvDashboard_DoubleClick;
            }
        }

        // 📍 WORKSPACE ROUTING HANDLER: Intercepts row updates to swap view modules onto profile forms
        private void GvDashboard_DoubleClick(object sender, EventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;

            var selectedRow = view.GetFocusedRow();

            if (selectedRow != null && _parentDashboard != null)
            {
                _parentDashboard.LoadStudentProfileToDashboard(selectedRow);
            }
        }

        // 📍 IMAGE LOADER WORKFLOW: Imports profile graphics without keeping hardware file locks
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Profile Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImageBytes = File.ReadAllBytes(openFileDialog.FileName);

                        if (PicBox != null)
                        {
                            PicBox.EditValue = selectedImageBytes;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Failed to load image resource: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 📍 DATA PERSISTENCE PIPELINE: Handles user input validation, duplicates filtering, and record mapping
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentId = txtBStudentId.Text.Trim();
            string firstName = txtBFirstName.Text.Trim();
            string lastName = txtBLastname.Text.Trim();
            string email = txtBEmail.Text.Trim(); // 🎯 ADDED: Extract Email input value
            string section = cbSection.EditValue?.ToString() ?? "";
            string password = txtBPassword.Text.Trim();

            string dateStr = Date.EditValue != null
                ? ((DateTime)Date.EditValue).ToString("yyyy-MM-dd")
                : DateTime.Now.ToString("yyyy-MM-dd");

            // Updated validation constraint check to verify Email presence
            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                XtraMessageBox.Show("Please enter a Student ID, First Name, Email, and Password to proceed.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    // 📍 UNIQUE CONTRAINTS CHECK: Validates input to protect database table structures
                    string checkQuery = "SELECT COUNT(1) FROM Admin WHERE Student_Id = @Student_Id;";
                    int exists = db.ExecuteScalar<int>(checkQuery, new { Student_Id = studentId });

                    if (exists > 0)
                    {
                        XtraMessageBox.Show("This Student ID is already registered. Please use a unique ID or log in.", "Registration Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var parameterMaps = new
                    {
                        picture = selectedImageBytes,
                        Student_Id = studentId,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email, // 🎯 ADDED: Dynamic routing parameter for Dapper engine
                        Section = section,
                        Password = password,
                        Date = dateStr
                    };

                    // 🎯 UPDATED: Appended Email data field tracking nodes to the query execution structure
                    string insertQuery = @"
                        INSERT INTO Admin (picture, Student_Id, FirstName, LastName, Email, Section, Password, Date)
                        VALUES (@picture, @Student_Id, @FirstName, @LastName, @Email, @Section, @Password, @Date);";

                    db.Execute(insertQuery, parameterMaps);

                    // 📍 PAYLOAD SYNCHRONIZATION: Instantly gets the tracking properties of the newly written profile item
                    // 🎯 UPDATED: Appended Email tracking data field to row lookup query engine
                    string selectNewQuery = "SELECT Id, picture, Student_Id, FirstName, LastName, Email, Section, Password, Date FROM Admin WHERE Student_Id = @Student_Id LIMIT 1;";
                    var completeProfilePayload = db.QueryFirstOrDefault<dynamic>(selectNewQuery, new { Student_Id = studentId });

                    XtraMessageBox.Show("Account Registry Complete! Switching to the new workspace account...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFormLayoutInputs();
                    RefreshDashboardGrid();

                    if (_parentDashboard != null && completeProfilePayload != null)
                    {
                        _parentDashboard.LoadStudentProfileToDashboard(completeProfilePayload);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Registration pipeline error details: {ex.Message}", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 DATA REFRESH MATRIX: Synchronizes local grid rows with persistent database records
        public void RefreshDashboardGrid()
        {
            // 🎯 UPDATED: Pulling the new 'Email' column data payload downstream to the binding architecture
            string selectQuery = "SELECT Id, picture, Student_Id, FirstName, LastName, Email, Section, Password, Date FROM Admin;";
            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    var dataRecords = db.Query<dynamic>(selectQuery);
                    if (MainViewDashboard != null)
                    {
                        MainViewDashboard.DataSource = dataRecords;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load dashboard data grid tracking rows: {ex.Message}");
            }
        }

        // 📍 CANVAS RESET TOOL: Purges input boxes to accept fresh registry entries clean
        private void ClearFormLayoutInputs()
        {
            txtBStudentId.Text = string.Empty;
            txtBFirstName.Text = string.Empty;
            txtBLastname.Text = string.Empty;
            txtBEmail.Text = string.Empty; 
            cbSection.EditValue = null;
            txtBPassword.Text = string.Empty;
            Date.EditValue = null;
            PicBox.EditValue = null;
            selectedImageBytes = null;
        }
    }
}