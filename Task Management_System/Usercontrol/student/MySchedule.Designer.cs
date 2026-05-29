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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPageMonthly = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPageDaily = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPageWeekly = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // schedulerControl1
            // 
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 45);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(2224, 1094);
            schedulerControl1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            schedulerControl1.TabIndex = 0;
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            schedulerControl1.Views.YearView.Enabled = false;
            schedulerControl1.Views.YearView.UseOptimizedScrolling = false;

            // 🔒 SECURITY PROTECTION: Disables all forms of appointment creation, modification, and context menu actions
            schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;

            // ✨ HTML INTERPRETATION: Safely enables HTML tag rendering across all your active layout structures
            schedulerControl1.Views.DayView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl1.Views.WorkWeekView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl1.Views.FullWeekView.AppointmentDisplayOptions.AllowHtmlText = true;
            schedulerControl1.Views.MonthView.AppointmentDisplayOptions.AllowHtmlText = true;
            // 
            // schedulerDataStorage1
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // Labels Configuration
            // 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPageMonthly;
            xtraTabControl1.Size = new System.Drawing.Size(2224, 45);
            xtraTabControl1.TabIndex = 1;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPageDaily, xtraTabPageWeekly, xtraTabPageMonthly });
            // 
            // xtraTabPageMonthly
            // 
            xtraTabPageMonthly.Name = "xtraTabPageMonthly";
            xtraTabPageMonthly.Size = new System.Drawing.Size(2220, 0);
            xtraTabPageMonthly.Text = "Monthly";
            // 
            // xtraTabPageDaily
            // 
            xtraTabPageDaily.Name = "xtraTabPageDaily";
            xtraTabPageDaily.Size = new System.Drawing.Size(2220, 0);
            xtraTabPageDaily.Text = "Daily";
            // 
            // xtraTabPageWeekly
            // 
            xtraTabPageWeekly.Name = "xtraTabPageWeekly";
            xtraTabPageWeekly.Size = new System.Drawing.Size(2220, 0);
            xtraTabPageWeekly.Text = "Weekly";
            // 
            // MySchedule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(schedulerControl1);
            Controls.Add(xtraTabControl1);
            Name = "MySchedule";
            Size = new System.Drawing.Size(2224, 1139);
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDaily;
        private DevExpress.XtraTab.XtraTabPage weekly; // changed to match container scope mapping if required
        private DevExpress.XtraTab.XtraTabPage xtraTabPageWeekly;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonthly;
    }
}