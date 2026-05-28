using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management_System.Usercontrol.student
{
    public partial class TaskScheduler : DevExpress.XtraEditors.XtraUserControl
    {
        public TaskScheduler()
        {
            InitializeComponent();

            // Attach Events
            btnAddNewTask.Click += btnAddNewTask_Click;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            schedulerControl1.PopupMenuShowing += schedulerControl1_PopupMenuShowing;
        }

        // ====================== EVENT HANDLERS ======================

        private void btnAddNewTask_Click(object sender, EventArgs e)
        {
            schedulerControl1.CreateNewAppointment();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == null) return;

            switch (tabControl1.SelectedTab.Text)
            {
                case "Daily":
                    schedulerControl1.ActiveViewType = SchedulerViewType.Day;
                    break;

                case "Weekly":
                    schedulerControl1.ActiveViewType = SchedulerViewType.Week;
                    break;

                case "Monthly":
                    schedulerControl1.ActiveViewType = SchedulerViewType.Month;
                    break;
            }
        }

        private void schedulerControl1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            // Clear default menu items and add our custom ones
            e.Menu.Items.Clear();

            // Add New Task (always available)
            e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("➕ Add New Task",
                (s, ev) => schedulerControl1.CreateNewAppointment()));

            // If user right-clicked on an appointment
            if (schedulerControl1.SelectedAppointments.Count > 0)
            {
                var apt = schedulerControl1.SelectedAppointments[0];

                // Edit
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("✏️ Edit Appointment",
                    (s, ev) => schedulerControl1.ShowEditAppointmentForm(apt, false)));   // Fixed method

                // Delete with Confirmation
                e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("🗑 Delete Appointment",
                    (s, ev) => DeleteAppointmentWithConfirmation()));
            }
        }

        private void DeleteAppointmentWithConfirmation()
        {
            if (schedulerControl1.SelectedAppointments.Count == 0) return;

            var result = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                schedulerControl1.DeleteSelectedAppointments();
            }
        }
    }
}