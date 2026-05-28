namespace Task_Management_System.Usercontrol.student
{
    partial class StudentDashboardOverview
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
            lblWelcome = new DevExpress.XtraEditors.LabelControl();
            cardTodayClasses = new DevExpress.XtraEditors.GroupControl();
            lblTodayTitle = new DevExpress.XtraEditors.LabelControl();
            lblTodayCount = new DevExpress.XtraEditors.LabelControl();
            cardPendingTasks = new DevExpress.XtraEditors.GroupControl();
            lblPendingTitle = new DevExpress.XtraEditors.LabelControl();
            lblPendingCount = new DevExpress.XtraEditors.LabelControl();
            cardUpcomingEvents = new DevExpress.XtraEditors.GroupControl();
            lblUpcomingTitle = new DevExpress.XtraEditors.LabelControl();
            lblUpcomingCount = new DevExpress.XtraEditors.LabelControl();
            schedulerMini = new DevExpress.XtraScheduler.SchedulerControl();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            ((System.ComponentModel.ISupportInitialize)cardTodayClasses).BeginInit();
            cardTodayClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardPendingTasks).BeginInit();
            cardPendingTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardUpcomingEvents).BeginInit();
            cardUpcomingEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedulerMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Appearance.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblWelcome.Appearance.Options.UseFont = true;
            lblWelcome.Location = new System.Drawing.Point(50, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(679, 78);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Good Morning, Student!";
            // 
            // cardTodayClasses
            // 
            cardTodayClasses.Appearance.BackColor = System.Drawing.Color.FromArgb(230, 244, 255);
            cardTodayClasses.Appearance.Options.UseBackColor = true;
            cardTodayClasses.Controls.Add(lblTodayTitle);
            cardTodayClasses.Controls.Add(lblTodayCount);
            cardTodayClasses.Location = new System.Drawing.Point(50, 120);
            cardTodayClasses.Name = "cardTodayClasses";
            cardTodayClasses.Size = new System.Drawing.Size(280, 180);
            cardTodayClasses.TabIndex = 1;
            // 
            // lblTodayTitle
            // 
            lblTodayTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            lblTodayTitle.Appearance.Options.UseFont = true;
            lblTodayTitle.Location = new System.Drawing.Point(25, 25);
            lblTodayTitle.Name = "lblTodayTitle";
            lblTodayTitle.Size = new System.Drawing.Size(189, 42);
            lblTodayTitle.TabIndex = 0;
            lblTodayTitle.Text = "Classes Today";
            // 
            // lblTodayCount
            // 
            lblTodayCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblTodayCount.Appearance.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            lblTodayCount.Appearance.Options.UseFont = true;
            lblTodayCount.Appearance.Options.UseForeColor = true;
            lblTodayCount.Location = new System.Drawing.Point(25, 70);
            lblTodayCount.Name = "lblTodayCount";
            lblTodayCount.Size = new System.Drawing.Size(55, 128);
            lblTodayCount.TabIndex = 1;
            lblTodayCount.Text = "0";
            // 
            // cardPendingTasks
            // 
            cardPendingTasks.Controls.Add(lblPendingTitle);
            cardPendingTasks.Controls.Add(lblPendingCount);
            cardPendingTasks.Location = new System.Drawing.Point(526, 120);
            cardPendingTasks.Name = "cardPendingTasks";
            cardPendingTasks.Size = new System.Drawing.Size(280, 180);
            cardPendingTasks.TabIndex = 2;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            lblPendingTitle.Appearance.Options.UseFont = true;
            lblPendingTitle.Location = new System.Drawing.Point(25, 25);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new System.Drawing.Size(194, 42);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "Pending Tasks";
            // 
            // lblPendingCount
            // 
            lblPendingCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblPendingCount.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            lblPendingCount.Appearance.Options.UseFont = true;
            lblPendingCount.Appearance.Options.UseForeColor = true;
            lblPendingCount.Location = new System.Drawing.Point(25, 70);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new System.Drawing.Size(55, 128);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            // 
            // cardUpcomingEvents
            // 
            cardUpcomingEvents.Controls.Add(lblUpcomingTitle);
            cardUpcomingEvents.Controls.Add(lblUpcomingCount);
            cardUpcomingEvents.Location = new System.Drawing.Point(910, 120);
            cardUpcomingEvents.Name = "cardUpcomingEvents";
            cardUpcomingEvents.Size = new System.Drawing.Size(280, 180);
            cardUpcomingEvents.TabIndex = 3;
            // 
            // lblUpcomingTitle
            // 
            lblUpcomingTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            lblUpcomingTitle.Appearance.Options.UseFont = true;
            lblUpcomingTitle.Location = new System.Drawing.Point(25, 25);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new System.Drawing.Size(239, 42);
            lblUpcomingTitle.TabIndex = 0;
            lblUpcomingTitle.Text = "Upcoming Events";
            // 
            // lblUpcomingCount
            // 
            lblUpcomingCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            lblUpcomingCount.Appearance.ForeColor = System.Drawing.Color.Green;
            lblUpcomingCount.Appearance.Options.UseFont = true;
            lblUpcomingCount.Appearance.Options.UseForeColor = true;
            lblUpcomingCount.Location = new System.Drawing.Point(25, 70);
            lblUpcomingCount.Name = "lblUpcomingCount";
            lblUpcomingCount.Size = new System.Drawing.Size(55, 128);
            lblUpcomingCount.TabIndex = 1;
            lblUpcomingCount.Text = "0";
            // 
            // schedulerMini
            // 
            schedulerMini.DataStorage = schedulerDataStorage1;
            schedulerMini.Location = new System.Drawing.Point(50, 330);
            schedulerMini.Name = "schedulerMini";
            schedulerMini.Size = new System.Drawing.Size(2192, 988);
            schedulerMini.Start = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            schedulerMini.TabIndex = 4;
            schedulerMini.Views.MonthView.Enabled = false;
            schedulerMini.Views.WeekView.Enabled = false;
            schedulerMini.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
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
            // StudentDashboardOverview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblWelcome);
            Controls.Add(cardTodayClasses);
            Controls.Add(cardPendingTasks);
            Controls.Add(cardUpcomingEvents);
            Controls.Add(schedulerMini);
            Name = "StudentDashboardOverview";
            Size = new System.Drawing.Size(2245, 1318);
            ((System.ComponentModel.ISupportInitialize)cardTodayClasses).EndInit();
            cardTodayClasses.ResumeLayout(false);
            cardTodayClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardPendingTasks).EndInit();
            cardPendingTasks.ResumeLayout(false);
            cardPendingTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardUpcomingEvents).EndInit();
            cardUpcomingEvents.ResumeLayout(false);
            cardUpcomingEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schedulerMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.GroupControl cardTodayClasses;
        private DevExpress.XtraEditors.GroupControl cardPendingTasks;
        private DevExpress.XtraEditors.GroupControl cardUpcomingEvents;

        private DevExpress.XtraEditors.LabelControl lblTodayTitle;
        private DevExpress.XtraEditors.LabelControl lblTodayCount;
        private DevExpress.XtraEditors.LabelControl lblPendingTitle;
        private DevExpress.XtraEditors.LabelControl lblPendingCount;
        private DevExpress.XtraEditors.LabelControl lblUpcomingTitle;
        private DevExpress.XtraEditors.LabelControl lblUpcomingCount;

        private DevExpress.XtraScheduler.SchedulerControl schedulerMini;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
    }
}