using Dapper;
using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.admin
{
    public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        // 📍 STORAGE STACK: Core database access layer reference
        private readonly DataBase db = new DataBase();

        public ucDashboard()
        {
            InitializeComponent();

            LoadData();
            LoadDashboardStats();

            gvDashboard.DoubleClick += GvDashboard_DoubleClick;
        }

        // 📍 VISIBILITY TRACKER: Forces UI layout corrections and matrix state refetches upon view entry shifts
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                pnlStudentCardContainer.Visible = false;
                tableLayoutPanel1.Visible = true;
                groupControl1.Visible = true;

                LoadData();
                LoadDashboardStats();
            }
        }

        // 📍 PROFILE LOOKUP DRILLDOWN: Unpacks dynamic key dictionaries to parse targeted metrics onto card canvases
        public void LoadStudentProfile(object studentObj)
        {
            if (studentObj == null) return;

            try
            {
                var student = studentObj as IDictionary<string, object>;
                if (student == null) return;

                string firstName = student.ContainsKey("FirstName") ? student["FirstName"]?.ToString() : "";
                string lastName = student.ContainsKey("LastName") ? student["LastName"]?.ToString() : "";
                string studentId = student.ContainsKey("Student_Id") ? student["Student_Id"]?.ToString() : "";
                string section = student.ContainsKey("Section") ? student["Section"]?.ToString() : "";

                lblStudentWelcomeTitle.Text = $"Managing: {firstName} {lastName}";
                lblCardIdValue.Text = !string.IsNullOrEmpty(studentId) ? studentId : "-";
                lblCardSectionValue.Text = !string.IsNullOrEmpty(section) ? section : "-";

                // 📍 REAL-TIME COUNTER LOOKUP: Fetches active uncompleted task metrics for the focused account context
                using (SqliteConnection con = db.GetConnection())
                {
                    string taskQuery = "SELECT COUNT(*) FROM tasks WHERE Student_Id = @StudentId AND Status != 'Completed'";
                    int activeTasks = con.ExecuteScalar<int>(taskQuery, new { StudentId = studentId });

                    lblCardTasksValue.Text = activeTasks.ToString();
                }

                // 📍 IMAGE RENDER PIPELINE: Binds binary arrays onto target picture canvas displays safely
                if (student.ContainsKey("picture") && student["picture"] is byte[] imgBytes && imgBytes.Length > 0)
                {
                    peStudentProfileCanvas.EditValue = imgBytes;
                }
                else
                {
                    peStudentProfileCanvas.EditValue = null;
                }

                tableLayoutPanel1.Visible = false;
                groupControl1.Visible = false;
                pnlStudentCardContainer.Visible = true;
                pnlStudentCardContainer.BringToFront();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Admin interface rendering crash error: {ex.Message}");
            }
        }

        // 📍 GRID SELECTION INTERCEPT: Captures double-click operations over data elements to route target rows
        private void GvDashboard_DoubleClick(object sender, EventArgs e)
        {
            object selectedRow = gvDashboard.GetFocusedRow();
            if (selectedRow != null)
            {
                LoadStudentProfile(selectedRow);
            }
        }

        // 📍 CANVAS RESET TOOL: Collapses details card workspaces to bring primary analytics grids into view
        private void btnReturnToGrid_Click(object sender, EventArgs e)
        {
            pnlStudentCardContainer.Visible = false;
            tableLayoutPanel1.Visible = true;
            groupControl1.Visible = true;
        }

        // 📍 DATA SYNCHRONIZATION PIPELINE: Populates master layout data source parameters from target storage collections
        public void LoadData()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT Id, picture, Student_Id, FirstName, LastName, Section, Date FROM Admin";
                    var profiles = con.Query<dynamic>(query).ToList();

                    MainViewDashboard.DataSource = profiles;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 METRIC COMPILATION ROUTINE: Updates top dashboard stats indicators via aggregated record count executions
        public void LoadDashboardStats()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    int total = con.ExecuteScalar<int>("SELECT COUNT(*) FROM Admin");
                    lblTotalValue.Text = total.ToString();

                    int sections = con.ExecuteScalar<int>("SELECT COUNT(DISTINCT Section) FROM Admin");
                    lblSectionValue.Text = sections.ToString();

                    lblDateValue.Text = DateTime.Today.ToString("MMM dd, yyyy");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Stats error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}