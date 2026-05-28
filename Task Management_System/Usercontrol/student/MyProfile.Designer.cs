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
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            btnUploadImage = new DevExpress.XtraEditors.SimpleButton();
            lblName = new DevExpress.XtraEditors.LabelControl();
            lblStudentId = new DevExpress.XtraEditors.LabelControl();
            lblEmail = new DevExpress.XtraEditors.LabelControl();
            lblCourse = new DevExpress.XtraEditors.LabelControl();
            lblPhone = new DevExpress.XtraEditors.LabelControl();
            separator1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            txtNewPassword = new DevExpress.XtraEditors.TextEdit();
            txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // pictureEdit1
            // 
            pictureEdit1.Location = new System.Drawing.Point(80, 50);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(200, 200);
            pictureEdit1.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new System.Drawing.Point(50, 265);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(250, 35);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = "📷 Change Profile Photo";
            // 
            // lblName
            // 
            lblName.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblName.Appearance.Options.UseFont = true;
            lblName.Location = new System.Drawing.Point(340, 36);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(421, 65);
            lblName.TabIndex = 2;
            lblName.Text = "Student Full Name";
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new System.Drawing.Point(340, 120);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(116, 25);
            lblStudentId.TabIndex = 3;
            lblStudentId.Text = "Student ID: ";
            // 
            // lblEmail
            // 
            lblEmail.Location = new System.Drawing.Point(340, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(65, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email: ";
            // 
            // lblCourse
            // 
            lblCourse.Location = new System.Drawing.Point(340, 193);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(78, 25);
            lblCourse.TabIndex = 5;
            lblCourse.Text = "Course: ";
            // 
            // lblPhone
            // 
            lblPhone.Location = new System.Drawing.Point(340, 237);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(72, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone: ";
            // 
            // separator1
            // 
            separator1.LineVisible = true;
            separator1.Location = new System.Drawing.Point(50, 310);
            separator1.Name = "separator1";
            separator1.Size = new System.Drawing.Size(0, 25);
            separator1.TabIndex = 7;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(txtCurrentPassword);
            groupControl1.Controls.Add(txtNewPassword);
            groupControl1.Controls.Add(txtConfirmPassword);
            groupControl1.Controls.Add(btnChangePassword);
            groupControl1.Location = new System.Drawing.Point(50, 340);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(750, 260);
            groupControl1.TabIndex = 8;
            groupControl1.Text = "🔒 Change Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new System.Drawing.Point(50, 50);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Properties.NullText = "Current Password";
            txtCurrentPassword.Properties.PasswordChar = '●';
            txtCurrentPassword.Size = new System.Drawing.Size(450, 56);
            txtCurrentPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(50, 95);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Properties.NullText = "New Password";
            txtNewPassword.Properties.PasswordChar = '●';
            txtNewPassword.Size = new System.Drawing.Size(450, 56);
            txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(50, 140);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Properties.NullText = "Confirm New Password";
            txtConfirmPassword.Properties.PasswordChar = '●';
            txtConfirmPassword.Size = new System.Drawing.Size(450, 56);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new System.Drawing.Point(50, 190);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(200, 45);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Update Password";
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureEdit1);
            Controls.Add(btnUploadImage);
            Controls.Add(lblName);
            Controls.Add(lblStudentId);
            Controls.Add(lblEmail);
            Controls.Add(lblCourse);
            Controls.Add(lblPhone);
            Controls.Add(separator1);
            Controls.Add(groupControl1);
            Name = "MyProfile";
            Size = new System.Drawing.Size(900, 680);
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnUploadImage;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblStudentId;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblCourse;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl separator1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtCurrentPassword;
        private DevExpress.XtraEditors.TextEdit txtNewPassword;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
    }
}