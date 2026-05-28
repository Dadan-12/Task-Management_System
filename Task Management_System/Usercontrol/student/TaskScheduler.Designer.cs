namespace Task_Management_System.Usercontrol.student
{
    partial class TaskScheduler
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();

            var timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            var timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            var timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();

            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnAddNewTask = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            this.SuspendLayout();

            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnAddNewTask.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewTask.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(1693, 40);
            this.btnAddNewTask.TabIndex = 0;
            this.btnAddNewTask.Text = "➕ Add New Task / Schedule";
            this.btnAddNewTask.UseVisualStyleBackColor = true;

            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1693, 40);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.Add("Daily", "Daily");
            this.tabControl1.TabPages.Add("Weekly", "Weekly");
            this.tabControl1.TabPages.Add("Monthly", "Monthly");

            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 80);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(1693, 1076);
            this.schedulerControl1.TabIndex = 2;

            // 
            // Views Configuration
            // 
            this.schedulerControl1.Views.DayView.Enabled = true;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.MonthView.Enabled = true;
            this.schedulerControl1.Views.WorkWeekView.Enabled = true;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.Enabled = false;
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;

            // 
            // OptionsCustomization
            // 
            this.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.All;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.All;
            this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.All;

            // 
            // schedulerDataStorage1 Labels Schema
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            this.schedulerDataStorage1.Appointments.Labels.Clear();
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Class", "&Class", System.Drawing.Color.FromArgb(168, 213, 255));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Exam", "&Exam", System.Drawing.Color.FromArgb(255, 194, 190));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Assignment", "&Assignment", System.Drawing.Color.FromArgb(193, 244, 156));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Project", "&Project", System.Drawing.Color.FromArgb(244, 206, 147));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Meeting", "&Meeting", System.Drawing.Color.FromArgb(207, 219, 152));
            this.schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Personal", "&Personal", System.Drawing.Color.FromArgb(224, 207, 233));

            // 
            // TaskScheduler Layout Composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Reordered strictly back-to-front by stack order for proper Z-Index docking behavior
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddNewTask);

            this.Name = "TaskScheduler";
            this.Size = new System.Drawing.Size(1693, 1156);

            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAddNewTask;
    }
}