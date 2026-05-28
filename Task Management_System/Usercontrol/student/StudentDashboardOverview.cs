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

            // Reconfigure labels matching data index configurations
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            await RefreshKPIWidgetsAndLoadSchedulerAsync();
        }

        public async Task RefreshKPIWidgetsAndLoadSchedulerAsync()
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

                    // Query 4: Load active records out into the list 
                    var appointments = await db.QueryAsync<LocalAppointment>("SELECT * FROM Appointments;");

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            // Update counter widgets text values
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
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Error executing async dashboard refresh pipeline layout: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}