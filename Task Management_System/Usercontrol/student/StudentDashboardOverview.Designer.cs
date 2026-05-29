using DevExpress.XtraScheduler;

namespace Task_Management_System.Usercontrol.student
{
    partial class StudentDashboardOverview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                schedulerDataStorage1?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWelcome = new DevExpress.XtraEditors.LabelControl();
            pnlCardsContainer = new DevExpress.XtraEditors.PanelControl();
            cardTodayClasses = new DevExpress.XtraEditors.GroupControl();
            lblTodayTitle = new DevExpress.XtraEditors.LabelControl();
            lblTodayCount = new DevExpress.XtraEditors.LabelControl();
            cardPendingTasks = new DevExpress.XtraEditors.GroupControl();
            lblPendingTitle = new DevExpress.XtraEditors.LabelControl();
            lblPendingCount = new DevExpress.XtraEditors.LabelControl();
            cardUpcomingEvents = new DevExpress.XtraEditors.GroupControl();
            lblUpcomingTitle = new DevExpress.XtraEditors.LabelControl();
            lblUpcomingCount = new DevExpress.XtraEditors.LabelControl();
            schedulerMini = new SchedulerControl();
            schedulerDataStorage1 = new SchedulerDataStorage(components);
            ((System.ComponentModel.ISupportInitialize)pnlCardsContainer).BeginInit();
            pnlCardsContainer.SuspendLayout();
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
            // pnlCardsContainer
            // 
            pnlCardsContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnlCardsContainer.Controls.Add(cardTodayClasses);
            pnlCardsContainer.Controls.Add(cardPendingTasks);
            pnlCardsContainer.Controls.Add(cardUpcomingEvents);
            pnlCardsContainer.Location = new System.Drawing.Point(50, 140);
            pnlCardsContainer.Name = "pnlCardsContainer";
            pnlCardsContainer.Size = new System.Drawing.Size(1570, 200);
            pnlCardsContainer.TabIndex = 1;
            // 
            // cardTodayClasses
            // 
            cardTodayClasses.Controls.Add(lblTodayTitle);
            cardTodayClasses.Controls.Add(lblTodayCount);
            cardTodayClasses.Dock = System.Windows.Forms.DockStyle.Left;
            cardTodayClasses.Location = new System.Drawing.Point(840, 0);
            cardTodayClasses.Name = "cardTodayClasses";
            cardTodayClasses.Size = new System.Drawing.Size(420, 200);
            cardTodayClasses.TabIndex = 0;
            cardTodayClasses.Text = "Today's Classes";
            // 
            // lblTodayTitle
            // 
            lblTodayTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTodayTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblTodayTitle.Appearance.Options.UseFont = true;
            lblTodayTitle.Appearance.Options.UseForeColor = true;
            lblTodayTitle.Location = new System.Drawing.Point(20, 45);
            lblTodayTitle.Name = "lblTodayTitle";
            lblTodayTitle.Size = new System.Drawing.Size(227, 37);
            lblTodayTitle.TabIndex = 0;
            lblTodayTitle.Text = "Scheduled Lectures";
            // 
            // lblTodayCount
            // 
            lblTodayCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblTodayCount.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            lblTodayCount.Appearance.Options.UseFont = true;
            lblTodayCount.Appearance.Options.UseForeColor = true;
            lblTodayCount.Location = new System.Drawing.Point(20, 75);
            lblTodayCount.Name = "lblTodayCount";
            lblTodayCount.Size = new System.Drawing.Size(43, 100);
            lblTodayCount.TabIndex = 1;
            lblTodayCount.Text = "0";
            // 
            // cardPendingTasks
            // 
            cardPendingTasks.Controls.Add(lblPendingTitle);
            cardPendingTasks.Controls.Add(lblPendingCount);
            cardPendingTasks.Dock = System.Windows.Forms.DockStyle.Left;
            cardPendingTasks.Location = new System.Drawing.Point(420, 0);
            cardPendingTasks.Name = "cardPendingTasks";
            cardPendingTasks.Size = new System.Drawing.Size(420, 200);
            cardPendingTasks.TabIndex = 1;
            cardPendingTasks.Text = "Pending Tasks";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblPendingTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblPendingTitle.Appearance.Options.UseFont = true;
            lblPendingTitle.Appearance.Options.UseForeColor = true;
            lblPendingTitle.Location = new System.Drawing.Point(20, 45);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new System.Drawing.Size(204, 37);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "Assignments Due";
            // 
            // lblPendingCount
            // 
            lblPendingCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblPendingCount.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            lblPendingCount.Appearance.Options.UseFont = true;
            lblPendingCount.Appearance.Options.UseForeColor = true;
            lblPendingCount.Location = new System.Drawing.Point(20, 75);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new System.Drawing.Size(43, 100);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            // 
            // cardUpcomingEvents
            // 
            cardUpcomingEvents.Controls.Add(lblUpcomingTitle);
            cardUpcomingEvents.Controls.Add(lblUpcomingCount);
            cardUpcomingEvents.Dock = System.Windows.Forms.DockStyle.Left;
            cardUpcomingEvents.Location = new System.Drawing.Point(0, 0);
            cardUpcomingEvents.Name = "cardUpcomingEvents";
            cardUpcomingEvents.Size = new System.Drawing.Size(420, 200);
            cardUpcomingEvents.TabIndex = 2;
            cardUpcomingEvents.Text = "Upcoming Events";
            // 
            // lblUpcomingTitle
            // 
            lblUpcomingTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblUpcomingTitle.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblUpcomingTitle.Appearance.Options.UseFont = true;
            lblUpcomingTitle.Appearance.Options.UseForeColor = true;
            lblUpcomingTitle.Location = new System.Drawing.Point(20, 45);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new System.Drawing.Size(141, 37);
            lblUpcomingTitle.TabIndex = 0;
            lblUpcomingTitle.Text = "Next 7 Days";
            // 
            // lblUpcomingCount
            // 
            lblUpcomingCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblUpcomingCount.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            lblUpcomingCount.Appearance.Options.UseFont = true;
            lblUpcomingCount.Appearance.Options.UseForeColor = true;
            lblUpcomingCount.Location = new System.Drawing.Point(20, 75);
            lblUpcomingCount.Name = "lblUpcomingCount";
            lblUpcomingCount.Size = new System.Drawing.Size(43, 100);
            lblUpcomingCount.TabIndex = 1;
            lblUpcomingCount.Text = "0";
            // 
            // schedulerMini
            // 
            schedulerMini.ActiveViewType = SchedulerViewType.Month;
            schedulerMini.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            schedulerMini.DataStorage = schedulerDataStorage1;
            schedulerMini.Location = new System.Drawing.Point(50, 370);
            schedulerMini.Name = "schedulerMini";
            schedulerMini.Size = new System.Drawing.Size(1570, 750);
            schedulerMini.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            schedulerMini.TabIndex = 5;

            // 🔒 READ-ONLY SCHEDULER IMPLEMENTATION
            schedulerMini.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentDragBetweenResources = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowAppointmentCopy = UsedAppointmentType.None;
            schedulerMini.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None;

            schedulerMini.Views.AgendaView.Enabled = false;
            schedulerMini.Views.DayView.Enabled = false;
            schedulerMini.Views.TimelineView.Enabled = false;
            schedulerMini.Views.WeekView.Enabled = false;
            schedulerMini.Views.WorkWeekView.Enabled = false;
            schedulerMini.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
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
            Controls.Add(schedulerMini);
            Controls.Add(pnlCardsContainer);
            Controls.Add(lblWelcome);
            Name = "StudentDashboardOverview";
            Size = new System.Drawing.Size(1670, 1170);
            ((System.ComponentModel.ISupportInitialize)pnlCardsContainer).EndInit();
            pnlCardsContainer.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PanelControl pnlCardsContainer;
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