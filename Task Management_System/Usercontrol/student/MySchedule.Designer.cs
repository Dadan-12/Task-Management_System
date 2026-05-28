namespace Task_Management_System.Usercontrol.student
{
    partial class MySchedule
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

            // Time Rulers
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();

            // Main Scheduler
            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);

            // Tab Control
            tabControl1 = new System.Windows.Forms.TabControl();

            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabControl1).BeginInit();
            SuspendLayout();

            // =============================================
            // Tab Control Setup
            // =============================================
            tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(2224, 30);
            tabControl1.TabIndex = 1;

            // Add Tabs
            tabControl1.TabPages.Add("Daily", "Daily");
            tabControl1.TabPages.Add("Weekly", "Weekly");
            tabControl1.TabPages.Add("Monthly", "Monthly");

            // Tab selection event (we'll handle this in code)
            tabControl1.SelectedIndexChanged += new System.EventHandler(tabControl1_SelectedIndexChanged);

            // =============================================
            // Scheduler Control Setup
            // =============================================
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 30);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(2224, 1109);
            schedulerControl1.Start = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            schedulerControl1.TabIndex = 0;

            // Enable Views
            schedulerControl1.Views.DayView.Enabled = true;
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);

            schedulerControl1.Views.WeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);

            schedulerControl1.Views.MonthView.Enabled = true;

            schedulerControl1.Views.WorkWeekView.Enabled = true;
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);

            schedulerControl1.Views.YearView.Enabled = false;

            // Default View
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;

            // Data Storage
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            schedulerDataStorage1.Appointments.Labels.Clear();   // Empty labels

            // =============================================
            // Layout
            // =============================================
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(schedulerControl1);
            Controls.Add(tabControl1);
            Name = "MySchedule";
            Size = new System.Drawing.Size(2224, 1139);

            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private System.Windows.Forms.TabControl tabControl1;

        // ====================== TAB SWITCHING LOGIC ======================
        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedTab == null) return;

            switch (tabControl1.SelectedTab.Text)
            {
                case "Daily":
                    schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
                    break;

                case "Weekly":
                    schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Week;
                    break;

                case "Monthly":
                    schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
                    break;
            }
        }
    }
}