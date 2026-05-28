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

            // ✔ Wire delete to DB
            schedulerDataStorage1.AppointmentDeleting += Storage_AppointmentDeleting;
            storageSection2.AppointmentDeleting += Storage_AppointmentDeleting;

            // ✔ Section choices
            //cbSection.Properties.Items.AddRange(new[] { "NEUMANN", "AIKEN" });
            //cbSection.SelectedIndex = 0;

            // ✔ Subject choices
            cbSubject.Properties.Items.AddRange(new object[]
            { "Mathematics", "Science", "English", "Filipino",
              "History", "P.E.", "Computer", "Values Education" });
            cbSubject.SelectedIndex = 0;

            // ✔ Auto To time = From + 1hr
            tFrom.EditValueChanged += (s, e) => tTo.Time = tFrom.Time.AddHours(1);

            LoadSchedules();
        }

        private void Storage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            try
            {
                var apt = e.Object as Appointment;
                if (!int.TryParse(apt.Description, out int id)) return;
                using var con = db.GetConnection();
                con.Execute("DELETE FROM Schedule WHERE Id = @Id", new { Id = id });
            }
            catch (Exception ex) { XtraMessageBox.Show("Delete error: " + ex.Message); }
        }

        public void LoadSchedules()
        {
            try
            {
                schedulerDataStorage1.Appointments.Clear();
                storageSection2.Appointments.Clear();

                using var con = db.GetConnection();
                foreach (var s in con.Query("SELECT * FROM Schedule"))
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
            catch (Exception ex) { XtraMessageBox.Show("Load error: " + ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ✔ Get section from whichever tab is currently active
            //string section = xtraTabPageN.SelectedTabPage == xtraTabPageN ? "NEUMANN" : "AIKEN";
            string subject = cbSubject.Text;
            DateTime start = dtFrom.DateTime.Date + tFrom.Time.TimeOfDay;
            DateTime end = dtFrom.DateTime.Date + tTo.Time.TimeOfDay;

            if (end <= start)
            {
                XtraMessageBox.Show("End time must be after start time.",
                    "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var con = db.GetConnection();
                con.Execute(
                    "INSERT INTO Schedule (Title,StartTime,EndTime,Section) VALUES (@Title,@StartTime,@EndTime,@Section)",
                    new
                    {
                        Title = subject,
                        StartTime = start.ToString("yyyy-MM-dd HH:mm:ss"),
                        EndTime = end.ToString("yyyy-MM-dd HH:mm:ss"),
                        //Section = section
                    });

                LoadSchedules();
                cbSubject.SelectedIndex = 0;
                dtFrom.DateTime = DateTime.Today;
                //XtraMessageBox.Show($"Schedule added to {section}!", "Success",
                    //MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { XtraMessageBox.Show("Save error: " + ex.Message); }
        
    }
    }
}