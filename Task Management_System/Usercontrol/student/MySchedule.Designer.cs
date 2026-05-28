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
            xtraTabPageDaily = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPageWeekly = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPageMonthly = new DevExpress.XtraTab.XtraTabPage();
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
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
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
            // xtraTabPageMonthly
            // 
            xtraTabPageMonthly.Name = "xtraTabPageMonthly";
            xtraTabPageMonthly.Size = new System.Drawing.Size(2220, 0);
            xtraTabPageMonthly.Text = "Monthly";
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
        private DevExpress.XtraTab.XtraTabPage xtraTabPageWeekly;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMonthly;
    }
}