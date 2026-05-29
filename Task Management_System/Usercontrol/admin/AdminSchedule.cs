using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class AdminScheduleUC : XtraUserControl
    {
        private readonly DataBase db = new DataBase();

        public AdminScheduleUC()
        {
            InitializeComponent();

            // 📍 PIPELINE LINK: Connect UI deletion actions to the persistent data storage triggers
            schedulerDataStorage1.AppointmentDeleting += Storage_AppointmentDeleting;
            storageSection2.AppointmentDeleting += Storage_AppointmentDeleting;

            // 📍 UI PRESETS: Initialize baseline course choices
            cbSubject.Properties.Items.AddRange(new object[]
            {
                "Mathematics", "Science", "English", "Filipino",
                "History", "P.E.", "Computer", "Values Education"
            });
            cbSubject.SelectedIndex = 0;

            // 📍 TIME AUTOMATION: Automatically scale the end-time to default to a 1-hour session duration
            tFrom.EditValueChanged += (s, e) => tTo.Time = tFrom.Time.AddHours(1);

            // 📍 NAVIGATION MONITOR: Dynamic display syncing when toggling structural tabs
            xtraTabPageN.SelectedPageChanged += XtraTabPageN_SelectedPageChanged;
            UpdateSectionLabel();

            LoadSchedules();
        }

        private void XtraTabPageN_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            UpdateSectionLabel();
        }

        private void UpdateSectionLabel()
        {
            string section = xtraTabPageN.SelectedTabPage == xtraTabPage3 ? "NEUMANN" : "AIKEN";
            lblSection.Text = $"Section: {section}";
        }

        // 📍 SYNCED PIPELINE REMOVAL: Triggers live drop actions targeting the shared ClassSchedule matrix records
        private void Storage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            try
            {
                var apt = e.Object as Appointment;
                if (apt == null || !int.TryParse(apt.Description, out int id)) return;

                using var con = db.GetConnection();

                // ✔ Synced Table: Changed target from Schedule to ClassSchedule to align with the Student view
                con.Execute("DELETE FROM ClassSchedule WHERE Id = @Id", new { Id = id });
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Delete error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 SYNCED PIPELINE ACQUISITION: Pulls data matching parameters mapped on the student desktop views
        public void LoadSchedules()
        {
            try
            {
                schedulerDataStorage1.Appointments.Clear();
                storageSection2.Appointments.Clear();

                using var con = db.GetConnection();

                // ✔ Synced Table: Grabbing administrative blocks directly out of ClassSchedule master storage
                foreach (var s in con.Query("SELECT * FROM ClassSchedule"))
                {
                    if (!DateTime.TryParse(s.StartTime.ToString(), out DateTime start)) continue;
                    if (!DateTime.TryParse(s.EndTime.ToString(), out DateTime end)) continue;
                    if (start.Year < 2000 || end <= start) continue;

                    var storage = s.Section == "NEUMANN" ? schedulerDataStorage1 : storageSection2;
                    var apt = storage.CreateAppointment(AppointmentType.Normal);

                    apt.Subject = s.Title;
                    apt.Start = start;
                    apt.End = end;
                    apt.LabelId = s.Section == "NEUMANN" ? 2 : 3;
                    apt.Description = s.Id.ToString();

                    storage.Appointments.Add(apt);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Load error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 SYNCED PIPELINE INSERTION: Pushes formatted courses directly out to student timeline panels
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string section = xtraTabPageN.SelectedTabPage == xtraTabPage3 ? "NEUMANN" : "AIKEN";
            string subject = cbSubject.Text;
            DateTime start = dtFrom.DateTime.Date + tFrom.Time.TimeOfDay;
            DateTime end = dtFrom.DateTime.Date + tTo.Time.TimeOfDay;

            if (end <= start)
            {
                XtraMessageBox.Show("End time must be after start time.",
                    "Invalid Timespan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var con = db.GetConnection();

                // ✔ Synced Table: Direct insertion pipeline into the verified student ClassSchedule data source
                con.Execute(
                    "INSERT INTO ClassSchedule (Title, StartTime, EndTime, Section) VALUES (@Title, @StartTime, @EndTime, @Section)",
                    new
                    {
                        Title = subject,
                        StartTime = start.ToString("yyyy-MM-dd HH:mm:ss"),
                        EndTime = end.ToString("yyyy-MM-dd HH:mm:ss"),
                        Section = section
                    });

                LoadSchedules();

                cbSubject.SelectedIndex = 0;
                dtFrom.DateTime = DateTime.Today;

                XtraMessageBox.Show($"Schedule successfully added to {section}!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Save error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}