namespace Task_Management_System.Dashboards
{

    partial class LoginDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private DevExpress.XtraEditors.PanelControl pnlShell;
        private DevExpress.XtraEditors.PanelControl pnlBrand;
        private DevExpress.XtraEditors.PanelControl pnlForm;

        private DevExpress.XtraEditors.LabelControl lblBrandName;
        private DevExpress.XtraEditors.LabelControl lblHeroTitle;
        private DevExpress.XtraEditors.LabelControl lblHeroSub;
        private DevExpress.XtraEditors.LabelControl lblFeature1;
        private DevExpress.XtraEditors.LabelControl lblFeature2;
        private DevExpress.XtraEditors.LabelControl lblFeature3;

        private DevExpress.XtraEditors.LabelControl lblEyebrow;
        private DevExpress.XtraEditors.LabelControl lblFormTitle;
        private DevExpress.XtraEditors.LabelControl lblFormSub;
        private DevExpress.XtraEditors.LabelControl lblUsername;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.CheckEdit chkShowPassword;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlShell = new DevExpress.XtraEditors.PanelControl();
            pnlForm = new DevExpress.XtraEditors.PanelControl();
            lblEyebrow = new DevExpress.XtraEditors.LabelControl();
            lblFormTitle = new DevExpress.XtraEditors.LabelControl();
            lblFormSub = new DevExpress.XtraEditors.LabelControl();
            lblUsername = new DevExpress.XtraEditors.LabelControl();
            txtUsername = new DevExpress.XtraEditors.TextEdit();
            lblPassword = new DevExpress.XtraEditors.LabelControl();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            chkShowPassword = new DevExpress.XtraEditors.CheckEdit();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            btnLogin = new DevExpress.XtraEditors.SimpleButton();
            pnlBrand = new DevExpress.XtraEditors.PanelControl();
            lblBrandName = new DevExpress.XtraEditors.LabelControl();
            lblHeroTitle = new DevExpress.XtraEditors.LabelControl();
            lblHeroSub = new DevExpress.XtraEditors.LabelControl();
            lblFeature1 = new DevExpress.XtraEditors.LabelControl();
            lblFeature2 = new DevExpress.XtraEditors.LabelControl();
            lblFeature3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)pnlShell).BeginInit();
            pnlShell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlForm).BeginInit();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlBrand).BeginInit();
            pnlBrand.SuspendLayout();
            SuspendLayout();
            // 
            // pnlShell
            // 
            pnlShell.Appearance.BackColor = System.Drawing.Color.White;
            pnlShell.Appearance.BorderColor = System.Drawing.Color.FromArgb(226, 229, 239);
            pnlShell.Appearance.Options.UseBackColor = true;
            pnlShell.Appearance.Options.UseBorderColor = true;
            pnlShell.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            pnlShell.Controls.Add(pnlForm);
            pnlShell.Controls.Add(pnlBrand);
            pnlShell.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlShell.Location = new System.Drawing.Point(0, 0);
            pnlShell.Margin = new System.Windows.Forms.Padding(5);
            pnlShell.Name = "pnlShell";
            pnlShell.Size = new System.Drawing.Size(1750, 1480);
            pnlShell.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.Appearance.BackColor = System.Drawing.Color.White;
            pnlForm.Appearance.Options.UseBackColor = true;
            pnlForm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnlForm.Controls.Add(lblEyebrow);
            pnlForm.Controls.Add(lblFormTitle);
            pnlForm.Controls.Add(lblFormSub);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(chkShowPassword);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlForm.Location = new System.Drawing.Point(677, 3);
            pnlForm.Margin = new System.Windows.Forms.Padding(5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(1070, 1474);
            pnlForm.TabIndex = 1;
            // 
            // lblEyebrow
            // 
            lblEyebrow.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblEyebrow.Appearance.ForeColor = System.Drawing.Color.FromArgb(124, 133, 168);
            lblEyebrow.Appearance.Options.UseFont = true;
            lblEyebrow.Appearance.Options.UseForeColor = true;
            lblEyebrow.Location = new System.Drawing.Point(103, 133);
            lblEyebrow.Margin = new System.Windows.Forms.Padding(5);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new System.Drawing.Size(179, 31);
            lblEyebrow.TabIndex = 0;
            lblEyebrow.Text = "WELCOME BACK";
            // 
            // lblFormTitle
            // 
            lblFormTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblFormTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(20, 27, 56);
            lblFormTitle.Appearance.Options.UseFont = true;
            lblFormTitle.Appearance.Options.UseForeColor = true;
            lblFormTitle.Location = new System.Drawing.Point(103, 171);
            lblFormTitle.Margin = new System.Windows.Forms.Padding(5);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new System.Drawing.Size(701, 86);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "Sign in to your account";
            // 
            // lblFormSub
            // 
            lblFormSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(144, 153, 184);
            lblFormSub.Appearance.Options.UseForeColor = true;
            lblFormSub.Location = new System.Drawing.Point(103, 272);
            lblFormSub.Margin = new System.Windows.Forms.Padding(5);
            lblFormSub.Name = "lblFormSub";
            lblFormSub.Size = new System.Drawing.Size(318, 25);
            lblFormSub.TabIndex = 2;
            lblFormSub.Text = "Enter your credentials to continue";
            // 
            // lblUsername
            // 
            lblUsername.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblUsername.Appearance.ForeColor = System.Drawing.Color.FromArgb(108, 116, 142);
            lblUsername.Appearance.Options.UseFont = true;
            lblUsername.Appearance.Options.UseForeColor = true;
            lblUsername.Location = new System.Drawing.Point(103, 350);
            lblUsername.Margin = new System.Windows.Forms.Padding(5);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(125, 31);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(103, 400);
            txtUsername.Margin = new System.Windows.Forms.Padding(5);
            txtUsername.Name = "txtUsername";
            txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            txtUsername.Properties.Appearance.Options.UseBackColor = true;
            txtUsername.Properties.NullValuePrompt = "Enter your username";
            txtUsername.Size = new System.Drawing.Size(823, 40);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(108, 116, 142);
            lblPassword.Appearance.Options.UseFont = true;
            lblPassword.Appearance.Options.UseForeColor = true;
            lblPassword.Location = new System.Drawing.Point(103, 492);
            lblPassword.Margin = new System.Windows.Forms.Padding(5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(128, 31);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(103, 542);
            txtPassword.Margin = new System.Windows.Forms.Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            txtPassword.Properties.Appearance.Options.UseBackColor = true;
            txtPassword.Properties.NullValuePrompt = "Enter your password";
            txtPassword.Properties.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(823, 40);
            txtPassword.TabIndex = 6;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new System.Drawing.Point(103, 635);
            chkShowPassword.Margin = new System.Windows.Forms.Padding(5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Properties.Caption = "Show password";
            chkShowPassword.Size = new System.Drawing.Size(257, 40);
            chkShowPassword.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(201, 69, 69);
            lblStatus.Appearance.Options.UseForeColor = true;
            lblStatus.Location = new System.Drawing.Point(103, 683);
            lblStatus.Margin = new System.Windows.Forms.Padding(5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(0, 25);
            lblStatus.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(45, 78, 216);
            btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            btnLogin.Appearance.Options.UseBackColor = true;
            btnLogin.Appearance.Options.UseFont = true;
            btnLogin.Appearance.Options.UseForeColor = true;
            btnLogin.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(37, 65, 194);
            btnLogin.AppearanceHovered.Options.UseBackColor = true;
            btnLogin.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(30, 54, 170);
            btnLogin.AppearancePressed.Options.UseBackColor = true;
            btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnLogin.Location = new System.Drawing.Point(103, 735);
            btnLogin.Margin = new System.Windows.Forms.Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(823, 97);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Sign In";
            // 
            // pnlBrand
            // 
            pnlBrand.Appearance.BackColor = System.Drawing.Color.FromArgb(28, 43, 94);
            pnlBrand.Appearance.Options.UseBackColor = true;
            pnlBrand.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnlBrand.Controls.Add(lblBrandName);
            pnlBrand.Controls.Add(lblHeroTitle);
            pnlBrand.Controls.Add(lblHeroSub);
            pnlBrand.Controls.Add(lblFeature1);
            pnlBrand.Controls.Add(lblFeature2);
            pnlBrand.Controls.Add(lblFeature3);
            pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            pnlBrand.Location = new System.Drawing.Point(3, 3);
            pnlBrand.Margin = new System.Windows.Forms.Padding(5);
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new System.Drawing.Size(674, 1474);
            pnlBrand.TabIndex = 0;
            // 
            // lblBrandName
            // 
            lblBrandName.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblBrandName.Appearance.ForeColor = System.Drawing.Color.FromArgb(215, 220, 248);
            lblBrandName.Appearance.Options.UseFont = true;
            lblBrandName.Appearance.Options.UseForeColor = true;
            lblBrandName.Location = new System.Drawing.Point(75, 77);
            lblBrandName.Margin = new System.Windows.Forms.Padding(5);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new System.Drawing.Size(254, 40);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Task Management";
            // 
            // lblHeroTitle
            // 
            lblHeroTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblHeroTitle.Appearance.ForeColor = System.Drawing.Color.White;
            lblHeroTitle.Appearance.Options.UseFont = true;
            lblHeroTitle.Appearance.Options.UseForeColor = true;
            lblHeroTitle.Location = new System.Drawing.Point(75, 200);
            lblHeroTitle.Margin = new System.Windows.Forms.Padding(5);
            lblHeroTitle.Name = "lblHeroTitle";
            lblHeroTitle.Size = new System.Drawing.Size(441, 234);
            lblHeroTitle.TabIndex = 1;
            lblHeroTitle.Text = "Manage tasks.\r\nMeet deadlines.\r\nStay in control.";
            // 
            // lblHeroSub
            // 
            lblHeroSub.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lblHeroSub.Appearance.ForeColor = System.Drawing.Color.FromArgb(122, 145, 200);
            lblHeroSub.Appearance.Options.UseFont = true;
            lblHeroSub.Appearance.Options.UseForeColor = true;
            lblHeroSub.Location = new System.Drawing.Point(83, 500);
            lblHeroSub.Margin = new System.Windows.Forms.Padding(5);
            lblHeroSub.Name = "lblHeroSub";
            lblHeroSub.Size = new System.Drawing.Size(351, 114);
            lblHeroSub.TabIndex = 2;
            lblHeroSub.Text = "Your all-in-one platform for \r\nacademic and administrative \r\ntask management.";
            // 
            // lblFeature1
            // 
            lblFeature1.Appearance.ForeColor = System.Drawing.Color.FromArgb(120, 145, 198);
            lblFeature1.Appearance.Options.UseForeColor = true;
            lblFeature1.Location = new System.Drawing.Point(75, 800);
            lblFeature1.Margin = new System.Windows.Forms.Padding(5);
            lblFeature1.Name = "lblFeature1";
            lblFeature1.Size = new System.Drawing.Size(415, 25);
            lblFeature1.TabIndex = 3;
            lblFeature1.Text = "· Role-based admin and student dashboards";
            // 
            // lblFeature2
            // 
            lblFeature2.Appearance.ForeColor = System.Drawing.Color.FromArgb(120, 145, 198);
            lblFeature2.Appearance.Options.UseForeColor = true;
            lblFeature2.Location = new System.Drawing.Point(75, 850);
            lblFeature2.Margin = new System.Windows.Forms.Padding(5);
            lblFeature2.Name = "lblFeature2";
            lblFeature2.Size = new System.Drawing.Size(390, 25);
            lblFeature2.TabIndex = 4;
            lblFeature2.Text = "· Real-time task tracking and notifications";
            // 
            // lblFeature3
            // 
            lblFeature3.Appearance.ForeColor = System.Drawing.Color.FromArgb(120, 145, 198);
            lblFeature3.Appearance.Options.UseForeColor = true;
            lblFeature3.Location = new System.Drawing.Point(75, 900);
            lblFeature3.Margin = new System.Windows.Forms.Padding(5);
            lblFeature3.Name = "lblFeature3";
            lblFeature3.Size = new System.Drawing.Size(392, 25);
            lblFeature3.TabIndex = 5;
            lblFeature3.Text = "· Secure accounts with permission control";
            // 
            // LoginDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1750, 1480);
            Controls.Add(pnlShell);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            Name = "LoginDashboard";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Task Management System - Login";
            ((System.ComponentModel.ISupportInitialize)pnlShell).EndInit();
            pnlShell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnlForm).EndInit();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkShowPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlBrand).EndInit();
            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            ResumeLayout(false);
        }
    }
}