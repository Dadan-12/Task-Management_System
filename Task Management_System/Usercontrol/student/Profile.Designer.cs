using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Management_System.Usercontrol.student
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnUploadImage = new DevExpress.XtraEditors.SimpleButton();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.lblStudentId = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblCourse = new DevExpress.XtraEditors.LabelControl();

            // Initialized correctly as ButtonEdit controls to resolve type conversion error
            this.txtCurrentPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.txtNewPassword = new DevExpress.XtraEditors.ButtonEdit();
            this.txtConfirmPassword = new DevExpress.XtraEditors.ButtonEdit();

            this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cardHeaderGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutItemPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemBtnUpload = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemStudentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemCourse = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceHeader = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cardSecurityGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutItemCurrentPwd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemNewPwd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemConfirmPwd = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemBtnPwd = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceSecurity = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBtnUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemStudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSecurityGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemCurrentPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemConfirmPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBtnPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.AllowCustomization = false;
            this.mainLayoutControl.Controls.Add(this.pictureEdit1);
            this.mainLayoutControl.Controls.Add(this.btnUploadImage);
            this.mainLayoutControl.Controls.Add(this.lblName);
            this.mainLayoutControl.Controls.Add(this.lblStudentId);
            this.mainLayoutControl.Controls.Add(this.lblEmail);
            this.mainLayoutControl.Controls.Add(this.lblCourse);
            this.mainLayoutControl.Controls.Add(this.txtCurrentPassword);
            this.mainLayoutControl.Controls.Add(this.txtNewPassword);
            this.mainLayoutControl.Controls.Add(this.txtConfirmPassword);
            this.mainLayoutControl.Controls.Add(this.btnChangePassword);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.Root = this.layoutControlGroupRoot;
            this.mainLayoutControl.Size = new System.Drawing.Size(900, 700);
            this.mainLayoutControl.TabIndex = 0;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(24, 45);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 150);
            this.pictureEdit1.StyleController = this.mainLayoutControl;
            this.pictureEdit1.TabIndex = 4;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnUploadImage.Appearance.Options.UseFont = true;
            this.btnUploadImage.Location = new System.Drawing.Point(24, 195);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(150, 40);
            this.btnUploadImage.StyleController = this.mainLayoutControl;
            this.btnUploadImage.TabIndex = 5;
            this.btnUploadImage.Text = "Change Photo";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(184, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(668, 40);
            this.lblName.StyleController = this.mainLayoutControl;
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Loading Identity...";
            // 
            // lblStudentId
            // 
            this.lblStudentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStudentId.Appearance.Options.UseFont = true;
            this.lblStudentId.Location = new System.Drawing.Point(184, 85);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(668, 30);
            this.lblStudentId.StyleController = this.mainLayoutControl;
            this.lblStudentId.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Location = new System.Drawing.Point(184, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(668, 30);
            this.lblEmail.StyleController = this.mainLayoutControl;
            this.lblEmail.TabIndex = 8;
            // 
            // lblCourse
            // 
            this.lblCourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCourse.Appearance.Options.UseFont = true;
            this.lblCourse.Location = new System.Drawing.Point(184, 145);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(668, 30);
            this.lblCourse.StyleController = this.mainLayoutControl;
            this.lblCourse.TabIndex = 9;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(24, 325);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPassword.Properties.Appearance.Options.UseFont = true;
            this.txtCurrentPassword.Size = new System.Drawing.Size(828, 30);
            this.txtCurrentPassword.StyleController = this.mainLayoutControl;
            this.txtCurrentPassword.TabIndex = 11;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(24, 380);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPassword.Properties.Appearance.Options.UseFont = true;
            this.txtNewPassword.Size = new System.Drawing.Size(828, 30);
            this.txtNewPassword.StyleController = this.mainLayoutControl;
            this.txtNewPassword.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(24, 435);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(828, 30);
            this.txtConfirmPassword.StyleController = this.mainLayoutControl;
            this.txtConfirmPassword.TabIndex = 13;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.Appearance.Options.UseFont = true;
            this.btnChangePassword.Location = new System.Drawing.Point(24, 470);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 50);
            this.btnChangePassword.StyleController = this.mainLayoutControl;
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "Update Password";
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cardHeaderGroup,
            this.cardSecurityGroup});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(900, 700);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // cardHeaderGroup
            // 
            this.cardHeaderGroup.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.cardHeaderGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemPicture,
            this.layoutItemBtnUpload,
            this.layoutItemName,
            this.layoutItemStudentId,
            this.layoutItemEmail,
            this.layoutItemCourse,
            this.emptySpaceHeader});
            this.cardHeaderGroup.Location = new System.Drawing.Point(0, 0);
            this.cardHeaderGroup.Name = "cardHeaderGroup";
            this.cardHeaderGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.cardHeaderGroup.Size = new System.Drawing.Size(876, 260);
            this.cardHeaderGroup.Text = "Student Information";
            // 
            // layoutItemPicture
            // 
            this.layoutItemPicture.Control = this.pictureEdit1;
            this.layoutItemPicture.Location = new System.Drawing.Point(0, 0);
            this.layoutItemPicture.MaxSize = new System.Drawing.Size(150, 150);
            this.layoutItemPicture.MinSize = new System.Drawing.Size(150, 150);
            this.layoutItemPicture.Name = "layoutItemPicture";
            this.layoutItemPicture.Size = new System.Drawing.Size(160, 150);
            this.layoutItemPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemPicture.TextVisible = false;
            // 
            // layoutItemBtnUpload
            // 
            this.layoutItemBtnUpload.Control = this.btnUploadImage;
            this.layoutItemBtnUpload.Location = new System.Drawing.Point(0, 150);
            this.layoutItemBtnUpload.MaxSize = new System.Drawing.Size(150, 40);
            this.layoutItemBtnUpload.MinSize = new System.Drawing.Size(150, 40);
            this.layoutItemBtnUpload.Name = "layoutItemBtnUpload";
            this.layoutItemBtnUpload.Size = new System.Drawing.Size(160, 52);
            this.layoutItemBtnUpload.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemBtnUpload.TextVisible = false;
            // 
            // layoutItemName
            // 
            this.layoutItemName.Control = this.lblName;
            this.layoutItemName.Location = new System.Drawing.Point(160, 0);
            this.layoutItemName.Name = "layoutItemName";
            this.layoutItemName.Size = new System.Drawing.Size(684, 40);
            this.layoutItemName.TextVisible = false;
            // 
            // layoutItemStudentId
            // 
            this.layoutItemStudentId.Control = this.lblStudentId;
            this.layoutItemStudentId.Location = new System.Drawing.Point(160, 40);
            this.layoutItemStudentId.Name = "layoutItemStudentId";
            this.layoutItemStudentId.Size = new System.Drawing.Size(684, 30);
            this.layoutItemStudentId.TextVisible = false;
            // 
            // layoutItemEmail
            // 
            this.layoutItemEmail.Control = this.lblEmail;
            this.layoutItemEmail.Location = new System.Drawing.Point(160, 70);
            this.layoutItemEmail.Name = "layoutItemEmail";
            this.layoutItemEmail.Size = new System.Drawing.Size(684, 30);
            this.layoutItemEmail.TextVisible = false;
            // 
            // layoutItemCourse
            // 
            this.layoutItemCourse.Control = this.lblCourse;
            this.layoutItemCourse.Location = new System.Drawing.Point(160, 100);
            this.layoutItemCourse.Name = "layoutItemCourse";
            this.layoutItemCourse.Size = new System.Drawing.Size(684, 30);
            this.layoutItemCourse.TextVisible = false;
            // 
            // emptySpaceHeader
            // 
            this.emptySpaceHeader.AllowHotTrack = false;
            this.emptySpaceHeader.Location = new System.Drawing.Point(160, 130);
            this.emptySpaceHeader.Name = "emptySpaceHeader";
            this.emptySpaceHeader.Size = new System.Drawing.Size(684, 72);
            this.emptySpaceHeader.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cardSecurityGroup
            // 
            this.cardSecurityGroup.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.cardSecurityGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemCurrentPwd,
            this.layoutItemNewPwd,
            this.layoutItemConfirmPwd,
            this.layoutItemBtnPwd,
            this.emptySpaceSecurity});
            this.cardSecurityGroup.Location = new System.Drawing.Point(0, 260);
            this.cardSecurityGroup.Name = "cardSecurityGroup";
            this.cardSecurityGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 15);
            this.cardSecurityGroup.Size = new System.Drawing.Size(876, 320);
            this.cardSecurityGroup.Text = "Update Account Password";
            // 
            // layoutItemCurrentPwd
            // 
            this.layoutItemCurrentPwd.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.layoutItemCurrentPwd.AppearanceItemCaption.Options.UseFont = true;
            this.layoutItemCurrentPwd.Control = this.txtCurrentPassword;
            this.layoutItemCurrentPwd.Location = new System.Drawing.Point(0, 0);
            this.layoutItemCurrentPwd.Name = "layoutItemCurrentPwd";
            this.layoutItemCurrentPwd.Size = new System.Drawing.Size(844, 55);
            this.layoutItemCurrentPwd.Text = "Current Password";
            this.layoutItemCurrentPwd.TextLocation = DevExpress.Utils.Locations.Top;
            // 
            // layoutItemNewPwd
            // 
            this.layoutItemNewPwd.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.layoutItemNewPwd.AppearanceItemCaption.Options.UseFont = true;
            this.layoutItemNewPwd.Control = this.txtNewPassword;
            this.layoutItemNewPwd.Location = new System.Drawing.Point(0, 55);
            this.layoutItemNewPwd.Name = "layoutItemNewPwd";
            this.layoutItemNewPwd.Size = new System.Drawing.Size(844, 55);
            this.layoutItemNewPwd.Text = "New Password (Minimum 6 characters)";
            this.layoutItemNewPwd.TextLocation = DevExpress.Utils.Locations.Top;
            // 
            // layoutItemConfirmPwd
            // 
            this.layoutItemConfirmPwd.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.layoutItemConfirmPwd.AppearanceItemCaption.Options.UseFont = true;
            this.layoutItemConfirmPwd.Control = this.txtConfirmPassword;
            this.layoutItemConfirmPwd.Location = new System.Drawing.Point(0, 110);
            this.layoutItemConfirmPwd.Name = "layoutItemConfirmPwd";
            this.layoutItemConfirmPwd.Size = new System.Drawing.Size(844, 55);
            this.layoutItemConfirmPwd.Text = "Confirm New Password";
            this.layoutItemConfirmPwd.TextLocation = DevExpress.Utils.Locations.Top;
            // 
            // layoutItemBtnPwd
            // 
            this.layoutItemBtnPwd.Control = this.btnChangePassword;
            this.layoutItemBtnPwd.Location = new System.Drawing.Point(0, 165);
            this.layoutItemBtnPwd.MaxSize = new System.Drawing.Size(200, 50);
            this.layoutItemBtnPwd.MinSize = new System.Drawing.Size(200, 50);
            this.layoutItemBtnPwd.Name = "layoutItemBtnPwd";
            this.layoutItemBtnPwd.Size = new System.Drawing.Size(200, 97);
            this.layoutItemBtnPwd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemBtnPwd.TextVisible = false;
            // 
            // emptySpaceSecurity
            // 
            this.emptySpaceSecurity.AllowHotTrack = false;
            this.emptySpaceSecurity.Location = new System.Drawing.Point(200, 165);
            this.emptySpaceSecurity.Name = "emptySpaceSecurity";
            this.emptySpaceSecurity.Size = new System.Drawing.Size(644, 97);
            this.emptySpaceSecurity.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            this.xtraOpenFileDialog1.Title = "Select Profile Image Source";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutControl);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            this.mainLayoutControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardHeaderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBtnUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemStudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSecurityGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemCurrentPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemConfirmPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemBtnPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceSecurity)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private DevExpress.XtraLayout.LayoutControlGroup cardHeaderGroup;
        private DevExpress.XtraLayout.LayoutControlGroup cardSecurityGroup;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnUploadImage;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.LabelControl lblStudentId;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblCourse;

        // Declared securely as ButtonEdit controls to prevent cross-casting failures
        private DevExpress.XtraEditors.ButtonEdit txtCurrentPassword;
        private DevExpress.XtraEditors.ButtonEdit txtNewPassword;
        private DevExpress.XtraEditors.ButtonEdit txtConfirmPassword;

        private DevExpress.XtraEditors.SimpleButton btnChangePassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemPicture;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemBtnUpload;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemName;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemStudentId;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemCourse;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemCurrentPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemNewPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemConfirmPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemBtnPwd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceHeader;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceSecurity;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}