using DevExpress.XtraBars.Navigation;

namespace Task_Management_System.Dashboard
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            accordionControl1 = new AccordionControl();
            accordionControlElementDashboard = new AccordionControlElement();
            accordionControlElementSubjects = new AccordionControlElement();
            accordionControlElementSchedule = new AccordionControlElement();
            accordionControlElementTasks = new AccordionControlElement();
            accordionControlElementProfile = new AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new AccordionControlElement[] { accordionControlElementDashboard, accordionControlElementSubjects, accordionControlElementSchedule, accordionControlElementTasks, accordionControlElementProfile });
            accordionControl1.Location = new System.Drawing.Point(0, 0);
            accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new System.Drawing.Size(390, 1268);
            accordionControl1.TabIndex = 25;
            accordionControl1.ViewType = AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementDashboard
            // 
            accordionControlElementDashboard.Name = "accordionControlElementDashboard";
            accordionControlElementDashboard.Style = ElementStyle.Item;
            accordionControlElementDashboard.Text = "Dashboard";
            // 
            // accordionControlElementSubjects
            // 
            accordionControlElementSubjects.Name = "accordionControlElementSubjects";
            accordionControlElementSubjects.Style = ElementStyle.Item;
            accordionControlElementSubjects.Text = "My Subjects";
            // 
            // accordionControlElementSchedule
            // 
            accordionControlElementSchedule.Name = "accordionControlElementSchedule";
            accordionControlElementSchedule.Style = ElementStyle.Item;
            accordionControlElementSchedule.Text = "My Schedule";
            // 
            // accordionControlElementTasks
            // 
            accordionControlElementTasks.Name = "accordionControlElementTasks";
            accordionControlElementTasks.Style = ElementStyle.Item;
            accordionControlElementTasks.Text = "My Tasks";
            // 
            // accordionControlElementProfile
            // 
            accordionControlElementProfile.Name = "accordionControlElementProfile";
            accordionControlElementProfile.Style = ElementStyle.Item;
            accordionControlElementProfile.Text = "Profile";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2115, 1268);
            Controls.Add(accordionControl1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSubjects;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSchedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTasks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProfile;
    }
}
