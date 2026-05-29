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

        // 📍 CONTEXT FIELDS: Tracks the logged-in student's identity and assigned course section
        private readonly string _currentStudentId;
        private readonly string _currentSection;

        /// <summary>
        /// DYNAMIC CONSTRUCTOR: Initializes the Student Dashboard overview with custom user contexts.
        /// Defaults to a specialized placeholder tag to keep the Visual Studio Form Designer operational,
        /// while enabling any valid user account to populate the workspace automatically at runtime.
        /// </summary>
        /// <param name="studentId">Active student profile ID or key</param>
        /// <param name="section">Assigned class section name like 'NEUMANN' or 'AIKEN'</param>
        public StudentDashboardOverview(string studentId = "DESIGN_TIME_DEFAULT", string section = "NEUMANN")
        {
            InitializeComponent();

            _currentStudentId = studentId;
            _currentSection = string.IsNullOrWhiteSpace(section) ? "NEUMANN" : section.ToUpper();

            SetupDashboardSchedulerOptions();

            // 🛠 DESIGNER SAFE-GUARD: Run the asynchronous database pipeline only for active runtime user sessions
            if (!DesignMode && _currentStudentId != "DESIGN_TIME_DEFAULT")
            {
                this.Load += async (s, e) => await InitializeDashboardDataAsync();
            }
            else
            {
                // Fallback text layout to keep visual canvas tidy in visual studio editor
                lblWelcome.Text = "Good Morning, Student!";
            }
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
            // Exit early if called under designer context parameters
            if (_currentStudentId == "DESIGN_TIME_DEFAULT") return;

            schedulerMini.Start = DateTime.Today;

            // 🕒 DYNAMIC TIME GREETING: Dynamically tracks current hours to determine context greeting
            int currentHour = DateTime.Now.Hour;
            string greeting = "Good Evening";
            if (currentHour < 12) greeting = "Good Morning";
            else if (currentHour < 17) greeting = "Good Afternoon";

            // ✔ DYNAMIC PROFILING: Queries the database directly using the dynamic Student ID to fetch whichever user logged in
            string studentName = "Student";
            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    studentName = await db.ExecuteScalarAsync<string>(
                        "SELECT FullName FROM Students WHERE StudentId = @StudentId;",
                        new { StudentId = _currentStudentId }) ?? "Student";
                }
            }
            catch
            {
                // Fallback to default generic name gracefully if database is locked or inaccessible
                studentName = "Student";
            }

            lblWelcome.Text = $"{greeting}, {studentName}!";

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

        // 📍 ASYNC PARALLEL DATA ENGINE: Executes database operations to load KPIs and calendars simultaneously
        private async Task RefreshKPIWidgetsAndLoadSchedulerAsync()
        {
            if (_currentStudentId == "DESIGN_TIME_DEFAULT") return;

            try
            {
                string currentDayStr = DateTime.Today.ToString("yyyy-MM-dd");
                string nowStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 📍 ISOLATED THREAD TASKS: Multi-threaded queries targeting unique connection signatures to safeguard SQLite integrity

                // ✔ CONNECTED FILTER: Pull today's classes added by the Admin for this student's specific section
                var todayClassesTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>(
                            @"SELECT COUNT(1) FROM ClassSchedule  
                              WHERE UPPER(Section) = @Section  
                              AND strftime('%Y-%m-%d', StartTime) = @Today;",
                            new { Section = _currentSection, Today = currentDayStr });
                    }
                });

                // ✔ CONNECTED FILTER: Pull total tasks logged explicitly against this user's unique Student ID
                var pendingTasksTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>(
                            "SELECT COUNT(1) FROM StudentTask WHERE StudentID = @StudentId;",
                            new { StudentId = _currentStudentId });
                    }
                });

                // ✔ CONNECTED FILTER: Pull total upcoming schedule entries posted to this student's specific section
                var upcomingEventsTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        return db.ExecuteScalar<int>(
                            @"SELECT COUNT(1) FROM ClassSchedule  
                              WHERE UPPER(Section) = @Section  
                              AND StartTime > @Now;",
                            new { Section = _currentSection, Now = nowStr });
                    }
                });

                // ✔ PIPELINE TRANSLATION: Loads rows from ClassSchedule securely into LocalAppointment models
                var loadAppointmentsTask = Task.Run(() =>
                {
                    using (var db = DatabaseContext.CreateConnection())
                    {
                        var rawSchedules = db.Query(
                            @"SELECT Id, Title, StartTime, EndTime, Section  
                              FROM ClassSchedule  
                              WHERE UPPER(Section) = @Section;",
                            new { Section = _currentSection }).ToList();

                        return rawSchedules.Select(s => {
                            DateTime.TryParse(s.StartTime?.ToString(), out DateTime parsedStart);
                            DateTime.TryParse(s.EndTime?.ToString(), out DateTime parsedEnd);

                            string subjectName = (string)s.Title ?? "Class Lecture";

                            return new LocalAppointment
                            {
                                UniqueId = s.Id.ToString(),
                                Subject = subjectName,
                                Description = $"Assigned Section: {_currentSection}",
                                StartTime = parsedStart.ToString("yyyy-MM-dd HH:mm:ss"),
                                EndTime = parsedEnd.ToString("yyyy-MM-dd HH:mm:ss"),
                                LabelKey = _currentSection == "NEUMANN" ? 1 : 2,
                                StatusKey = 0,
                                AllDay = false,
                                Location = "Main Campus"
                            };
                        }).ToList();
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