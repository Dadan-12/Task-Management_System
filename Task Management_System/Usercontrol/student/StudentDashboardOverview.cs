using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.student
{
    public partial class StudentDashboardOverview : DevExpress.XtraEditors.XtraUserControl
    {
        public StudentDashboardOverview()
        {
            InitializeComponent();
            this.Load += async (s, e) => await InitializeDashboardDataAsync();
        }

        public async Task InitializeDashboardDataAsync()
        {
            schedulerMini.Start = DateTime.Today;

            // Reconfigure clean execution labels dynamically
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            await RefreshKPIWidgetsAsync();
        }

        public async Task RefreshKPIWidgetsAsync()
        {
            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    string currentDayStr = DateTime.Today.ToString("yyyy-MM-dd");
                    string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Query 1: Classes Today (LabelKey = 1)
                    int todayClassesCount = await db.ExecuteScalarAsync<int>(
                        "SELECT COUNT(1) FROM Appointments WHERE LabelKey = 1 AND strftime('%Y-%m-%d', StartTime) = @Today;",
                        new { Today = currentDayStr });

                    // Query 2: Pending Tasks (LabelKey = 3 [Assignment] or 4 [Project])
                    int pendingTasksCount = await db.ExecuteScalarAsync<int>(
                        "SELECT COUNT(1) FROM Appointments WHERE LabelKey IN (3, 4);");

                    // Query 3: Upcoming Events (StartTime > Now)
                    int upcomingEventsCount = await db.ExecuteScalarAsync<int>(
                        "SELECT COUNT(1) FROM Appointments WHERE StartTime > @Now;",
                        new { Now = nowStr });

                    // Synchronize UI elements safely across threads
                    this.Invoke(new Action(() =>
                    {
                        lblTodayCount.Text = todayClassesCount.ToString();
                        lblPendingCount.Text = pendingTasksCount.ToString();
                        lblUpcomingCount.Text = upcomingEventsCount.ToString();
                    }));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Error executing async dashboard refresh execution structural pipeline data state: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}