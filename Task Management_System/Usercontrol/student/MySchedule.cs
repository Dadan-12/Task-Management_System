using System;
using System.Collections; // Required for IList tracking
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Usercontrol.student
{
    public partial class MySchedule : DevExpress.XtraEditors.XtraUserControl
    {
        // Tracks live database memory state for real-time synchronization updates
        private BindingList<DbAppointment> dataSourceList = new BindingList<DbAppointment>();

        // 🛡️ STATE TRACKER: Tracks if data is currently initializing from the database.
        // This prevents the storage engine from processing loading records as new user inserts.
        private bool isDataLoading = false;

        public MySchedule()
        {
            InitializeComponent();
            RegisterControlPipelineEvents();
            SetupSchedulerMappings();
        }

        private void RegisterControlPipelineEvents()
        {
            // Event registrations
            // 🔄 LIFECYCLE MANAGEMENT: Swapped from '.Load' to 'OnHandleCreated' to process panel swaps reliably
            this.HandleCreated += async (s, e) => {
                if (dataSourceList.Count == 0)
                {
                    await InitializeAndLoadCalendarDataAsync();
                }
            };

            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;

            // FIX: e.Objects is an IList, passing it directly fits the updated signature below
            schedulerDataStorage1.AppointmentsInserted += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Insert);
            schedulerDataStorage1.AppointmentsChanged += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Update);
            schedulerDataStorage1.AppointmentsDeleted += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Delete);
        }

        private void SetupSchedulerMappings()
        {
            // 1. Structural Mapping Definitions: Connects DevExpress keys directly to DbAppointment fields
            AppointmentMappingInfo mappings = schedulerDataStorage1.Appointments.Mappings;
            mappings.AppointmentId = nameof(DbAppointment.UniqueId);
            mappings.Subject = nameof(DbAppointment.Subject);
            mappings.Description = nameof(DbAppointment.Description);
            mappings.Start = nameof(DbAppointment.StartTime);
            mappings.End = nameof(DbAppointment.EndTime);
            mappings.Label = nameof(DbAppointment.LabelKey);
            mappings.Status = nameof(DbAppointment.StatusKey);
            mappings.AllDay = nameof(DbAppointment.AllDay);
            mappings.Location = nameof(DbAppointment.Location);

            // FIXED ERROR: Explicitly empty out the ReminderInfo mapping. 
            // This forces DevExpress to ignore reminders, resolving the SQLite column crash!
            mappings.ReminderInfo = "";

            // 2. Initialize Structural Label configurations matching database key indexes
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            // 3. Connect the binding list to the control source engine
            schedulerDataStorage1.Appointments.DataSource = dataSourceList;
        }

        // 🎯 FIXED ERROR: Changed from 'private' to 'public' to resolve the protection level error
        // and allow cross-control data reloading from StudentDashboard.cs
        public async Task InitializeAndLoadCalendarDataAsync()
        {
            if (isDataLoading) return;

            schedulerControl1.Start = DateTime.Today;

            try
            {
                // Lock saving routines while populating raw values from SQLite
                isDataLoading = true;

                using (var db = DatabaseContext.CreateConnection())
                {
                    // Asynchronously fetch raw data entities via Dapper ORM layer
                    var appointments = await db.QueryAsync<DbAppointment>("SELECT * FROM Appointments;");

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            schedulerControl1.BeginUpdate();
                            try
                            {
                                // Clear out and re-populate the live dataset source 
                                dataSourceList.Clear();
                                foreach (var entity in appointments)
                                {
                                    dataSourceList.Add(entity);
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
                XtraMessageBox.Show(this, $"Failed loading synchronized data records: {ex.Message}", "Database Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Unblock state tracking flags upon completion
                isDataLoading = false;
            }
        }

        // ====================== ASYNC DATABASE SYNCHRONIZATION TRANSACTION PIPELINE ======================
        private enum DataAction { Insert, Update, Delete }

        // FIX: Replaced 'PersistentObjectCollection' parameter with 'IList' to natively process 'e.Objects'
        private async Task HandleAppointmentsSavedToDbAsync(IList items, DataAction action)
        {
            // 🛡️ INTERCEPT LOADS: Abort operational writes if alterations stem from control rendering or initialization updates
            if (isDataLoading) return;
            if (items == null || items.Count == 0) return;

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    foreach (var item in items)
                    {
                        // Cast the plain list item to an active DevExpress Appointment context object wrapper safely
                        if (!(item is Appointment apt)) continue;

                        // Extract original model reference structure out of the bound storage framework row context
                        var entity = apt.GetRow(schedulerDataStorage1) as DbAppointment;

                        if (entity == null) continue;

                        switch (action)
                        {
                            case DataAction.Insert:
                                // Generate text identifier strings matching the model layout signatures
                                string cleanGuid = Guid.NewGuid().ToString();
                                entity.UniqueId = cleanGuid;
                                schedulerDataStorage1.SetAppointmentId(apt, cleanGuid);

                                string insertSql = @"
                                    INSERT INTO Appointments (UniqueId, Subject, Description, StartTime, EndTime, LabelKey, StatusKey, AllDay, Location)
                                    VALUES (@UniqueId, @Subject, @Description, @StartTime, @EndTime, @LabelKey, @StatusKey, @AllDay, @Location);";

                                await db.ExecuteAsync(insertSql, entity);
                                break;

                            case DataAction.Update:
                                string updateSql = @"
                                    UPDATE Appointments 
                                    SET Subject = @Subject, 
                                        Description = @Description, 
                                        StartTime = @StartTime, 
                                        EndTime = @EndTime, 
                                        LabelKey = @LabelKey, 
                                        StatusKey = @StatusKey, 
                                        AllDay = @AllDay, 
                                        Location = @Location 
                                    WHERE UniqueId = @UniqueId;";

                                await db.ExecuteAsync(updateSql, entity);
                                break;

                            case DataAction.Delete:
                                string deleteSql = "DELETE FROM Appointments WHERE UniqueId = @UniqueId;";
                                await db.ExecuteAsync(deleteSql, new { UniqueId = entity.UniqueId });
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, $"Failed to sync real-time visual modifications with server: {ex.Message}", "Sync Processing Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Fallback: Rollback local view layout mapping records state on exception to maintain data consistency
                await InitializeAndLoadCalendarDataAsync();
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