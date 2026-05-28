namespace Task_Management_System.Dashboard
{
    partial class LoginDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Pure DevExpress UI Architecture Components
        private DevExpress.XtraLayout.LayoutControl layoutControlMaster;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupRoot;

        private DevExpress.XtraEditors.PanelControl panelControlLeftBranding;
        private DevExpress.XtraEditors.PanelControl panelControlRightLogin;

        // Left Side Branding Controls (picLogo removed)
        private DevExpress.XtraEditors.LabelControl lblBrandTitle;
        private DevExpress.XtraEditors.LabelControl lblBrandSubtitle;

        // Right Side Login Controls
        private DevExpress.XtraEditors.LabelControl lblLoginHeader;
        private DevExpress.XtraEditors.LabelControl lblLoginSubheader;
        private DevExpress.XtraEditors.LabelControl lblUsernameHeader;
        private DevExpress.XtraEditors.TextEdit txtStudentId;
        private DevExpress.XtraEditors.LabelControl lblPasswordHeader;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkShowPassword; // Added for Show Password functionality
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancel; // 🔴 ADDED: Cancel button field declaration

        // Layout Items Mapping Layouts
        private DevExpress.XtraLayout.LayoutControlItem layoutItemBranding;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemLoginEngine;

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

        private void InitializeComponent()
        {
            layoutControlMaster = new DevExpress.XtraLayout.LayoutControl();
            panelControlLeftBranding = new DevExpress.XtraEditors.PanelControl();
            lblBrandSubtitle = new DevExpress.XtraEditors.LabelControl();
            lblBrandTitle = new DevExpress.XtraEditors.LabelControl();
            panelControlRightLogin = new DevExpress.XtraEditors.PanelControl();
            chkShowPassword = new DevExpress.XtraEditors.CheckEdit();
            lblPasswordHeader = new DevExpress.XtraEditors.LabelControl();
            lblUsernameHeader = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton(); // 🔴 ADDED: Cancel button initialization
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            txtStudentId = new DevExpress.XtraEditors.TextEdit();
            lblLoginSubheader = new DevExpress.XtraEditors.LabelControl();
            lblLoginHeader = new DevExpress.XtraEditors.LabelControl();
            layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutItemBranding = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemLoginEngine = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControlMaster).BeginInit();
            layoutControlMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControlLeftBranding).BeginInit();
            panelControlLeftBranding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControlRightLogin).BeginInit();
            panelControlRightLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStudentId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupRoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBranding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemLoginEngine).BeginInit();
            SuspendLayout();
            // 
            // layoutControlMaster
            // 
            layoutControlMaster.Controls.Add(panelControlLeftBranding);
            layoutControlMaster.Controls.Add(panelControlRightLogin);
            layoutControlMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControlMaster.Location = new System.Drawing.Point(0, 0);
            layoutControlMaster.Margin = new System.Windows.Forms.Padding(5);
            layoutControlMaster.Name = "layoutControlMaster";
            layoutControlMaster.Root = layoutControlGroupRoot;
            layoutControlMaster.Size = new System.Drawing.Size(1646, 906);
            layoutControlMaster.TabIndex = 0;
            // 
            // panelControlLeftBranding
            // 
            panelControlLeftBranding.Appearance.BackColor = System.Drawing.Color.FromArgb(28, 35, 60);
            panelControlLeftBranding.Appearance.Options.UseBackColor = true;
            panelControlLeftBranding.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControlLeftBranding.Controls.Add(lblBrandSubtitle);
            panelControlLeftBranding.Controls.Add(lblBrandTitle);
            panelControlLeftBranding.Location = new System.Drawing.Point(24, 24);
            panelControlLeftBranding.Margin = new System.Windows.Forms.Padding(5);
            panelControlLeftBranding.Name = "panelControlLeftBranding";
            panelControlLeftBranding.Size = new System.Drawing.Size(631, 858);
            panelControlLeftBranding.TabIndex = 4;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBrandSubtitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblBrandSubtitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(165, 175, 205);
            lblBrandSubtitle.Appearance.Options.UseFont = true;
            lblBrandSubtitle.Appearance.Options.UseForeColor = true;
            lblBrandSubtitle.Appearance.Options.UseTextOptions = true;
            lblBrandSubtitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            lblBrandSubtitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            lblBrandSubtitle.Location = new System.Drawing.Point(60, 440);
            lblBrandSubtitle.Margin = new System.Windows.Forms.Padding(5);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new System.Drawing.Size(510, 80);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Optimize your daily academic schedules and workflows tracking seamlessly.";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBrandTitle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            lblBrandTitle.Appearance.ForeColor = System.Drawing.Color.White;
            lblBrandTitle.Appearance.Options.UseFont = true;
            lblBrandTitle.Appearance.Options.UseForeColor = true;
            lblBrandTitle.Location = new System.Drawing.Point(60, 347);
            lblBrandTitle.Margin = new System.Windows.Forms.Padding(5);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new System.Drawing.Size(407, 86);
            lblBrandTitle.TabIndex = 0;
            lblBrandTitle.Text = "Task Manager";
            // 
            // panelControlRightLogin
            // 
            panelControlRightLogin.Appearance.BackColor = System.Drawing.Color.White;
            panelControlRightLogin.Appearance.Options.UseBackColor = true;
            panelControlRightLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControlRightLogin.Controls.Add(chkShowPassword);
            panelControlRightLogin.Controls.Add(lblPasswordHeader);
            panelControlRightLogin.Controls.Add(lblUsernameHeader);
            panelControlRightLogin.Controls.Add(btnLogin);
            panelControlRightLogin.Controls.Add(btnCancel); // 🔴 ADDED: Adding the cancel button to the right panel layout container
            panelControlRightLogin.Controls.Add(txtPassword);
            panelControlRightLogin.Controls.Add(txtStudentId);
            panelControlRightLogin.Controls.Add(lblLoginSubheader);
            panelControlRightLogin.Controls.Add(lblLoginHeader);
            panelControlRightLogin.Location = new System.Drawing.Point(663, 24);
            panelControlRightLogin.Margin = new System.Windows.Forms.Padding(5);
            panelControlRightLogin.Name = "panelControlRightLogin";
            panelControlRightLogin.Size = new System.Drawing.Size(959, 858);
            panelControlRightLogin.TabIndex = 5;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            chkShowPassword.Location = new System.Drawing.Point(136, 550);
            chkShowPassword.Margin = new System.Windows.Forms.Padding(5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            chkShowPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(110, 120, 145);
            chkShowPassword.Properties.Appearance.Options.UseFont = true;
            chkShowPassword.Properties.Appearance.Options.UseForeColor = true;
            chkShowPassword.Properties.Caption = "Show Password";
            chkShowPassword.Size = new System.Drawing.Size(206, 40);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblPasswordHeader
            // 
            lblPasswordHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblPasswordHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblPasswordHeader.Appearance.ForeColor = System.Drawing.Color.FromArgb(110, 120, 145);
            lblPasswordHeader.Appearance.Options.UseFont = true;
            lblPasswordHeader.Appearance.Options.UseForeColor = true;
            lblPasswordHeader.Location = new System.Drawing.Point(136, 437);
            lblPasswordHeader.Margin = new System.Windows.Forms.Padding(5);
            lblPasswordHeader.Name = "lblPasswordHeader";
            lblPasswordHeader.Size = new System.Drawing.Size(134, 32);
            lblPasswordHeader.TabIndex = 6;
            lblPasswordHeader.Text = "PASSWORD";
            // 
            // lblUsernameHeader
            // 
            lblUsernameHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblUsernameHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblUsernameHeader.Appearance.ForeColor = System.Drawing.Color.FromArgb(110, 120, 145);
            lblUsernameHeader.Appearance.Options.UseFont = true;
            lblUsernameHeader.Appearance.Options.UseForeColor = true;
            lblUsernameHeader.Location = new System.Drawing.Point(136, 289);
            lblUsernameHeader.Margin = new System.Windows.Forms.Padding(5);
            lblUsernameHeader.Name = "lblUsernameHeader";
            lblUsernameHeader.Size = new System.Drawing.Size(141, 32);
            lblUsernameHeader.TabIndex = 5;
            lblUsernameHeader.Text = "STUDENT ID";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(44, 105, 240);
            btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            btnLogin.Location = new System.Drawing.Point(136, 612);
            btnLogin.Margin = new System.Windows.Forms.Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(330, 75); // 🔄 MODIFIED: Left room for Cancel button by cutting width from 686 to 330
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign In";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(240, 70, 70); // Red palette styling
            btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Appearance.Options.UseForeColor = true;
            btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            btnCancel.Location = new System.Drawing.Point(492, 612); // 🔴 ADDED: Positioned seamlessly alongside btnLogin
            btnCancel.Margin = new System.Windows.Forms.Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(330, 75); // Balanced dimensions with btnLogin
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click; // Event handler hook
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtPassword.Location = new System.Drawing.Point(136, 475);
            txtPassword.Margin = new System.Windows.Forms.Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.AutoHeight = false;
            txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            txtPassword.Properties.UseSystemPasswordChar = true;
            txtPassword.Size = new System.Drawing.Size(686, 66);
            txtPassword.TabIndex = 3;
            // 
            // txtStudentId
            // 
            txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtStudentId.Location = new System.Drawing.Point(136, 326);
            txtStudentId.Margin = new System.Windows.Forms.Padding(5);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtStudentId.Properties.Appearance.Options.UseFont = true;
            txtStudentId.Properties.AutoHeight = false;
            txtStudentId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            txtStudentId.Size = new System.Drawing.Size(686, 71);
            txtStudentId.TabIndex = 2;
            // 
            // lblLoginSubheader
            // 
            lblLoginSubheader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblLoginSubheader.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblLoginSubheader.Appearance.ForeColor = System.Drawing.Color.FromArgb(130, 135, 155);
            lblLoginSubheader.Appearance.Options.UseFont = true;
            lblLoginSubheader.Appearance.Options.UseForeColor = true;
            lblLoginSubheader.Location = new System.Drawing.Point(136, 195);
            lblLoginSubheader.Margin = new System.Windows.Forms.Padding(5);
            lblLoginSubheader.Name = "lblLoginSubheader";
            lblLoginSubheader.Size = new System.Drawing.Size(424, 40);
            lblLoginSubheader.TabIndex = 1;
            lblLoginSubheader.Text = "Please enter your account details.";
            // 
            // lblLoginHeader
            // 
            lblLoginHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblLoginHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblLoginHeader.Appearance.ForeColor = System.Drawing.Color.FromArgb(25, 30, 45);
            lblLoginHeader.Appearance.Options.UseFont = true;
            lblLoginHeader.Appearance.Options.UseForeColor = true;
            lblLoginHeader.Location = new System.Drawing.Point(129, 112);
            lblLoginHeader.Margin = new System.Windows.Forms.Padding(5);
            lblLoginHeader.Name = "lblLoginHeader";
            lblLoginHeader.Size = new System.Drawing.Size(281, 86);
            lblLoginHeader.TabIndex = 0;
            lblLoginHeader.Text = "Welcome";
            // 
            // layoutControlGroupRoot
            // 
            layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroupRoot.GroupBordersVisible = false;
            layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutItemBranding, layoutItemLoginEngine });
            layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            layoutControlGroupRoot.Size = new System.Drawing.Size(1646, 906);
            layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutItemBranding
            // 
            layoutItemBranding.Control = panelControlLeftBranding;
            layoutItemBranding.Location = new System.Drawing.Point(0, 0);
            layoutItemBranding.Name = "layoutItemBranding";
            layoutItemBranding.Size = new System.Drawing.Size(639, 866);
            layoutItemBranding.TextVisible = false;
            // 
            // layoutItemLoginEngine
            // 
            layoutItemLoginEngine.Control = panelControlRightLogin;
            layoutItemLoginEngine.Location = new System.Drawing.Point(639, 0);
            layoutItemLoginEngine.Name = "layoutItemLoginEngine";
            layoutItemLoginEngine.Size = new System.Drawing.Size(967, 866);
            layoutItemLoginEngine.TextVisible = false;
            // 
            // LoginDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1646, 906);
            Controls.Add(layoutControlMaster);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            Name = "LoginDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Account Authentication";
            ((System.ComponentModel.ISupportInitialize)layoutControlMaster).EndInit();
            layoutControlMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControlLeftBranding).EndInit();
            panelControlLeftBranding.ResumeLayout(false);
            panelControlLeftBranding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControlRightLogin).EndInit();
            panelControlRightLogin.ResumeLayout(false);
            panelControlRightLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStudentId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupRoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBranding).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemLoginEngine).EndInit();
            ResumeLayout(false);

        }

        #endregion
    }
}