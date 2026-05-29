using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Usercontrol.student
{
    public partial class uc_AddTaskAllocation : DevExpress.XtraEditors.XtraUserControl
    {
        // 📍 PROPERTY INTERFACE: Exposes the committed model back to parent controls for scheduling list synchronizations
        public DbAppointment ResultAppointment { get; private set; }
        private string existingUniqueId = null;
        private bool isEditMode = false;

        public uc_AddTaskAllocation()
        {
            InitializeComponent();
            InitializeDefaultValues();
            RegisterLiveEventHandlers();
        }

        // 📍 DEFAULTS INITIALIZER: Seeds initial time values and configuration dropdown collections safely
        private void InitializeDefaultValues()
        {
            dateEditStart.DateTime = DateTime.Today.AddHours(9);
            dateEditEnd.DateTime = DateTime.Today.AddHours(10);

            comboLabel.Properties.Items.Clear();
            comboStatus.Properties.Items.Clear();

            comboLabel.Properties.Items.AddRange(new object[] { "Low Priority", "Medium Priority", "High Priority" });
            comboStatus.Properties.Items.AddRange(new object[] { "Not Started", "In Progress", "Completed" });

            comboLabel.SelectedIndex = 0;
            comboStatus.SelectedIndex = 0;
        }

        // 📍 EVENT REGISTRATION: Hooks component signals onto real-time reactive interface routines
        private void RegisterLiveEventHandlers()
        {
            chkAllDay.CheckedChanged += ChkAllDay_CheckedChanged;
        }

        // 📍 MASK CONTROLLER: Dynamically updates DevExpress calendar picker masks and date boundary alignments based on all-day flags
        private void ChkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllDay.Checked)
            {
                dateEditStart.Properties.DisplayFormat.FormatString = "d";
                dateEditStart.Properties.EditFormat.FormatString = "d";
                dateEditStart.Properties.MaskSettings.Set("mask", "d");

                dateEditStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
                dateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Default;

                dateEditEnd.Properties.DisplayFormat.FormatString = "d";
                dateEditEnd.Properties.EditFormat.FormatString = "d";
                dateEditEnd.Properties.MaskSettings.Set("mask", "d");

                dateEditEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
                dateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Default;

                dateEditStart.DateTime = dateEditStart.DateTime.Date;
                dateEditEnd.DateTime = dateEditEnd.DateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            else
            {
                dateEditStart.Properties.DisplayFormat.FormatString = "g";
                dateEditStart.Properties.EditFormat.FormatString = "g";
                dateEditStart.Properties.MaskSettings.Set("mask", "g");

                dateEditStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                dateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;

                dateEditEnd.Properties.DisplayFormat.FormatString = "g";
                dateEditEnd.Properties.EditFormat.FormatString = "g";
                dateEditEnd.Properties.MaskSettings.Set("mask", "g");

                dateEditEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                dateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            }
        }

        // 📍 DATA INJECTION LAYER: Populates editing properties and adjusts button copy when initializing inside edit lifecycles
        public void LoadAppointmentData(DbAppointment appointment)
        {
            if (appointment == null) return;

            isEditMode = true;
            existingUniqueId = appointment.UniqueId;

            txtSubject.Text = appointment.Subject;
            txtDescription.Text = appointment.Description;
            txtLocation.Text = appointment.Location;

            chkAllDay.Checked = appointment.AllDay;

            if (DateTime.TryParse(appointment.StartTime, out DateTime start)) dateEditStart.DateTime = start;
            if (DateTime.TryParse(appointment.EndTime, out DateTime end)) dateEditEnd.DateTime = end;

            comboLabel.SelectedIndex = Math.Min(appointment.LabelKey, comboLabel.Properties.Items.Count - 1);
            comboStatus.SelectedIndex = Math.Min(appointment.StatusKey, comboStatus.Properties.Items.Count - 1);

            lblHeaderTitle.Text = "✏️ Edit Task Allocation";
            btnSave.Text = "Update Allocation";
        }

        // 📍 PERSISTENCE PIPELINE: Validates entry variables and fires an atomic async SQLite Upsert transaction
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                XtraMessageBox.Show(this, "Please provide a valid Subject Title for this allocation.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateEditEnd.DateTime < dateEditStart.DateTime)
            {
                XtraMessageBox.Show(this, "The ending deadline context bounds cannot trail before the starting range metric.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime adjustedStart = dateEditStart.DateTime;
            DateTime adjustedEnd = dateEditEnd.DateTime;

            if (chkAllDay.Checked)
            {
                adjustedStart = adjustedStart.Date;
                adjustedEnd = adjustedEnd.Date.AddDays(1).AddSeconds(-1);
            }

            ResultAppointment = new DbAppointment
            {
                UniqueId = isEditMode ? existingUniqueId : Guid.NewGuid().ToString(),
                Subject = txtSubject.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                StartTime = adjustedStart.ToString("yyyy-MM-dd HH:mm:ss"),
                EndTime = adjustedEnd.ToString("yyyy-MM-dd HH:mm:ss"),
                LabelKey = comboLabel.SelectedIndex,
                StatusKey = comboStatus.SelectedIndex,
                AllDay = chkAllDay.Checked,
                ReminderInfo = ""
            };

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    string sql = @"
                        INSERT INTO Appointments (UniqueId, Subject, Description, StartTime, EndTime, LabelKey, StatusKey, AllDay, Location, ReminderInfo)
                        VALUES (@UniqueId, @Subject, @Description, @StartTime, @EndTime, @LabelKey, @StatusKey, @AllDay, @Location, @ReminderInfo)
                        ON CONFLICT(UniqueId) DO UPDATE SET
                            Subject = @Subject,
                            Description = @Description,
                            StartTime = @StartTime,
                            EndTime = @EndTime,
                            LabelKey = @LabelKey,
                            StatusKey = @StatusKey,
                            AllDay = @AllDay,
                            Location = @Location,
                            ReminderInfo = @ReminderInfo;";

                    await db.ExecuteAsync(sql, ResultAppointment);
                }

                this.FindForm()?.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed committing your changes down into database stream lines: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 INTERACTION TERMINATOR: Resets model references and exits out of the active modal wrapper window cleanly
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResultAppointment = null;
            this.FindForm()?.Close();
        }
    }
}