namespace Task_Management_System.Usercontrol.student
{
    partial class MyClassSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();

            splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            sideDateNavigator = new DevExpress.XtraScheduler.DateNavigator(); // 👈 Fixed: Swapped to native DateNavigator
            classSchedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
            classSchedulerDataStorage = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            toolTipController1 = new DevExpress.Utils.ToolTipController(components);

            ((System.ComponentModel.ISupportInitialize)splitContainerControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl.Panel1).BeginInit();
            splitContainerControl.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl.Panel2).BeginInit();
            splitContainerControl.Panel2.SuspendLayout();
            splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sideDateNavigator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classSchedulerControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classSchedulerDataStorage).BeginInit();
            SuspendLayout();
            // 
            // splitContainerControl
            // 
            splitContainerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl.Location = new System.Drawing.Point(0, 0);
            splitContainerControl.Name = "splitContainerControl";
            // 
            // splitContainerControl.Panel1
            // 
            splitContainerControl.Panel1.Controls.Add(sideDateNavigator);
            splitContainerControl.Panel1.Text = "ControlPanel";
            // 
            // splitContainerControl.Panel2
            // 
            splitContainerControl.Panel2.Controls.Add(classSchedulerControl);
            splitContainerControl.Panel2.Text = "SchedulerPanel";
            splitContainerControl.Size = new System.Drawing.Size(1200, 750);
            splitContainerControl.SplitterPosition = 280;
            splitContainerControl.TabIndex = 0;
            // 
            // sideDateNavigator
            // 
            sideDateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            sideDateNavigator.Location = new System.Drawing.Point(0, 0);
            sideDateNavigator.Name = "sideDateNavigator";
            sideDateNavigator.SchedulerControl = classSchedulerControl; // 👈 Native cross-control link supported by assembly
            sideDateNavigator.Size = new System.Drawing.Size(280, 750);
            sideDateNavigator.TabIndex = 0;
            // 
            // classSchedulerControl
            // 
            classSchedulerControl.DataStorage = classSchedulerDataStorage;
            classSchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            classSchedulerControl.Location = new System.Drawing.Point(0, 0);
            classSchedulerControl.Name = "classSchedulerControl";

            // Strictly View-Only protection layout mechanics
            classSchedulerControl.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
            classSchedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
            classSchedulerControl.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            classSchedulerControl.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.None;
            classSchedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;

            classSchedulerControl.Size = new System.Drawing.Size(915, 750);
            classSchedulerControl.Start = new System.DateTime(2026, 5, 29, 0, 0, 0, 0);
            classSchedulerControl.TabIndex = 0;
            classSchedulerControl.Text = "classSchedulerControl";

            // ⌚ Fixed Time Rulers compatibility by dropping missing property references entirely
            classSchedulerControl.Views.DayView.TimeRulers.Add(timeRuler1);
            classSchedulerControl.Views.DayView.WorkTime = new DevExpress.XtraScheduler.WorkTimeInterval(System.TimeSpan.Parse("08:00:00"), System.TimeSpan.Parse("17:00:00"));
            classSchedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            classSchedulerControl.Views.FullWeekView.Enabled = true;
            // 
            // classSchedulerDataStorage
            // 
            classSchedulerDataStorage.Appointments.Labels.Clear();
            classSchedulerDataStorage.Appointments.Labels.Add(System.Drawing.Color.LightCoral, "Academic Class", "Class Schedule");
            // 
            // MyClassSchedule
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainerControl);
            Name = "MyClassSchedule";
            Size = new System.Drawing.Size(1200, 750);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl.Panel1).EndInit();
            splitContainerControl.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl.Panel2).EndInit();
            splitContainerControl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl).EndInit();
            splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sideDateNavigator).EndInit();
            ((System.ComponentModel.ISupportInitialize)classSchedulerControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)classSchedulerDataStorage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraScheduler.DateNavigator sideDateNavigator; // 👈 Updated instance reference type
        private DevExpress.XtraScheduler.SchedulerControl classSchedulerControl;
        private DevExpress.XtraScheduler.SchedulerDataStorage classSchedulerDataStorage;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}