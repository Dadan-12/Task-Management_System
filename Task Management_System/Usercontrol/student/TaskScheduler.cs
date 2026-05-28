using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using Dapper;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.student
{
    public partial class TaskScheduler : DevExpress.XtraEditors.XtraUserControl
    {
        // 🎯 TARGETED: Direct internal data binding targeted cleanly to DbAppointment structures
        private BindingList<Task_Management_System.Models.DbAppointment> schedulerAppointmentsList = new BindingList<Task_Management_System.Models.DbAppointment>();

        // 🛡️ STATE TRACKER: Tracks if data is currently initializing from the database.
        // This prevents the scheduler from treating initial loads as new user-created tasks.
        private bool isDataLoading = false;

        public TaskScheduler()
        {
            InitializeComponent();
            SetupSchedulerConfigurations();
            RegisterEventHandlers();
            InitializeSchedulerDefaults();
        }

        private void SetupSchedulerConfigurations()
        {
            AppointmentMappingInfo mappings = schedulerDataStorage1.Appointments.Mappings;

            // Property mappings cleanly pointing to DbAppointment structure fields
            mappings.AppointmentId = nameof(Task_Management_System.Models.DbAppointment.UniqueId);
            mappings.Subject = nameof(Task_Management_System.Models.DbAppointment.Subject);
            mappings.Description = nameof(Task_Management_System.Models.DbAppointment.Description);
            mappings.Start = nameof(Task_Management_System.Models.DbAppointment.StartTime);
            mappings.End = nameof(Task_Management_System.Models.DbAppointment.EndTime);
            mappings.Label = nameof(Task_Management_System.Models.DbAppointment.LabelKey);
            mappings.Status = nameof(Task_Management_System.Models.DbAppointment.StatusKey);
            mappings.AllDay = nameof(Task_Management_System.Models.DbAppointment.AllDay);
            mappings.Location = nameof(Task_Management_System.Models.DbAppointment.Location);

            // 🎯 FIXED ERROR: Explicitly empty out the ReminderInfo mapping.
            // This prevents DevExpress from searching for missing properties and resolves SQLite saving crashes.
            mappings.ReminderInfo = "";

            schedulerDataStorage1.Appointments.DataSource = schedulerAppointmentsList;
        }

        private void RegisterEventHandlers()
        {
            btnAddNewTask.Click += BtnAddNewTask_Click;
            schedulerControl1.PopupMenuShowing += SchedulerControl1_PopupMenuShowing;
            radioGroupViewSwitcher.SelectedIndexChanged += RadioGroupViewSwitcher_SelectedIndexChanged;

            schedulerDataStorage1.AppointmentsInserted += SchedulerDataStorage1_AppointmentsSaveOrUpdate;
            schedulerDataStorage1.AppointmentsChanged += SchedulerDataStorage1_AppointmentsSaveOrUpdate;
            schedulerDataStorage1.AppointmentsDeleted += SchedulerDataStorage1_AppointmentsDeleted;
        }

        private void InitializeSchedulerDefaults()
        {
            schedulerControl1.Start = DateTime.Today;
        }

        protected override async void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (schedulerAppointmentsList.Count == 0)
            {
                await LoadSchedulerDataAsync();
            }
        }

        public async Task LoadSchedulerDataAsync()
        {
            if (isDataLoading) return;

            try
            {
                // Set flag to true to lock save/update triggers while pulling records
                isDataLoading = true;

                using (var db = DatabaseContext.CreateConnection())
                {
                    // Unified Dapper mapper retrieval engine pulling from the common table
                    var appointments = await db.QueryAsync<Task_Management_System.Models.DbAppointment>("SELECT * FROM Appointments;");

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            schedulerControl1.BeginUpdate();
                            try
                            {
                                schedulerAppointmentsList.Clear();
                                foreach (var entity in appointments)
                                {
                                    schedulerAppointmentsList.Add(entity);
                                }
                            }
                            finally
                            {
                                schedulerControl1.EndUpdate();
                            }
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed loading synchronized data records: {ex.Message}",
                    "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always unlock loading flag state upon routine completion
                isDataLoading = false;
            }
        }

        private async void SchedulerDataStorage1_AppointmentsSaveOrUpdate(object sender, PersistentObjectsEventArgs e)
        {
            // 🛡️ INTERCEPT LOADS: Abort database insertion if changes are triggered by data loading routines
            if (isDataLoading) return;

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    foreach (Appointment apt in e.Objects)
                    {
                        string targetId;

                        if (apt.Id == null || string.IsNullOrEmpty(apt.Id.ToString()))
                        {
                            targetId = Guid.NewGuid().ToString();
                            schedulerDataStorage1.SetAppointmentId(apt, targetId);
                        }
                        else
                        {
                            targetId = apt.Id.ToString();
                        }

                        // Explicit construction utilizing unified DbAppointment namespace structure
                        var model = new Task_Management_System.Models.DbAppointment
                        {
                            UniqueId = targetId,
                            Subject = apt.Subject ?? "Untitled Task",
                            Description = apt.Description ?? "",
                            StartTime = apt.Start.ToString("yyyy-MM-dd HH:mm:ss"),
                            EndTime = apt.End.ToString("yyyy-MM-dd HH:mm:ss"),
                            LabelKey = Convert.ToInt32(apt.LabelKey),
                            StatusKey = Convert.ToInt32(apt.StatusKey),
                            AllDay = apt.AllDay,
                            Location = apt.Location ?? "",
                            ReminderInfo = ""
                        };

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

                        await db.ExecuteAsync(sql, model);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Error saving changes to database: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SchedulerDataStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            if (isDataLoading) return;

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    foreach (Appointment apt in e.Objects)
                    {
                        if (apt.Id != null)
                        {
                            await db.ExecuteAsync("DELETE FROM Appointments WHERE UniqueId = @UniqueId;", new { UniqueId = apt.Id.ToString() });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Error deleting records from database: {ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Launches the custom uc_AddTaskAllocation control inside a tidy dialog wrapper window.
        /// </summary>
        private async void OpenCustomAllocationForm(Task_Management_System.Models.DbAppointment existingAppointment = null)
        {
            using (XtraForm formContainer = new XtraForm())
            {
                var customAllocationUC = new uc_AddTaskAllocation();

                // If an appointment parameter is passed, inject it into edit mode lifecycle
                if (existingAppointment != null)
                {
                    customAllocationUC.LoadAppointmentData(existingAppointment);
                }

                formContainer.Text = existingAppointment == null ? "Create New Allocation" : "Modify Task Allocation";
                formContainer.FormBorderStyle = FormBorderStyle.FixedDialog;
                formContainer.MaximizeBox = false;
                formContainer.MinimizeBox = false;
                formContainer.StartPosition = FormStartPosition.CenterParent;
                formContainer.ClientSize = customAllocationUC.Size;

                customAllocationUC.Dock = DockStyle.Fill;
                formContainer.Controls.Add(customAllocationUC);

                // Blocks active UI code thread execution path until user cancels or saves the entity
                formContainer.ShowDialog(this);

                // If modifications occurred inside the modal boundary contexts, pull updates from SQLite
                if (customAllocationUC.ResultAppointment != null)
                {
                    await LoadSchedulerDataAsync();
                }
            }
        }

        private void BtnAddNewTask_Click(object sender, EventArgs e)
        {
            OpenCustomAllocationForm();
        }

        private void RadioGroupViewSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedView = radioGroupViewSwitcher.EditValue?.ToString();
            if (string.IsNullOrEmpty(selectedView)) return;

            schedulerControl1.ActiveViewType = selectedView switch
            {
                "Daily" => SchedulerViewType.Day,
                "Weekly" => SchedulerViewType.Week,
                "Monthly" => SchedulerViewType.Month,
                _ => SchedulerViewType.Month
            };
        }

        private void SchedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
            e.Menu.Items.Add(new DXMenuItem("➕ Add New Task", (s, ev) => OpenCustomAllocationForm()));

            if (schedulerControl1.SelectedAppointments.Count > 0)
            {
                var targetedAppointment = schedulerControl1.SelectedAppointments[0];

                e.Menu.Items.Add(new DXMenuItem("✏️ Edit Appointment", (s, ev) =>
                {
                    // Clean structural unpacking extraction routine targeting the data-source reference object mapping row
                    if (targetedAppointment.GetRow(schedulerDataStorage1) is Task_Management_System.Models.DbAppointment boundModelItem)
                    {
                        OpenCustomAllocationForm(boundModelItem);
                    }
                }));

                e.Menu.Items.Add(new DXMenuItem("🗑 Delete Appointment", (s, ev) => DeleteAppointmentWithConfirmation()));
            }
        }

        private void DeleteAppointmentWithConfirmation()
        {
            if (schedulerControl1.SelectedAppointments.Count == 0) return;

            var promptResult = XtraMessageBox.Show(
                this,
                "Are you sure you want to permanently delete this appointment?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (promptResult == DialogResult.Yes)
            {
                schedulerControl1.DeleteSelectedAppointments();
            }
        }
    }
}