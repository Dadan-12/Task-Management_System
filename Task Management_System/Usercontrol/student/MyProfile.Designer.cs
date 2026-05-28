namespace Task_Management_System.Usercontrol.student
{
    partial class MyProfile
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
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            btnUploadImage = new DevExpress.XtraEditors.SimpleButton();
            lblName = new DevExpress.XtraEditors.LabelControl();
            lblStudentId = new DevExpress.XtraEditors.LabelControl();
            lblEmail = new DevExpress.XtraEditors.LabelControl();
            lblCourse = new DevExpress.XtraEditors.LabelControl();
            lblPhone = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            panelHeaderCard = new DevExpress.XtraEditors.PanelControl();
            xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(components);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelHeaderCard).BeginInit();
            panelHeaderCard.SuspendLayout();
            SuspendLayout();
            // 
            // pictureEdit1
            // 
            pictureEdit1.Location = new System.Drawing.Point(30, 25);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.AllowFocused = false;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(160, 160);
            pictureEdit1.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnUploadImage.Appearance.Options.UseFont = true;
            btnUploadImage.Location = new System.Drawing.Point(6, 198);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(208, 78);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = " Change Photo";
            // 
            // lblName
            // 
            lblName.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            lblName.Appearance.Options.UseFont = true;
            lblName.Location = new System.Drawing.Point(220, 8);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(449, 71);
            lblName.TabIndex = 2;
            lblName.Text = "Student Full Name";
            // 
            // lblStudentId
            // 
            lblStudentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lblStudentId.Appearance.ForeColor = System.Drawing.Color.Gray;
            lblStudentId.Appearance.Options.UseFont = true;
            lblStudentId.Appearance.Options.UseForeColor = true;
            lblStudentId.Location = new System.Drawing.Point(220, 79);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(265, 38);
            lblStudentId.TabIndex = 3;
            lblStudentId.Text = "🆔 Student ID: 00000";
            // 
            // lblEmail
            // 
            lblEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lblEmail.Appearance.Options.UseFont = true;
            lblEmail.Location = new System.Drawing.Point(220, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(351, 38);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "✉️ Email: student@univ.edu";
            // 
            // lblCourse
            // 
            lblCourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lblCourse.Appearance.Options.UseFont = true;
            lblCourse.Location = new System.Drawing.Point(220, 165);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(366, 38);
            lblCourse.TabIndex = 5;
            lblCourse.Text = "🎓 Course: Computer Studies\r\n";
            // 
            // lblPhone
            // 
            lblPhone.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            lblPhone.Appearance.Options.UseFont = true;
            lblPhone.Location = new System.Drawing.Point(220, 213);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(196, 38);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "📱 Phone: +63 ";
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(txtCurrentPassword);
            groupControl1.Controls.Add(txtNewPassword);
            groupControl1.Controls.Add(txtConfirmPassword);
            groupControl1.Controls.Add(btnChangePassword);
            groupControl1.Location = new System.Drawing.Point(40, 360);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(820, 443);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Security Settings";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new System.Drawing.Point(30, 55);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Properties.AdvancedModeOptions.Label = "Current Password";
            txtCurrentPassword.Properties.PasswordChar = '●';
            txtCurrentPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            txtCurrentPassword.Size = new System.Drawing.Size(760, 65);
            txtCurrentPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(30, 130);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Properties.AdvancedModeOptions.Label = "New Password";
            txtNewPassword.Properties.PasswordChar = '●';
            txtNewPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            txtNewPassword.Size = new System.Drawing.Size(760, 65);
            txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(30, 213);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Properties.AdvancedModeOptions.Label = "Confirm New Password";
            txtConfirmPassword.Properties.PasswordChar = '●';
            txtConfirmPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            txtConfirmPassword.Size = new System.Drawing.Size(760, 65);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            btnChangePassword.Appearance.Options.UseFont = true;
            btnChangePassword.Location = new System.Drawing.Point(30, 314);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(180, 45);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Save Password";
            // 
            // panelHeaderCard
            // 
            panelHeaderCard.Appearance.BackColor = System.Drawing.Color.Transparent;
            panelHeaderCard.Appearance.Options.UseBackColor = true;
            panelHeaderCard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelHeaderCard.Controls.Add(pictureEdit1);
            panelHeaderCard.Controls.Add(btnUploadImage);
            panelHeaderCard.Controls.Add(lblName);
            panelHeaderCard.Controls.Add(lblStudentId);
            panelHeaderCard.Controls.Add(lblEmail);
            panelHeaderCard.Controls.Add(lblCourse);
            panelHeaderCard.Controls.Add(lblPhone);
            panelHeaderCard.Location = new System.Drawing.Point(40, 35);
            panelHeaderCard.Name = "panelHeaderCard";
            panelHeaderCard.Size = new System.Drawing.Size(820, 298);
            panelHeaderCard.TabIndex = 0;
            // 
            // xtraOpenFileDialog1
            // 
            xtraOpenFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            xtraOpenFileDialog1.Title = "Choose Profile Picture";
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelHeaderCard);
            Controls.Add(groupControl1);
            Name = "MyProfile";
            Size = new System.Drawing.Size(900, 878);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelHeaderCard).EndInit();
            panelHeaderCard.ResumeLayout(false);
            panelHeaderCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelHeaderCard;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnUploadImage;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblStudentId;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblCourse;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCurrentPassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;

        // This variable declaration line handles the context issue
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}