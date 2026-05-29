using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.student
{
    public partial class MyClassSchedule : XtraUserControl
    {
        private readonly DataBase db = new DataBase();
        private dynamic _activeStudentProfile;

        public MyClassSchedule()
        {
            InitializeComponent();

            sideDateNavigator.SchedulerControl = classSchedulerControl;
            classSchedulerControl.ActiveViewType = SchedulerViewType.WorkWeek;

            classSchedulerControl.ToolTipController = toolTipController1;
            toolTipController1.BeforeShow += ToolTipController1_BeforeShow;
        }

        // 📍 DATA SYNC METHOD: Connects to backend table layout using active profile variables
        public async System.Threading.Tasks.Task LoadClassSchedulesAsync(dynamic studentProfile)
        {
            try
            {
                this._activeStudentProfile = studentProfile;
                classSchedulerDataStorage.Appointments.Clear();

                if (_activeStudentProfile == null) return;

                // 📍 FILTER KEYVALUE: Extracts current student's structural group reference
                string studentSection = _activeStudentProfile.Section;

                using var con = db.GetConnection();

                // 📍 DATABASE CONNECTIVITY QUERY: Selects matching layout constraints set by Admin
                var classSchedules = await con.QueryAsync(
                    "SELECT * FROM ClassSchedule WHERE Section = @Section",
                    new { Section = studentSection }
                );

                classSchedulerControl.BeginUpdate();

                foreach (var c in classSchedules)
                {
                    if (!DateTime.TryParse(c.StartTime.ToString(), out DateTime start)) continue;
                    if (!DateTime.TryParse(c.EndTime.ToString(), out DateTime end)) continue;
                    if (start.Year < 2000 || end <= start) continue;

                    Appointment apt = classSchedulerDataStorage.CreateAppointment(AppointmentType.Normal);

                    // 📍 GRID PRESENTATION DATA: Strict baseline visualization bindings
                    apt.Subject = $"{c.Title}";
                    apt.Location = $"Code: {c.Section}";
                    apt.Start = start;
                    apt.End = end;
                    apt.LabelId = 1;

                    // 📍 METADATA ISOLATION TEXTFRAME: Confines visibility to Subject, Code, Date, and Time
                    apt.Description = $"<b>Subject:</b> {c.Title}<br>" +
                                      $"<b>Subject Code:</b> {c.Section}<br>" +
                                      $"<b>Date:</b> {start:MMMM dd, yyyy}<br>" +
                                      $"<b>Time:</b> {start:hh:mm tt} - {end:hh:mm tt}";

                    classSchedulerDataStorage.Appointments.Add(apt);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Unable to sync academic timeline matrices: {ex.Message}", "Sync Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                classSchedulerControl.EndUpdate();
            }
        }

        // 📍 TOOLTIP INTERCEPT ENGINE: Forces HTML display styles execution over custom description elements
        private void ToolTipController1_BeforeShow(object sender, DevExpress.Utils.ToolTipControllerShowEventArgs e)
        {
            var cellObject = e.SelectedObject as AppointmentViewInfo;
            if (cellObject != null && cellObject.Appointment != null)
            {
                e.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
                e.Title = "Class Schedule Details";
                e.ToolTip = cellObject.Appointment.Description;
            }
        }
    }
}