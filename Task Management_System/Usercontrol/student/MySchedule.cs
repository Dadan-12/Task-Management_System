using System;
using System.Collections;
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
        // 📍 STORAGE STACK: Core binding list elements and runtime loading state flags
        private BindingList<DbAppointment> dataSourceList = new BindingList<DbAppointment>();
        private bool isDataLoading = false;

        public MySchedule()
        {
            InitializeComponent();
            RegisterControlPipelineEvents();
            SetupSchedulerMappings();
        }

        // 📍 EVENT REGISTRATION: Hooks pipeline lifecycles and runtime action listeners safely
        private void RegisterControlPipelineEvents()
        {
            this.HandleCreated += async (s, e) => {
                if (dataSourceList.Count == 0)
                {
                    await InitializeAndLoadCalendarDataAsync();
                }
            };

            xtraTabControl1.SelectedPageChanged += XtraTabControl1_SelectedPageChanged;

            schedulerDataStorage1.AppointmentsInserted += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Insert);
            schedulerDataStorage1.AppointmentsChanged += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Update);
            schedulerDataStorage1.AppointmentsDeleted += async (s, e) => await HandleAppointmentsSavedToDbAsync(e.Objects, DataAction.Delete);
        }

        // 📍 SCHEDULER CONFIGURATION: Maps structural DevExpress properties and handles label initialization
        private void SetupSchedulerMappings()
        {
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

            // 📍 FIX CORRECTION: Explicitly zero-out reminder metadata to avoid SQLite column parsing conflicts
            mappings.ReminderInfo = "";

            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));

            schedulerDataStorage1.Appointments.DataSource = dataSourceList;
        }

        // 📍 DATA LOADER ENGINE: Asynchronously pulls administrative workspace records down from SQLite storage layers
        public async Task InitializeAndLoadCalendarDataAsync()
        {
            if (isDataLoading) return;

            schedulerControl1.Start = DateTime.Today;

            try
            {
                isDataLoading = true;

                using (var db = DatabaseContext.CreateConnection())
                {
                    var appointments = await db.QueryAsync<DbAppointment>("SELECT * FROM Appointments;");

                    if (this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            schedulerControl1.BeginUpdate();
                            try
                            {
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
                isDataLoading = false;
            }
        }

        // 📍 TRANSACTION ROUTING ENGINE: Intercepts local visual mutations to perform downstream CRUD tasks securely
        private enum DataAction { Insert, Update, Delete }

        private async Task HandleAppointmentsSavedToDbAsync(IList items, DataAction action)
        {
            if (isDataLoading) return;
            if (items == null || items.Count == 0) return;

            try
            {
                using (var db = DatabaseContext.CreateConnection())
                {
                    foreach (var item in items)
                    {
                        if (!(item is Appointment apt)) continue;

                        var entity = apt.GetRow(schedulerDataStorage1) as DbAppointment;
                        if (entity == null) continue;

                        switch (action)
                        {
                            case DataAction.Insert:
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
                await InitializeAndLoadCalendarDataAsync();
            }
        }

        // 📍 VIEWMODE LAYER SWAPPER: Transitions underlying grid layout presentations based on tab choices sequential
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