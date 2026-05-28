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
            panelControlTopActions = new DevExpress.XtraEditors.PanelControl();
            radioGroupViewSwitcher = new DevExpress.XtraEditors.RadioGroup();
            btnAddNewTask = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControlTopActions).BeginInit();
            panelControlTopActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radioGroupViewSwitcher.Properties).BeginInit();
            SuspendLayout();
            // 
            // schedulerControl1
            // 
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 60);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(1693, 1096);
            schedulerControl1.Start = System.DateTime.Today;
            schedulerControl1.TabIndex = 1;
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            schedulerControl1.Views.YearView.Enabled = false;
            schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // schedulerDataStorage1
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // panelControlTopActions
            // 
            panelControlTopActions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControlTopActions.Controls.Add(radioGroupViewSwitcher);
            panelControlTopActions.Controls.Add(btnAddNewTask);
            panelControlTopActions.Dock = System.Windows.Forms.DockStyle.Top;
            panelControlTopActions.Location = new System.Drawing.Point(0, 0);
            panelControlTopActions.Name = "panelControlTopActions";
            panelControlTopActions.Padding = new System.Windows.Forms.Padding(10);
            panelControlTopActions.Size = new System.Drawing.Size(1693, 60);
            panelControlTopActions.TabIndex = 0;
            // 
            // radioGroupViewSwitcher
            // 
            radioGroupViewSwitcher.Dock = System.Windows.Forms.DockStyle.Right;
            radioGroupViewSwitcher.EditValue = "Monthly";
            radioGroupViewSwitcher.Location = new System.Drawing.Point(1086, 10);
            radioGroupViewSwitcher.Name = "radioGroupViewSwitcher";
            radioGroupViewSwitcher.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            radioGroupViewSwitcher.Properties.Appearance.Options.UseFont = true;
            radioGroupViewSwitcher.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            radioGroupViewSwitcher.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] { new DevExpress.XtraEditors.Controls.RadioGroupItem("Daily", "Day View"), new DevExpress.XtraEditors.Controls.RadioGroupItem("Weekly", "Week View"), new DevExpress.XtraEditors.Controls.RadioGroupItem("Monthly", "Month View") });
            radioGroupViewSwitcher.Size = new System.Drawing.Size(597, 40);
            radioGroupViewSwitcher.TabIndex = 1;
            // 
            // btnAddNewTask
            // 
            btnAddNewTask.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAddNewTask.Appearance.Options.UseFont = true;
            btnAddNewTask.Dock = System.Windows.Forms.DockStyle.Left;
            btnAddNewTask.Location = new System.Drawing.Point(10, 10);
            btnAddNewTask.Name = "btnAddNewTask";
            btnAddNewTask.Size = new System.Drawing.Size(393, 40);
            btnAddNewTask.TabIndex = 0;
            btnAddNewTask.Text = "➕  Add New Task Allocation";
            // 
            // TaskScheduler
            // 
            // Fixed base canvas layout configuration metrics safely
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(schedulerControl1);
            Controls.Add(panelControlTopActions);
            Name = "TaskScheduler";
            Size = new System.Drawing.Size(1693, 1156);
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControlTopActions).EndInit();
            panelControlTopActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radioGroupViewSwitcher.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraEditors.PanelControl panelControlTopActions;
        private DevExpress.XtraEditors.SimpleButton btnAddNewTask;
        private DevExpress.XtraEditors.RadioGroup radioGroupViewSwitcher;
    }
}