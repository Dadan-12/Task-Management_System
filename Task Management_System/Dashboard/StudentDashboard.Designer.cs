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
            accordionControlElementSchedule = new AccordionControlElement();
            accordionControlElementTasks = new AccordionControlElement();
            accordionControlElementProfile = new AccordionControlElement();
            accordionControlElementLogout = new AccordionControlElement(); // Added for navigation integration
            mainContentContainer = new DevExpress.XtraEditors.PanelControl();

            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainContentContainer).BeginInit();
            mainContentContainer.SuspendLayout();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            // Included the new logout item at the bottom of the list array collection
            accordionControl1.Elements.AddRange(new AccordionControlElement[] {
                accordionControlElementDashboard,
                accordionControlElementSchedule,
                accordionControlElementTasks,
                accordionControlElementProfile,
                accordionControlElementLogout
            });
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
            accordionControlElementTasks.Text = "Task Scheduler";
            // 
            // accordionControlElementProfile
            // 
            accordionControlElementProfile.Name = "accordionControlElementProfile";
            accordionControlElementProfile.Style = ElementStyle.Item;
            accordionControlElementProfile.Text = "Profile";
            // 
            // accordionControlElementLogout
            // 
            accordionControlElementLogout.Name = "accordionControlElementLogout";
            accordionControlElementLogout.Style = ElementStyle.Item;
            accordionControlElementLogout.Text = "Logout";
            // 
            // mainContentContainer
            // 
            mainContentContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            mainContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            mainContentContainer.Location = new System.Drawing.Point(390, 0);
            mainContentContainer.Margin = new System.Windows.Forms.Padding(4);
            mainContentContainer.Name = "mainContentContainer";
            mainContentContainer.Size = new System.Drawing.Size(1725, 1268);
            mainContentContainer.TabIndex = 26;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2115, 1268);
            Controls.Add(mainContentContainer);
            Controls.Add(accordionControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Student Workspace Dashboard";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainContentContainer).EndInit();
            mainContentContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSchedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementTasks;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementProfile;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementLogout; // Declared field
        private DevExpress.XtraEditors.PanelControl mainContentContainer;
    }
}