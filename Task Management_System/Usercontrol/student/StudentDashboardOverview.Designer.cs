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
            cardTodayClasses.Controls.Add(this.lblTodayTitle);
            cardTodayClasses.Controls.Add(this.lblTodayCount);
            cardTodayClasses.Location = new System.Drawing.Point(50, 150);
            cardTodayClasses.Name = "cardTodayClasses";
            cardTodayClasses.Size = new System.Drawing.Size(420, 180);
            cardTodayClasses.TabIndex = 1;
            cardTodayClasses.Text = "Today's Classes";
            // 
            // cardPendingTasks
            // 
            cardPendingTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cardPendingTasks.Controls.Add(this.lblPendingTitle);
            cardPendingTasks.Controls.Add(this.lblPendingCount);
            cardPendingTasks.Location = new System.Drawing.Point(620, 150);
            cardPendingTasks.Name = "cardPendingTasks";
            cardPendingTasks.Size = new System.Drawing.Size(420, 180);
            cardPendingTasks.TabIndex = 2;
            cardPendingTasks.Text = "Pending Tasks";
            // 
            // cardUpcomingEvents
            // 
            cardUpcomingEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cardUpcomingEvents.Controls.Add(this.lblUpcomingTitle);
            cardUpcomingEvents.Controls.Add(this.lblUpcomingCount);
            cardUpcomingEvents.Location = new System.Drawing.Point(1200, 150);
            cardUpcomingEvents.Name = "cardUpcomingEvents";
            cardUpcomingEvents.Size = new System.Drawing.Size(420, 180);
            cardUpcomingEvents.TabIndex = 3;
            cardUpcomingEvents.Text = "Upcoming Events";
            // 
            // schedulerMini
            // 
            schedulerMini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            schedulerMini.DataStorage = schedulerDataStorage1;
            schedulerMini.Location = new System.Drawing.Point(50, 370);
            schedulerMini.Name = "schedulerMini";
            schedulerMini.Size = new System.Drawing.Size(1570, 750);
            schedulerMini.TabIndex = 4;

            // ====================================================================
            // 📅 FORCED FULL MONTH DISPLAY VIEW ENGINE CONFIGURATION
            // ====================================================================
            schedulerMini.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;

            // Lock out all layout alternatives to prevent user context distortion
            schedulerMini.Views.MonthView.Enabled = true;
            schedulerMini.Views.DayView.Enabled = false;
            schedulerMini.Views.WeekView.Enabled = false;
            schedulerMini.Views.WorkWeekView.Enabled = false;
            schedulerMini.Views.TimelineView.Enabled = false;
            schedulerMini.Views.AgendaView.Enabled = false;

            // Optimize visual parameters inside dashboard overview grid boundary blocks
            schedulerMini.Views.MonthView.WeekCount = 5;
            schedulerMini.Views.MonthView.AppointmentDisplayOptions.StatusDisplayType = DevExpress.XtraScheduler.AppointmentStatusDisplayType.Bounds;
            // ====================================================================

            // 
            // StudentDashboardOverview
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(schedulerMini);
            Controls.Add(cardUpcomingEvents);
            Controls.Add(cardPendingTasks);
            Controls.Add(cardTodayClasses);
            Controls.Add(lblWelcome);
            Name = "StudentDashboardOverview";
            Size = new System.Drawing.Size(1670, 1170);
            ((System.ComponentModel.ISupportInitialize)cardTodayClasses).EndInit();
            cardTodayClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardPendingTasks).EndInit();
            cardPendingTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardUpcomingEvents).EndInit();
            cardUpcomingEvents.ResumeLayout(false);
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