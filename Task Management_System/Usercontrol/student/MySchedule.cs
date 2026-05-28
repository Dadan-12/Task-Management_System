using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.student
{
    public partial class MySchedule : DevExpress.XtraEditors.XtraUserControl
    {
        public MySchedule()
        {
            InitializeComponent();
            RegisterControlPipelineEvents();
        }

        private void RegisterControlPipelineEvents()
        {
            // Event registrations
            this.Load += async (s, e) => await InitializeAndLoadCalendarDataAsync();
            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;
        }

        private async Task InitializeAndLoadCalendarDataAsync()
        {
            schedulerControl1.Start = DateTime.Today;

            // Initialize structural Label configurations matching database key indexes
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    // Asynchronously fetch raw data entities via Dapper ORM layer
                    var appointments = await db.QueryAsync<DbAppointment>("SELECT * FROM Appointments;");

                    // Freeze layout updates on the Scheduler Control itself rather than Storage for execution smoothness
                    schedulerControl1.BeginUpdate();
                    schedulerDataStorage1.Appointments.Items.Clear();

                    foreach (var entity in appointments)
                    {
                        Appointment apt = schedulerDataStorage1.CreateAppointment(AppointmentType.Normal);

                        // Use SetAppointmentId to safely inject custom identifiers into read-only property fields
                        schedulerDataStorage1.SetAppointmentId(apt, entity.UniqueId);

                        apt.Subject = entity.Subject;
                        apt.Description = entity.Description;
                        apt.Start = Convert.ToDateTime(entity.StartTime); // Safe casting wrapper if type is DB Text
                        apt.End = Convert.ToDateTime(entity.EndTime);
                        apt.LabelKey = entity.LabelKey;
                        apt.StatusKey = entity.StatusKey;
                        apt.AllDay = entity.AllDay;
                        apt.Location = entity.Location;

                        schedulerDataStorage1.Appointments.Items.Add(apt);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed loading synchronized data records: {ex.Message}", "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Release visual layout processing freeze safely inside the finally block
                schedulerControl1.EndUpdate();
            }
        }

        // ====================== TAB SWITCHING LOGIC ======================
        private void XtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == null) return;

            schedulerControl1.ActiveViewType = e.Page.Text switch
            {
                "Daily" => SchedulerViewType.Day,
                "Weekly" => SchedulerViewType.Week,
                "Monthly" => SchedulerViewType.Month,
                _ => SchedulerViewType.Month
            };
        }
    }
}