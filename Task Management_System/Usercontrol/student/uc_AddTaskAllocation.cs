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
        // Exposes the committed model to parent view to instantly refresh the schedule interface layout
        public DbAppointment ResultAppointment { get; private set; }
        private string existingUniqueId = null;
        private bool isEditMode = false;

        public uc_AddTaskAllocation()
        {
            InitializeComponent();
            InitializeDefaultValues();
            RegisterLiveEventHandlers();
        }

        /// <summary>
        /// Seeds localized selection data matrix and time offsets on instantiation layouts safely
        /// </summary>
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

        /// <summary>
        /// Registers state change listeners for fluid UI interactions
        /// </summary>
        private void RegisterLiveEventHandlers()
        {
            chkAllDay.CheckedChanged += ChkAllDay_CheckedChanged;
        }

        /// <summary>
        /// Dynamically alters the calendar picker masks based on full-day allocation configurations
        /// </summary>
        private void ChkAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllDay.Checked)
            {
                // Format display to strictly render calendar dates without timestamps
                dateEditStart.Properties.DisplayFormat.FormatString = "d";
                dateEditStart.Properties.EditFormat.FormatString = "d";
                dateEditStart.Properties.MaskSettings.Set("mask", "d");

                // Hide the time edit portion safely using DevExpress properties
                dateEditStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
                dateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Default;

                dateEditEnd.Properties.DisplayFormat.FormatString = "d";
                dateEditEnd.Properties.EditFormat.FormatString = "d";
                dateEditEnd.Properties.MaskSettings.Set("mask", "d");

                // Hide the time edit portion safely using DevExpress properties
                dateEditEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
                dateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Default;

                // Snap current boundaries to clean calendar date bounds
                dateEditStart.DateTime = dateEditStart.DateTime.Date;
                dateEditEnd.DateTime = dateEditEnd.DateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            }
            else
            {
                // Restore precision timeline parameters with embedded drop-down clocks
                dateEditStart.Properties.DisplayFormat.FormatString = "g";
                dateEditStart.Properties.EditFormat.FormatString = "g";
                dateEditStart.Properties.MaskSettings.Set("mask", "g");

                // Restore the time edit section layout
                dateEditStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                dateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;

                dateEditEnd.Properties.DisplayFormat.FormatString = "g";
                dateEditEnd.Properties.EditFormat.FormatString = "g";
                dateEditEnd.Properties.MaskSettings.Set("mask", "g");

                // Restore the time edit section layout
                dateEditEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
                dateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            }
        }

        /// <summary>
        /// Populates text metrics and changes button execution branches when passing selected entries to edit
        /// </summary>
        public void LoadAppointmentData(DbAppointment appointment)
        {
            if (appointment == null) return;

            isEditMode = true;
            existingUniqueId = appointment.UniqueId;

            txtSubject.Text = appointment.Subject;
            txtDescription.Text = appointment.Description;
            txtLocation.Text = appointment.Location;

            // Setting this triggers ChkAllDay_CheckedChanged to apply correct date format constraints automatically
            chkAllDay.Checked = appointment.AllDay;

            if (DateTime.TryParse(appointment.StartTime, out DateTime start)) dateEditStart.DateTime = start;
            if (DateTime.TryParse(appointment.EndTime, out DateTime end)) dateEditEnd.DateTime = end;

            // Boundary validation safety layout constraints
            comboLabel.SelectedIndex = Math.Min(appointment.LabelKey, comboLabel.Properties.Items.Count - 1);
            comboStatus.SelectedIndex = Math.Min(appointment.StatusKey, comboStatus.Properties.Items.Count - 1);

            lblHeaderTitle.Text = "✏️ Edit Task Allocation";
            btnSave.Text = "Update Allocation";
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            // Business Rule Validation Barriers
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

            // Normalize boundaries explicitly before committing into persistent database rows
            if (chkAllDay.Checked)
            {
                adjustedStart = adjustedStart.Date;
                adjustedEnd = adjustedEnd.Date.AddDays(1).AddSeconds(-1);
            }

            // Assemble clean model packet mapping definitions
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
                    // SQLite atomic Upsert statement matching your table structure 
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

                // Smooth execution exit: Find the active form container context instance hosting this object control and shut it down cleanly
                this.FindForm()?.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed committing your changes down into database stream lines: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResultAppointment = null;
            this.FindForm()?.Close();
        }
    }
}