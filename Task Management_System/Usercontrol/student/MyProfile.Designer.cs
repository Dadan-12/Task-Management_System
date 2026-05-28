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

            // 1. OBJECT INSTANTIATIONS
            mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            headerLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            headerLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            securityLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            securityLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();

            panelHeaderCard = new DevExpress.XtraEditors.PanelControl();
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
            xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(components);

            layoutItemPicture = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemBtnUpload = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemName = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemStudentId = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemEmail = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemCourse = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemPhone = new DevExpress.XtraLayout.LayoutControlItem();

            layoutItemCurrentPwd = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemNewPwd = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemConfirmPwd = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemBtnPwd = new DevExpress.XtraLayout.LayoutControlItem();

            emptySpaceHeader = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceSecurity = new DevExpress.XtraLayout.EmptySpaceItem();

            // 2. INITIALIZATION TRACKING HEADERS (BEGIN INIT)
            ((System.ComponentModel.ISupportInitialize)mainLayoutControl).BeginInit();
            mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupRoot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelHeaderCard).BeginInit();
            panelHeaderCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerLayoutControl).BeginInit();
            headerLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerLayoutGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)securityLayoutControl).BeginInit();
            securityLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)securityLayoutGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).BeginInit();

            ((System.ComponentModel.ISupportInitialize)layoutItemPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBtnUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemStudentId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemCurrentPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemNewPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemConfirmPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBtnPwd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceSecurity).BeginInit();
            SuspendLayout();

            // 3. MAIN STRUCTURAL ENGINE SETUP
            mainLayoutControl.Controls.Add(panelHeaderCard);
            mainLayoutControl.Controls.Add(groupControl1);
            mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            mainLayoutControl.Name = "mainLayoutControl";
            mainLayoutControl.Root = layoutControlGroupRoot;
            mainLayoutControl.Size = new System.Drawing.Size(1670, 1170);
            mainLayoutControl.TabIndex = 0;

            layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroupRoot.GroupBordersVisible = false;
            layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(32, 32, 32, 32);

            var layoutItemHeaderPanel = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemHeaderPanel.Control = panelHeaderCard;
            layoutItemHeaderPanel.Name = "layoutItemHeaderPanel";
            layoutItemHeaderPanel.Size = new System.Drawing.Size(1606, 250);
            layoutItemHeaderPanel.MaxSize = new System.Drawing.Size(0, 250);
            layoutItemHeaderPanel.MinSize = new System.Drawing.Size(100, 250);
            layoutItemHeaderPanel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutItemHeaderPanel.TextVisible = false;
            layoutControlGroupRoot.AddItem(layoutItemHeaderPanel);

            var layoutItemGroupSecurity = new DevExpress.XtraLayout.LayoutControlItem();
            layoutItemGroupSecurity.Control = groupControl1;
            layoutItemGroupSecurity.Name = "layoutItemGroupSecurity";
            layoutItemGroupSecurity.Size = new System.Drawing.Size(1606, 824);
            layoutItemGroupSecurity.TextVisible = false;
            layoutControlGroupRoot.AddItem(layoutItemGroupSecurity);

            // 4. HEADER PROFILE ELEMENT DESIGN
            panelHeaderCard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelHeaderCard.Appearance.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            panelHeaderCard.Appearance.Options.UseBackColor = true;
            panelHeaderCard.Controls.Add(headerLayoutControl);
            panelHeaderCard.Location = new System.Drawing.Point(32, 32);
            panelHeaderCard.Name = "panelHeaderCard";
            panelHeaderCard.Size = new System.Drawing.Size(1602, 246);
            panelHeaderCard.TabIndex = 0;

            headerLayoutControl.Controls.Add(pictureEdit1);
            headerLayoutControl.Controls.Add(btnUploadImage);
            headerLayoutControl.Controls.Add(lblName);
            headerLayoutControl.Controls.Add(lblStudentId);
            headerLayoutControl.Controls.Add(lblEmail);
            headerLayoutControl.Controls.Add(lblCourse);
            headerLayoutControl.Controls.Add(lblPhone);
            headerLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            headerLayoutControl.Location = new System.Drawing.Point(2, 2);
            headerLayoutControl.Root = headerLayoutGroup;
            headerLayoutControl.Size = new System.Drawing.Size(1598, 242);

            headerLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            headerLayoutGroup.GroupBordersVisible = false;
            headerLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 24, 24);

            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.AllowFocused = false;

            lblName.Name = "lblName";
            lblName.Text = "Name";
            lblName.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            lblName.Appearance.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            lblName.Appearance.Options.UseFont = true;
            lblName.Appearance.Options.UseForeColor = true;

            lblStudentId.Name = "lblStudentId";
            lblStudentId.Text = "🆔 Student ID: STU-2026-0000";
            lblStudentId.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblStudentId.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            lblStudentId.Appearance.Options.UseFont = true;
            lblStudentId.Appearance.Options.UseForeColor = true;

            lblEmail.Name = "lblEmail";
            lblEmail.Text = "✉️ Email: student@university.edu";
            lblEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblEmail.Appearance.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            lblEmail.Appearance.Options.UseFont = true;
            lblEmail.Appearance.Options.UseForeColor = true;

            lblCourse.Name = "lblCourse";
            lblCourse.Text = "🎓 Course: Bachelor of Science in Information Technology";
            lblCourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblCourse.Appearance.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            lblCourse.Appearance.Options.UseFont = true;
            lblCourse.Appearance.Options.UseForeColor = true;

            lblPhone.Name = "lblPhone";
            lblPhone.Text = "📱 Phone: +63 912 345 6789";
            lblPhone.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPhone.Appearance.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            lblPhone.Appearance.Options.UseFont = true;
            lblPhone.Appearance.Options.UseForeColor = true;

            btnUploadImage.StyleController = headerLayoutControl;
            btnUploadImage.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btnUploadImage.Appearance.Options.UseFont = true;
            btnUploadImage.Text = "Change Photo";

            // 5. NODE CONSTRAINT DECORATIONS
            layoutItemPicture.Control = pictureEdit1;
            layoutItemPicture.Name = "layoutItemPicture";
            layoutItemPicture.Size = new System.Drawing.Size(130, 130);
            layoutItemPicture.MaxSize = new System.Drawing.Size(130, 130);
            layoutItemPicture.MinSize = new System.Drawing.Size(130, 130);
            layoutItemPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutItemPicture.TextVisible = false;

            layoutItemBtnUpload.Control = btnUploadImage;
            layoutItemBtnUpload.Name = "layoutItemBtnUpload";
            layoutItemBtnUpload.Size = new System.Drawing.Size(130, 32);
            layoutItemBtnUpload.MaxSize = new System.Drawing.Size(130, 32);
            layoutItemBtnUpload.MinSize = new System.Drawing.Size(130, 32);
            layoutItemBtnUpload.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutItemBtnUpload.TextVisible = false;
            layoutItemBtnUpload.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0);

            layoutItemName.Control = lblName;
            layoutItemName.Name = "layoutItemName";
            layoutItemName.TextVisible = false;

            layoutItemStudentId.Control = lblStudentId;
            layoutItemStudentId.Name = "layoutItemStudentId";
            layoutItemStudentId.TextVisible = false;

            layoutItemEmail.Control = lblEmail;
            layoutItemEmail.Name = "layoutItemEmail";
            layoutItemEmail.TextVisible = false;

            layoutItemCourse.Control = lblCourse;
            layoutItemCourse.Name = "layoutItemCourse";
            layoutItemCourse.TextVisible = false;

            layoutItemPhone.Control = lblPhone;
            layoutItemPhone.Name = "layoutItemPhone";
            layoutItemPhone.TextVisible = false;

            emptySpaceHeader.Name = "emptySpaceHeader";

            // 6. GRID ENGINE MATRIX DEF
            var infoColumnGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)infoColumnGroup).BeginInit();
            infoColumnGroup.GroupBordersVisible = false;
            infoColumnGroup.Name = "infoColumnGroup";
            infoColumnGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 0, 0, 0);
            infoColumnGroup.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;

            infoColumnGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear();
            infoColumnGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(
                new DevExpress.XtraLayout.ColumnDefinition { SizeType = System.Windows.Forms.SizeType.Percent, Width = 100D }
            );

            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Clear();
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Height = 38D });
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Height = 26D });
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Height = 26D });
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Height = 26D });
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Absolute, Height = 26D });
            infoColumnGroup.OptionsTableLayoutGroup.RowDefinitions.Add(new DevExpress.XtraLayout.RowDefinition { SizeType = System.Windows.Forms.SizeType.Percent, Height = 100D });

            layoutItemName.OptionsTableLayoutItem.ColumnIndex = 0;
            layoutItemName.OptionsTableLayoutItem.RowIndex = 0;

            layoutItemStudentId.OptionsTableLayoutItem.ColumnIndex = 0;
            layoutItemStudentId.OptionsTableLayoutItem.RowIndex = 1;

            layoutItemEmail.OptionsTableLayoutItem.ColumnIndex = 0;
            layoutItemEmail.OptionsTableLayoutItem.RowIndex = 2;

            layoutItemCourse.OptionsTableLayoutItem.ColumnIndex = 0;
            layoutItemCourse.OptionsTableLayoutItem.RowIndex = 3;

            layoutItemPhone.OptionsTableLayoutItem.ColumnIndex = 0;
            layoutItemPhone.OptionsTableLayoutItem.RowIndex = 4;

            emptySpaceHeader.OptionsTableLayoutItem.ColumnIndex = 0;
            emptySpaceHeader.OptionsTableLayoutItem.RowIndex = 5;

            infoColumnGroup.AddItem(layoutItemName);
            infoColumnGroup.AddItem(layoutItemStudentId);
            infoColumnGroup.AddItem(layoutItemEmail);
            infoColumnGroup.AddItem(layoutItemCourse);
            infoColumnGroup.AddItem(layoutItemPhone);
            infoColumnGroup.AddItem(emptySpaceHeader);
            ((System.ComponentModel.ISupportInitialize)infoColumnGroup).EndInit();

            var leftColumnGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)leftColumnGroup).BeginInit();
            leftColumnGroup.GroupBordersVisible = false;
            leftColumnGroup.Name = "leftColumnGroup";
            leftColumnGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            leftColumnGroup.AddItem(layoutItemPicture);
            leftColumnGroup.AddItem(layoutItemBtnUpload);
            ((System.ComponentModel.ISupportInitialize)leftColumnGroup).EndInit();

            headerLayoutGroup.Clear();
            headerLayoutGroup.AddGroup(leftColumnGroup);
            headerLayoutGroup.AddItem(infoColumnGroup, leftColumnGroup, DevExpress.XtraLayout.Utils.InsertType.Right);

            // 7. SECURITY PASSWORD PANEL FIELDSET
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.AppearanceCaption.Options.UseForeColor = true;
            groupControl1.Controls.Add(securityLayoutControl);
            groupControl1.Text = "Update Account Password";

            securityLayoutControl.Controls.Add(txtCurrentPassword);
            securityLayoutControl.Controls.Add(txtNewPassword);
            securityLayoutControl.Controls.Add(txtConfirmPassword);
            securityLayoutControl.Controls.Add(btnChangePassword);
            securityLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            securityLayoutControl.Location = new System.Drawing.Point(2, 27);
            securityLayoutControl.Root = securityLayoutGroup;
            securityLayoutControl.Size = new System.Drawing.Size(1598, 795);

            securityLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            securityLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12);

            txtCurrentPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtCurrentPassword.Properties.UseSystemPasswordChar = true;
            txtCurrentPassword.Properties.NullValuePrompt = "Type your current password";
            txtCurrentPassword.Properties.PasswordChar = '●';

            txtNewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtNewPassword.Properties.UseSystemPasswordChar = true;
            txtNewPassword.Properties.NullValuePrompt = "Minimum 6 characters";
            txtNewPassword.Properties.PasswordChar = '●';

            txtConfirmPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            txtConfirmPassword.Properties.UseSystemPasswordChar = true;
            txtConfirmPassword.Properties.NullValuePrompt = "Repeat new password to confirm";
            txtConfirmPassword.Properties.PasswordChar = '●';

            btnChangePassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnChangePassword.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            btnChangePassword.Appearance.ForeColor = System.Drawing.Color.White;
            btnChangePassword.Appearance.Options.UseFont = true;
            btnChangePassword.Appearance.Options.UseBackColor = true;
            btnChangePassword.Appearance.Options.UseForeColor = true;
            btnChangePassword.Text = "Update Password";

            layoutItemCurrentPwd.Control = txtCurrentPassword;
            layoutItemCurrentPwd.Text = "Current Password";
            layoutItemCurrentPwd.TextLocation = DevExpress.Utils.Locations.Top;
            layoutItemCurrentPwd.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 12);

            layoutItemNewPwd.Control = txtNewPassword;
            layoutItemNewPwd.Text = "New Password";
            layoutItemNewPwd.TextLocation = DevExpress.Utils.Locations.Top;
            layoutItemNewPwd.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 12);

            layoutItemConfirmPwd.Control = txtConfirmPassword;
            layoutItemConfirmPwd.Text = "Confirm New Password";
            layoutItemConfirmPwd.TextLocation = DevExpress.Utils.Locations.Top;
            layoutItemConfirmPwd.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 16);

            layoutItemBtnPwd.Control = btnChangePassword;
            layoutItemBtnPwd.TextVisible = false;
            layoutItemBtnPwd.MaxSize = new System.Drawing.Size(200, 45);
            layoutItemBtnPwd.MinSize = new System.Drawing.Size(200, 45);
            layoutItemBtnPwd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            layoutItemBtnPwd.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12);

            emptySpaceSecurity.Name = "emptySpaceSecurity";

            securityLayoutGroup.Clear();
            securityLayoutGroup.AddItem(layoutItemCurrentPwd);
            securityLayoutGroup.AddItem(layoutItemNewPwd);
            securityLayoutGroup.AddItem(layoutItemConfirmPwd);
            securityLayoutGroup.AddItem(layoutItemBtnPwd);
            securityLayoutGroup.AddItem(emptySpaceSecurity);

            xtraOpenFileDialog1.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            xtraOpenFileDialog1.Title = "Select Student Profile Image Source";

            // 8. FINAL ATTACHMENT APPEND
            Controls.Add(mainLayoutControl);
            Name = "MyProfile";
            Size = new System.Drawing.Size(1670, 1170);

            // 9. INITIALIZATION TRACKING TAILS (END INIT)
            ((System.ComponentModel.ISupportInitialize)mainLayoutControl).EndInit();
            mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupRoot).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelHeaderCard).EndInit();
            panelHeaderCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)headerLayoutControl).EndInit();
            headerLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)headerLayoutGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)securityLayoutControl).EndInit();
            securityLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)securityLayoutGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCurrentPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtConfirmPassword.Properties).EndInit();

            ((System.ComponentModel.ISupportInitialize)layoutItemPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBtnUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemName).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemStudentId).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemCurrentPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemNewPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemConfirmPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutItemBtnPwd).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceSecurity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private DevExpress.XtraLayout.LayoutControl headerLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup headerLayoutGroup;
        private DevExpress.XtraLayout.LayoutControl securityLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup securityLayoutGroup;

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

        private DevExpress.XtraLayout.LayoutControlItem layoutItemPicture;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemBtnUpload;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemName;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemStudentId;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemCourse;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemPhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemCurrentPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemNewPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemConfirmPwd;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemBtnPwd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceHeader;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceSecurity;
    }
}