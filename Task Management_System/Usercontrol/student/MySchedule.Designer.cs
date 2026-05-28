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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageDaily = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageWeekly = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageMonthly = new DevExpress.XtraTab.XtraTabPage();

            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();

            // ====================================================================
            // xtraTabControl1 (Pure DevExpress Tab Element Layer)
            // ====================================================================
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageMonthly;
            this.xtraTabControl1.Size = new System.Drawing.Size(2224, 45);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageDaily,
            this.xtraTabPageWeekly,
            this.xtraTabPageMonthly});

            // xtraTabPageDaily
            this.xtraTabPageDaily.Name = "xtraTabPageDaily";
            this.xtraTabPageDaily.Size = new System.Drawing.Size(2220, 0);
            this.xtraTabPageDaily.Text = "Daily";

            // xtraTabPageWeekly
            this.xtraTabPageWeekly.Name = "xtraTabPageWeekly";
            this.xtraTabPageWeekly.Size = new System.Drawing.Size(2220, 0);
            this.xtraTabPageWeekly.Text = "Weekly";

            // xtraTabPageMonthly
            this.xtraTabPageMonthly.Name = "xtraTabPageMonthly";
            this.xtraTabPageMonthly.Size = new System.Drawing.Size(2220, 0);
            this.xtraTabPageMonthly.Text = "Monthly";

            // ====================================================================
            // schedulerControl1 (Pure DevExpress Scheduler View Canvas)
            // ====================================================================
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 45);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(2224, 1094);
            this.schedulerControl1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;

            // View and layout rulers configurations
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.Views.YearView.Enabled = false;
            this.schedulerControl1.Views.YearView.UseOptimizedScrolling = false;

            // ====================================================================
            // schedulerDataStorage1 Data Mapping Engine
            // ====================================================================
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;

            // ====================================================================
            // MySchedule Custom Container Composition Setup
            // ====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "MySchedule";
            this.Size = new System.Drawing.Size(2224, 1139);

            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageDaily;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageWeekly;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonthly;
    }
}