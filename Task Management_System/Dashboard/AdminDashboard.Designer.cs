namespace Task_Management_System.Dashboards
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            accordionSideBar = new DevExpress.XtraBars.Navigation.AccordionControl();
            acDashaboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acRegister = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            acReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            panelDashboard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)accordionSideBar).BeginInit();
            SuspendLayout();
            // 
            // accordionSideBar
            // 
            accordionSideBar.Appearance.AccordionControl.BackColor = System.Drawing.Color.DarkSlateGray;
            accordionSideBar.Appearance.AccordionControl.Options.UseBackColor = true;
            accordionSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            accordionSideBar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { acDashaboard, acRegister, acReport });
            accordionSideBar.Location = new System.Drawing.Point(0, 0);
            accordionSideBar.Name = "accordionSideBar";
            accordionSideBar.Size = new System.Drawing.Size(141, 562);
            accordionSideBar.TabIndex = 1;
            accordionSideBar.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acDashaboard
            // 
            acDashaboard.Appearance.Default.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            acDashaboard.Appearance.Default.Options.UseFont = true;
            acDashaboard.Expanded = true;
            acDashaboard.Name = "acDashaboard";
            acDashaboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acDashaboard.Text = "Dashboard";
            acDashaboard.Click += acDashboard_Click;
            // 
            // acRegister
            // 
            acRegister.Appearance.Default.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            acRegister.Appearance.Default.Options.UseFont = true;
            acRegister.Name = "acRegister";
            acRegister.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acRegister.Text = "Register";
            acRegister.Click += acRegister_Click;
            // 
            // acReport
            // 
            acReport.Appearance.Default.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            acReport.Appearance.Default.Options.UseFont = true;
            acReport.Name = "acReport";
            acReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            acReport.Text = "Report";
            acReport.Click += acReport_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            panelDashboard.Location = new System.Drawing.Point(141, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new System.Drawing.Size(754, 562);
            panelDashboard.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(895, 562);
            Controls.Add(panelDashboard);
            Controls.Add(accordionSideBar);
            Name = "AdminDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)accordionSideBar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionSideBar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDashaboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acRegister;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acReport;
        private System.Windows.Forms.Panel panelDashboard;
        private DevExpress.XtraEditors.SearchControl SControl;
    }
}