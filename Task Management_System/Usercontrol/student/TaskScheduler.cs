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
        // 📍 STORAGE STACK: Data-binding container layer assigned to the main task scheduler view
        private BindingList<Task_Management_System.Models.DbAppointment> schedulerAppointmentsList = new BindingList<Task_Management_System.Models.DbAppointment>();

        // 📍 STATE TRACKER: Tracks active background tasks to protect internal database mapping from false data write triggers
        private bool isDataLoading = false;

        public TaskScheduler()
        {
            InitializeComponent();
            SetupSchedulerConfigurations();
            RegisterEventHandlers();
            InitializeSchedulerDefaults();
        }

        // 📍 SCHEDULER CONFIGURATION: Maps data-source properties directly to model entity structures
        private void SetupSchedulerConfigurations()
        {
            AppointmentMappingInfo mappings = schedulerDataStorage1.Appointments.Mappings;

            mappings.AppointmentId = nameof(Task_Management_System.Models.DbAppointment.UniqueId);
            mappings.Subject = nameof(Task_Management_System.Models.DbAppointment.Subject);
            mappings.Description = nameof(Task_Management_System.Models.DbAppointment.Description);
            mappings.Start = nameof(Task_Management_System.Models.DbAppointment.StartTime);
            mappings.End = nameof(Task_Management_System.Models.DbAppointment.EndTime);
            mappings.Label = nameof(Task_Management_System.Models.DbAppointment.LabelKey);
            mappings.Status = nameof(Task_Management_System.Models.DbAppointment.StatusKey);
            mappings.AllDay = nameof(Task_Management_System.Models.DbAppointment.AllDay);
            mappings.Location = nameof(Task_Management_System.Models.DbAppointment.Location);

            // 📍 REMINDER CONFIGURATION: Forces empty assignments to bypass runtime field validation errors
            mappings.ReminderInfo = "";

            schedulerDataStorage1.Appointments.DataSource = schedulerAppointmentsList;
        }

        // 📍 EVENT REGISTRATION: Chains control signals to interactive background update routines
        private void RegisterEventHandlers()
        {
            btnAddNewTask.Click += BtnAddNewTask_Click;
            schedulerControl1.PopupMenuShowing += SchedulerControl1_PopupMenuShowing;
            radioGroupViewSwitcher.SelectedIndexChanged += RadioGroupViewSwitcher_SelectedIndexChanged;

            schedulerDataStorage1.AppointmentsInserted += SchedulerDataStorage1_AppointmentsSaveOrUpdate;
            schedulerDataStorage1.AppointmentsChanged += SchedulerDataStorage1_AppointmentsSaveOrUpdate;
            schedulerDataStorage1.AppointmentsDeleted += SchedulerDataStorage1_AppointmentsDeleted;
        }

        // 📍 CALENDAR SETTINGS: Sets initial calendar view parameters on load execution paths
        private void InitializeSchedulerDefaults()
        {
            schedulerControl1.Start = DateTime.Today;
        }

        // 📍 LIFECYCLE INITIALIZER: Automatically fills local container data maps when window controls instantiate
        protected override async void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (schedulerAppointmentsList.Count == 0)
            {
                await LoadSchedulerDataAsync();
            }
        }

        // 📍 DATA FETCH ENGINE: Pulls unified model records asynchronously via non-blocking queries
        public async Task LoadSchedulerDataAsync()
        {
            if (isDataLoading) return;

            try
            {
                isDataLoading = true;

                using (var db = DatabaseContext.CreateConnection())
                {
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
                isDataLoading = false;
            }
        }

        // 📍 TRANSACTION BRIDGE: Maps operational fields and targets single records for save or change updates
        private async void SchedulerDataStorage1_AppointmentsSaveOrUpdate(object sender, PersistentObjectsEventArgs e)
        {
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

        // 📍 DELETION DISPATCH LAYER: Cleans database targets based on interactive removal commands
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

        // 📍 MODAL WINDOW WRAPPER: Generates dynamic allocation dialog windows to run create or edit controls cleanly
        private async void OpenCustomAllocationForm(Task_Management_System.Models.DbAppointment existingAppointment = null)
        {
            using (XtraForm formContainer = new XtraForm())
            {
                var customAllocationUC = new uc_AddTaskAllocation();

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

                formContainer.ShowDialog(this);

                if (customAllocationUC.ResultAppointment != null)
                {
                    await LoadSchedulerDataAsync();
                }
            }
        }

        // 📍 INTERACTION DISPATCH: Action wrapper triggering default task allocation workflows
        private void BtnAddNewTask_Click(object sender, EventArgs e)
        {
            OpenCustomAllocationForm();
        }

        // 📍 DISPLAY SWITCH LOGIC: Maps indexing layout controls onto structural DevExpress calendar configurations
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

        // 📍 CONTEXT MENU CONTROLLER: Strips default layouts and overrides options based on row focus parameters
        private void SchedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Clear();
            e.Menu.Items.Add(new DXMenuItem("➕ Add New Task", (s, ev) => OpenCustomAllocationForm()));

            if (schedulerControl1.SelectedAppointments.Count > 0)
            {
                var targetedAppointment = schedulerControl1.SelectedAppointments[0];

                e.Menu.Items.Add(new DXMenuItem("✏️ Edit Appointment", (s, ev) =>
                {
                    if (targetedAppointment.GetRow(schedulerDataStorage1) is Task_Management_System.Models.DbAppointment boundModelItem)
                    {
                        OpenCustomAllocationForm(boundModelItem);
                    }
                }));

                e.Menu.Items.Add(new DXMenuItem("🗑 Delete Appointment", (s, ev) => DeleteAppointmentWithConfirmation()));
            }
        }

        // 📍 CONFIRMATION DIALOG HANDLER: Interrupts execution threads to verify data deletions manually
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