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
            pictureEdit1.Location = new System.Drawing.Point(40, 30);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new System.Drawing.Size(160, 160);
            pictureEdit1.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new System.Drawing.Point(40, 205);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new System.Drawing.Size(160, 40);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = "Upload Image";
            // 
            // lblName
            // 
            lblName.Location = new System.Drawing.Point(240, 40);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(54, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblStudentId
            // 
            lblStudentId.Location = new System.Drawing.Point(240, 95);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(102, 25);
            lblStudentId.TabIndex = 3;
            lblStudentId.Text = "Student ID";
            // 
            // lblEmail
            // 
            lblEmail.Location = new System.Drawing.Point(240, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(51, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblCourse
            // 
            lblCourse.Location = new System.Drawing.Point(700, 40);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(64, 25);
            lblCourse.TabIndex = 5;
            lblCourse.Text = "Course";
            // 
            // lblPhone
            // 
            lblPhone.Location = new System.Drawing.Point(700, 95);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(58, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // groupControl1
            // 
            groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupControl1.Controls.Add(txtCurrentPassword);
            groupControl1.Controls.Add(txtNewPassword);
            groupControl1.Controls.Add(txtConfirmPassword);
            groupControl1.Controls.Add(btnChangePassword);
            groupControl1.Location = new System.Drawing.Point(535, 330);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(600, 420);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Security Panel";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new System.Drawing.Point(50, 70);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new System.Drawing.Size(500, 40);
            txtCurrentPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(50, 150);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new System.Drawing.Size(500, 40);
            txtNewPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(50, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(500, 40);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new System.Drawing.Point(350, 320);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(200, 50);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Update Password";
            // 
            // panelHeaderCard
            // 
            panelHeaderCard.Controls.Add(pictureEdit1);
            panelHeaderCard.Controls.Add(btnUploadImage);
            panelHeaderCard.Controls.Add(lblName);
            panelHeaderCard.Controls.Add(lblStudentId);
            panelHeaderCard.Controls.Add(lblEmail);
            panelHeaderCard.Controls.Add(lblCourse);
            panelHeaderCard.Controls.Add(lblPhone);
            panelHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeaderCard.Location = new System.Drawing.Point(0, 0);
            panelHeaderCard.Name = "panelHeaderCard";
            panelHeaderCard.Size = new System.Drawing.Size(1670, 260);
            panelHeaderCard.TabIndex = 0;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupControl1);
            Controls.Add(panelHeaderCard);
            Name = "MyProfile";
            Size = new System.Drawing.Size(1670, 1170);
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
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}