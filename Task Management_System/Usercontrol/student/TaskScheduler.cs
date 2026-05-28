using System;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace Task_Management_System.Usercontrol.student
{
    public partial class TaskScheduler : DevExpress.XtraEditors.XtraUserControl
    {
        public TaskScheduler()
        {
            InitializeComponent();
            RegisterEventHandlers();
            InitializeSchedulerDefaults();
        }

        /// <summary>
        /// Centralizes runtime component event registrations.
        /// </summary>
        private void RegisterEventHandlers()
        {
            btnAddNewTask.Click += BtnAddNewTask_Click;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            schedulerControl1.PopupMenuShowing += SchedulerControl1_PopupMenuShowing;
        }

        /// <summary>
        /// Applies runtime-specific configuration defaults to the scheduler instance.
        /// </summary>
        private void InitializeSchedulerDefaults()
        {
            // Dynamically target the user's current calendar day at execution time
            schedulerControl1.Start = DateTime.Today;
        }

        // ====================== EVENT HANDLERS ======================

        private void BtnAddNewTask_Click(object sender, EventArgs e)
        {
            schedulerControl1.CreateNewAppointment();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == null) return;

            // Senior Refactor: Replaced procedural switch-case block with an expressive pattern switch expression
            schedulerControl1.ActiveViewType = tabControl1.SelectedTab.Text switch
            {
                "Daily" => SchedulerViewType.Day,
                "Weekly" => SchedulerViewType.Week,
                "Monthly" => SchedulerViewType.Month,
                _ => SchedulerViewType.Month
            };
        }

        private void SchedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            // Clear default context-menu items to render custom student actions
            e.Menu.Items.Clear();

            // Action: Add New Task
            e.Menu.Items.Add(new DXMenuItem("➕ Add New Task",
                (s, ev) => schedulerControl1.CreateNewAppointment()));

            // Action contexts targeting pre-existing appointments
            if (schedulerControl1.SelectedAppointments.Count > 0)
            {
                var targetedAppointment = schedulerControl1.SelectedAppointments[0];

                // Action: Edit Appointment
                e.Menu.Items.Add(new DXMenuItem("✏️ Edit Appointment",
                    (s, ev) => schedulerControl1.ShowEditAppointmentForm(targetedAppointment, false)));

                // Action: Delete Appointment
                e.Menu.Items.Add(new DXMenuItem("🗑 Delete Appointment",
                    (s, ev) => DeleteAppointmentWithConfirmation()));
            }
        }

        /// <summary>
        /// Prompts user confirmation within the DevExpress ecosystem prior to data mutation.
        /// </summary>
        private void DeleteAppointmentWithConfirmation()
        {
            if (schedulerControl1.SelectedAppointments.Count == 0) return;

            // Senior Refactor: Standardized native win32 layouts into XtraMessageBox to ensure skin unity
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