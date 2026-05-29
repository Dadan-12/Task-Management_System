using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI; // Required for ReportPrintTool
using System;
using System.Windows.Forms;
using Task_Management_System.Usercontrol; // Namespace reference wrapper

namespace Task_Management_System.Dashboards
{
    public partial class AdminDashboard : XtraForm
    {
        private Usercontrol.admin.ucDashboard dashboardUC;
        private Usercontrol.admin.RegisterDashboardUC registerUC;
        private AdminScheduleUC scheduleUC; // 👈 Added Backing instance pointer

        // 🔐 CURRENT SESSION IDENTITY TRACK
        private string _currentUserSession;
        private dynamic _currentActiveStudent = null;

        public AdminDashboard(string user)
        {
            // Initialize component layout elements
            InitializeComponent();

            // Store the authentic primary identity string passed via construction
            this._currentUserSession = user;

            // Instantiate User Controls cleanly
            dashboardUC = new Usercontrol.admin.ucDashboard();
            registerUC = new Usercontrol.admin.RegisterDashboardUC(this);
            scheduleUC = new AdminScheduleUC(); // 👈 Initialized the pure DevExpress Scheduler canvas

            // Render and bind them to the workspace canvas securely
            if (panelDashboard != null)
            {
                panelDashboard.Controls.Add(dashboardUC);
                panelDashboard.Controls.Add(registerUC);
                panelDashboard.Controls.Add(scheduleUC); // 👈 Registered to UI Control hierarchy container

                dashboardUC.Dock = DockStyle.Fill;
                registerUC.Dock = DockStyle.Fill;
                scheduleUC.Dock = DockStyle.Fill; // 👈 Auto-dock matching boundaries

                // Set initial active state layout
                ShowUserControl(dashboardUC);
            }
        }

        /// <summary>
        /// 🎯 SWAP & ACCESS ACCOUNT PROFILE BRIDGE ROUTING: Receives a newly generated 
        /// account payload, forces a deep-session switch to track under this new identity context, 
        /// updates the display profile panel, and transitions the workspace cleanly.
        /// </summary>
        public void LoadStudentProfileToDashboard(object studentData)
        {
            if (dashboardUC != null && studentData != null)
            {
                // 1. Cast and cache the structural dynamic record row
                _currentActiveStudent = studentData;

                try
                {
                    // 2. Extract the new profile unique Student_Id value cleanly
                    dynamic dynamicRecord = (dynamic)studentData;
                    string newAccountId = dynamicRecord.Student_Id?.ToString() ?? "";

                    // 3. SECURELY SWITCH USER TRACK: Re-assign the primary session pointer context
                    this._currentUserSession = newAccountId;
                }
                catch
                {
                    // Fallback track if the object structural casting encounters anomalies
                }

                // 4. Force hydration straight over to the profile interface layout controls
                dashboardUC.LoadStudentProfile(studentData);

                // 5. Instantly jump views back to reveal the newly accessed account platform workspace
                ShowUserControl(dashboardUC);
            }
        }

        /// <summary>
        /// Swaps user control screens cleanly by modifying visibility structures without dropping internal variables
        /// </summary>
        private void ShowUserControl(UserControl activeControl)
        {
            if (dashboardUC != null) dashboardUC.Visible = (dashboardUC == activeControl);
            if (registerUC != null) registerUC.Visible = (registerUC == activeControl);
            if (scheduleUC != null) scheduleUC.Visible = (scheduleUC == activeControl); // 👈 Explicit structural layer matching switch

            if (activeControl != null)
            {
                activeControl.BringToFront();
            }
        }

        private void acDashboard_Click(object sender, EventArgs e)
        {
            if (dashboardUC != null)
            {
                ShowUserControl(dashboardUC);

                // Keep the active layout hydrated cleanly 
                if (_currentActiveStudent != null)
                {
                    dashboardUC.LoadStudentProfile(_currentActiveStudent);
                }
            }
        }

        private void acRegister_Click(object sender, EventArgs e)
        {
            if (registerUC != null)
            {
                // Transition over smoothly without wiping the underlying database state arrays
                ShowUserControl(registerUC);
                registerUC.RefreshDashboardGrid();
            }
        }

        /// <summary>
        /// 📅 SCHEDULER VIEW ROUTER INTERACTION NAVIGATOR
        /// </summary>
        private void acSchedule_Click(object sender, EventArgs e)
        {
            if (scheduleUC != null)
            {
                ShowUserControl(scheduleUC); // 👈 Brings scheduling interface container directly into context focus
                scheduleUC.LoadSchedules();  // 👈 Refresh persistent task matrices straight out of DB
            }
        }

        /// <summary>
        /// 📊 REPORT COMPILATION & PRINT PREVIEW DISPATCHER
        /// </summary>
        private void acReport_Click(object sender, EventArgs e)
        {
            try
            {
                // Instantiate our pre-configured XtraReport instance layout
                var report = new Usercontrol.admin.XtraReport1();

                // SMART CONTEXT FILTER: Check if we currently have an isolated student record focused on our workspace
                if (_currentActiveStudent != null)
                {
                    string targetStudentId = _currentActiveStudent.Student_Id?.ToString() ?? "";

                    DialogResult selection = XtraMessageBox.Show(
                        $"An active student profile ({targetStudentId}) is currently loaded.\n\n" +
                        "Would you like to print ONLY this individual student's report? \n" +
                        "(Select 'No' to pull the complete System Masterlist instead.)",
                        "Report Filter Selection",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (selection == DialogResult.Yes)
                    {
                        // Load single target sequence records
                        report.LoadSingleStudentReport(targetStudentId);
                    }
                    else if (selection == DialogResult.No)
                    {
                        // Load full fallback datasets
                        report.LoadReportData();
                    }
                    else
                    {
                        // Abort pipeline securely on user cancel selection
                        return;
                    }
                }
                else
                {
                    // Fallback to primary global baseline initialization data extraction if dashboard is blank
                    report.LoadReportData();
                }

                // Initialize the DevExpress structural print visualization engine container UI dynamically
                using (ReportPrintTool printTool = new ReportPrintTool(report))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Report Preview Compilation Anomaly: {ex.Message}", "Print Engine Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 🚪 LOGOUT SELECTION CLICK INTERACTION EVENT
        /// </summary>
        private void acLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = XtraMessageBox.Show(
                "Are you sure you want to log out of your session?",
                "Confirm Logout Request",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmExit == DialogResult.Yes)
            {
                Form loginFormInstance = Application.OpenForms["LoginForm"];

                if (loginFormInstance != null)
                {
                    loginFormInstance.Show();
                    loginFormInstance.BringToFront();
                    this.Close();
                }
                else
                {
                    Form newLogin = new Dashboard.LoginDashboard();
                    newLogin.Show();
                    this.Close();
                }
            }
        }
    }
}