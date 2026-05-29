using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Task_Management_System.Data;

// 📍 TYPE ALIAS: Resolves naming ambiguity conflicts with DevExpress.XtraScheduler.Appointment
using LocalAppointment = Task_Management_System.Models.DbAppointment;

namespace Task_Management_System.Usercontrol.student
{
    public partial class StudentDashboardOverview : DevExpress.XtraEditors.XtraUserControl
    {
        // 📍 STORAGE STACK: Data-binding container layer assigned to the overview mini scheduler
        private BindingList<LocalAppointment> dashboardAppointmentsList = new BindingList<LocalAppointment>();

        public StudentDashboardOverview()
        {
            InitializeComponent();
            SetupDashboardSchedulerOptions();

            this.Load += async (s, e) => await InitializeDashboardDataAsync();
        }

        // 📍 SCHEDULER CONFIGURATION: Maps structural layout properties and enforces strict read-only states
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

            schedulerMini.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None;
        }

        // 📍 LIFECYCLE INITIALIZER: Configures runtime greeting contexts, workspace labels, and triggers metric queries
        public async Task InitializeDashboardDataAsync()
        {
            schedulerMini.Start = DateTime.Today;

            int currentHour = DateTime.Now.Hour;
            string greeting = "Good Evening";
            if (currentHour < 12) greeting = "Good Morning";
            else if (currentHour < 17) greeting = "Good Afternoon";

            lblWelcome.Text = $"{greeting}, Student!";

            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            await RefreshKPIWidgetsAndLoadSchedulerAsync();
        }

        // 📍 EXTERNAL REFRESH LINK: Programmatic interface exposure to force pipeline synchronization runs
        public async Task RefreshDashboardDataAsync()
        {
            await RefreshKPIWidgetsAndLoadSchedulerAsync();
        }

        // 📍 ASYNC PARALLEL DATA ENGINE: Executes non-blocking database operations to load KPIs and calendars simultaneously
        private async Task RefreshKPIWidgetsAndLoadSchedulerAsync()
        {
            try
            {
                string currentDayStr = DateTime.Today.ToString("yyyy-MM-dd");
                string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 📍 ISOLATED THREAD TASKS: Multi-threaded queries targeting unique connection signatures to safeguard SQLite integrity
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

                await Task.WhenAll(todayClassesTask, pendingTasksTask, upcomingEventsTask, loadAppointmentsTask);

                int todayClassesCount = await todayClassesTask;
                int pendingTasksCount = await pendingTasksTask;
                int upcomingEventsCount = await upcomingEventsTask;
                var appointments = await loadAppointmentsTask;

                // 📍 UI MARSHALING ACTION: Package values securely to dispatch onto control surfaces
                Action updateUiDelegation = () =>
                {
                    lblTodayCount.Text = todayClassesCount.ToString();
                    lblPendingCount.Text = pendingTasksCount.ToString();
                    lblUpcomingCount.Text = upcomingEventsCount.ToString();

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

                // 📍 CROSS-THREAD DISPATCH CHECK: Safely pushes data modifications back to the UI thread layer
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