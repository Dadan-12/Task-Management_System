using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Task_Management_System.Data;

// 🛠️ FIX: Explicit alias definition rules out the ambiguity error cleanly here too!
using LocalAppointment = Task_Management_System.Models.DbAppointment;

namespace Task_Management_System.Usercontrol.student
{
    public partial class StudentDashboardOverview : DevExpress.XtraEditors.XtraUserControl
    {
        // Internal memory list data-binding container layer for the mini calendar
        private BindingList<LocalAppointment> dashboardAppointmentsList = new BindingList<LocalAppointment>();

        public StudentDashboardOverview()
        {
            InitializeComponent();
            SetupDashboardSchedulerOptions();

            // Wire up asynchronous load event tracking
            this.Load += async (s, e) => await InitializeDashboardDataAsync();
        }

        private void SetupDashboardSchedulerOptions()
        {
            AppointmentMappingInfo mappings = schedulerDataStorage1.Appointments.Mappings;

            mappings.AppointmentId = nameof(LocalAppointment.UniqueId);
            mappings.Subject = nameof(LocalAppointment.Subject);
            mappings.Description = nameof(LocalAppointment.Description);
            mappings.Start = nameof(LocalAppointment.StartTime);
            mappings.End = nameof(LocalAppointment.EndTime);
            mappings.Label = nameof(LocalAppointment.LabelKey);
            mappings.Status = nameof(LocalAppointment.StatusKey);
            mappings.AllDay = nameof(LocalAppointment.AllDay);
            mappings.Location = nameof(LocalAppointment.Location);

            schedulerDataStorage1.Appointments.DataSource = dashboardAppointmentsList;

            // Structural Constraints: Force Overview to behave within Read-Only limits
            schedulerMini.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None;
        }

        public async Task InitializeDashboardDataAsync()
        {
            schedulerMini.Start = DateTime.Today;

            // Update greeting label dynamically based on time of day context
            int currentHour = DateTime.Now.Hour;
            string greeting = "Good Evening";
            if (currentHour < 12) greeting = "Good Morning";
            else if (currentHour < 17) greeting = "Good Afternoon";

            lblWelcome.Text = $"{greeting}, Student!";

            // Reconfigure labels matching data index configurations
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            await RefreshKPIWidgetsAndLoadSchedulerAsync();
        }

        /// <summary>
        /// Public-facing execution routine to programmatically force a background refresh from external view interactions
        /// </summary>
        public async Task RefreshDashboardDataAsync()
        {
            await RefreshKPIWidgetsAndLoadSchedulerAsync();
        }

        private async Task RefreshKPIWidgetsAndLoadSchedulerAsync()
        {
            try
            {
                string currentDayStr = DateTime.Today.ToString("yyyy-MM-dd");
                string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // ⚡ PERFORMANCE OPTIMIZATION: Fire all matrix requests in parallel to eliminate sequential pipeline latency.
                // 🎯 FIXED: Assigned a localized unique connection mapping statement to each Task pipeline. 
                // This shields thread execution states from throwing shared SQLite handle lock exceptions.
                var todayClassesTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>(
                            "SELECT COUNT(1) FROM Appointments WHERE LabelKey = 1 AND strftime('%Y-%m-%d', StartTime) = @Today;",
                            new { Today = currentDayStr });
                    }
                });

                var pendingTasksTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>("SELECT COUNT(1) FROM Appointments WHERE LabelKey IN (3, 4);");
                    }
                });

                var upcomingEventsTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>(
                            "SELECT COUNT(1) FROM Appointments WHERE StartTime > @Now;",
                            new { Now = nowStr });
                    }
                });

                var loadAppointmentsTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.Query<LocalAppointment>("SELECT * FROM Appointments;").ToList();
                    }
                });

                // Await the completion of all data pulls simultaneously safely
                await Task.WhenAll(todayClassesTask, pendingTasksTask, upcomingEventsTask, loadAppointmentsTask);

                int todayClassesCount = await todayClassesTask;
                int pendingTasksCount = await pendingTasksTask;
                int upcomingEventsCount = await upcomingEventsTask;
                var appointments = await loadAppointmentsTask;

                // Isolated delegation method to securely write parameters to the UI component controls
                Action updateUiDelegation = () =>
                {
                    // Safely map values into counter card elements
                    lblTodayCount.Text = todayClassesCount.ToString();
                    lblPendingCount.Text = pendingTasksCount.ToString();
                    lblUpcomingCount.Text = upcomingEventsCount.ToString();

                    // Populate the mini calendar component layout
                    schedulerMini.BeginUpdate();
                    try
                    {
                        dashboardAppointmentsList.Clear();
                        foreach (var entity in appointments)
                        {
                            dashboardAppointmentsList.Add(entity);
                        }
                    }
                    finally
                    {
                        schedulerMini.EndUpdate();
                    }
                };

                // 🛠️ FIX: Avoid silent dropping of data via strict InvokeRequired pattern matching
                if (this.InvokeRequired)
                {
                    this.Invoke(updateUiDelegation);
                }
                else
                {
                    updateUiDelegation();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Error executing async dashboard refresh pipeline layout: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}