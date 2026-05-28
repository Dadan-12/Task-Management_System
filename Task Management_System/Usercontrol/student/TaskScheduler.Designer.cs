namespace Task_Management_System.Usercontrol.student
{
    partial class TaskScheduler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();

            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            tabControl1 = new System.Windows.Forms.TabControl();
            btnAddNewTask = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabControl1).BeginInit();
            SuspendLayout();

            // Add New Task Button
            btnAddNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            btnAddNewTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddNewTask.Location = new System.Drawing.Point(0, 0);
            btnAddNewTask.Name = "btnAddNewTask";
            btnAddNewTask.Size = new System.Drawing.Size(1693, 40);
            btnAddNewTask.Text = "➕ Add New Task / Schedule";

            // Tab Control
            tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl1.Height = 40;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            tabControl1.TabPages.Add("Daily", "Daily");
            tabControl1.TabPages.Add("Weekly", "Weekly");
            tabControl1.TabPages.Add("Monthly", "Monthly");

            // Scheduler Control
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 75);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(1693, 1081);
            schedulerControl1.Start = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);

            // Views Configuration
            schedulerControl1.Views.DayView.Enabled = true;
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);

            schedulerControl1.Views.WeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);

            schedulerControl1.Views.MonthView.Enabled = true;
            schedulerControl1.Views.WorkWeekView.Enabled = true;
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            schedulerControl1.Views.YearView.Enabled = false;

            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;

            // Enable Editing
            schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.All;
            schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.All;
            schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.All;

            // Labels
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            schedulerDataStorage1.Appointments.Labels.Clear();
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Meeting", "&Meeting", System.Drawing.Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Personal", "&Personal", System.Drawing.Color.FromArgb(224, 207, 233));

            // Layout
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(schedulerControl1);
            Controls.Add(tabControl1);
            Controls.Add(btnAddNewTask);

            Name = "TaskScheduler";
            Size = new System.Drawing.Size(1693, 1156);

            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAddNewTask;
    }
}