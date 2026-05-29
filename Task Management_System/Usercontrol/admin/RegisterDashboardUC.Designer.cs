namespace Task_Management_System.Usercontrol.admin
{
    partial class RegisterDashboardUC
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
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtBStudentId = new DevExpress.XtraEditors.TextEdit();
            txtBFirstName = new DevExpress.XtraEditors.TextEdit();
            txtBLastname = new DevExpress.XtraEditors.TextEdit();
            txtBEmail = new DevExpress.XtraEditors.TextEdit(); // 🎯 ADDED: Email field input control
            cbSection = new DevExpress.XtraEditors.ComboBoxEdit();
            txtBPassword = new DevExpress.XtraEditors.TextEdit();
            Date = new DevExpress.XtraEditors.DateEdit();
            PicBox = new DevExpress.XtraEditors.PictureEdit();
            btnUpload = new DevExpress.XtraEditors.SimpleButton();
            btnRegister = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItemEmail = new DevExpress.XtraLayout.LayoutControlItem(); // 🎯 ADDED: Email layout layout wrapper
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItemPassword = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            MainViewDashboard = new DevExpress.XtraGrid.GridControl();
            gvDashboard = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBStudentId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBFirstName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBLastname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBEmail.Properties).BeginInit(); // 🎯 ADDED
            ((System.ComponentModel.ISupportInitialize)cbSection.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemEmail).BeginInit(); // 🎯 ADDED
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtBStudentId);
            layoutControl1.Controls.Add(txtBFirstName);
            layoutControl1.Controls.Add(txtBLastname);
            layoutControl1.Controls.Add(txtBEmail); // 🎯 ADDED
            layoutControl1.Controls.Add(cbSection);
            layoutControl1.Controls.Add(txtBPassword);
            layoutControl1.Controls.Add(Date);
            layoutControl1.Controls.Add(PicBox);
            layoutControl1.Controls.Add(btnUpload);
            layoutControl1.Controls.Add(btnRegister);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(693, 1354);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtBStudentId
            // 
            txtBStudentId.Location = new System.Drawing.Point(168, 24);
            txtBStudentId.Name = "txtBStudentId";
            txtBStudentId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBStudentId.Properties.Appearance.Options.UseFont = true;
            txtBStudentId.Size = new System.Drawing.Size(501, 46);
            txtBStudentId.StyleController = layoutControl1;
            txtBStudentId.TabIndex = 4;
            // 
            // txtBFirstName
            // 
            txtBFirstName.Location = new System.Drawing.Point(168, 78);
            txtBFirstName.Name = "txtBFirstName";
            txtBFirstName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBFirstName.Properties.Appearance.Options.UseFont = true;
            txtBFirstName.Size = new System.Drawing.Size(501, 46);
            txtBFirstName.StyleController = layoutControl1;
            txtBFirstName.TabIndex = 5;
            // 
            // txtBLastname
            // 
            txtBLastname.Location = new System.Drawing.Point(168, 132);
            txtBLastname.Name = "txtBLastname";
            txtBLastname.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBLastname.Properties.Appearance.Options.UseFont = true;
            txtBLastname.Size = new System.Drawing.Size(501, 46);
            txtBLastname.StyleController = layoutControl1;
            txtBLastname.TabIndex = 6;
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new System.Drawing.Point(168, 186);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBEmail.Properties.Appearance.Options.UseFont = true;
            txtBEmail.Size = new System.Drawing.Size(501, 46);
            txtBEmail.StyleController = layoutControl1;
            txtBEmail.TabIndex = 13;
            // 
            // cbSection
            // 
            cbSection.Location = new System.Drawing.Point(168, 240);
            cbSection.Name = "cbSection";
            cbSection.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            cbSection.Properties.Appearance.Options.UseFont = true;
            cbSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbSection.Properties.Items.AddRange(new object[] { "NEUMANN", "AIKEN" });
            cbSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbSection.Size = new System.Drawing.Size(501, 46);
            cbSection.StyleController = layoutControl1;
            cbSection.TabIndex = 7;
            // 
            // txtBPassword
            // 
            txtBPassword.Location = new System.Drawing.Point(168, 294);
            txtBPassword.Name = "txtBPassword";
            txtBPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtBPassword.Properties.Appearance.Options.UseFont = true;
            txtBPassword.Properties.UseSystemPasswordChar = true;
            txtBPassword.Size = new System.Drawing.Size(501, 46);
            txtBPassword.StyleController = layoutControl1;
            txtBPassword.TabIndex = 12;
            // 
            // Date
            // 
            Date.EditValue = null;
            Date.Location = new System.Drawing.Point(168, 348);
            Date.Name = "Date";
            Date.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            Date.Properties.Appearance.Options.UseFont = true;
            Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Date.Size = new System.Drawing.Size(501, 46);
            Date.StyleController = layoutControl1;
            Date.TabIndex = 8;
            // 
            // PicBox
            // 
            PicBox.Location = new System.Drawing.Point(168, 402);
            PicBox.Name = "PicBox";
            PicBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            PicBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            PicBox.Size = new System.Drawing.Size(501, 822);
            PicBox.StyleController = layoutControl1;
            PicBox.TabIndex = 9;
            // 
            // btnUpload
            // 
            btnUpload.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnUpload.Appearance.Options.UseFont = true;
            btnUpload.Location = new System.Drawing.Point(168, 1232);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(501, 44);
            btnUpload.StyleController = layoutControl1;
            btnUpload.TabIndex = 10;
            btnUpload.Text = "Choose Image...";
            btnUpload.Click += btnUpload_Click;
            // 
            // btnRegister
            // 
            btnRegister.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnRegister.Appearance.Options.UseFont = true;
            btnRegister.Location = new System.Drawing.Point(24, 1284);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(645, 46);
            btnRegister.StyleController = layoutControl1;
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register Account";
            btnRegister.Click += btnRegister_Click;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItemEmail, layoutControlItem4, layoutControlItemPassword, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(693, 1354);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.Control = txtBStudentId;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(653, 54);
            layoutControlItem1.Text = "Student ID:";
            layoutControlItem1.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.Control = txtBFirstName;
            layoutControlItem2.Location = new System.Drawing.Point(0, 54);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(653, 54);
            layoutControlItem2.Text = "First Name:";
            layoutControlItem2.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem3.Control = txtBLastname;
            layoutControlItem3.Location = new System.Drawing.Point(0, 108);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(653, 54);
            layoutControlItem3.Text = "Last Name:";
            layoutControlItem3.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItemEmail
            // 
            layoutControlItemEmail.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItemEmail.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItemEmail.Control = txtBEmail;
            layoutControlItemEmail.Location = new System.Drawing.Point(0, 162);
            layoutControlItemEmail.Name = "layoutControlItemEmail";
            layoutControlItemEmail.Size = new System.Drawing.Size(653, 54);
            layoutControlItemEmail.Text = "Email:";
            layoutControlItemEmail.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.Control = cbSection;
            layoutControlItem4.Location = new System.Drawing.Point(0, 216);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(653, 54);
            layoutControlItem4.Text = "Section:";
            layoutControlItem4.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItemPassword
            // 
            layoutControlItemPassword.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItemPassword.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItemPassword.Control = txtBPassword;
            layoutControlItemPassword.Location = new System.Drawing.Point(0, 270);
            layoutControlItemPassword.Name = "layoutControlItemPassword";
            layoutControlItemPassword.Size = new System.Drawing.Size(653, 54);
            layoutControlItemPassword.Text = "Password:";
            layoutControlItemPassword.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem5.Control = Date;
            layoutControlItem5.Location = new System.Drawing.Point(0, 324);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(653, 54);
            layoutControlItem5.Text = "Date:";
            layoutControlItem5.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.Control = PicBox;
            layoutControlItem6.Location = new System.Drawing.Point(0, 378);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(653, 830);
            layoutControlItem6.Text = "Image:";
            layoutControlItem6.TextSize = new System.Drawing.Size(120, 32);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = btnUpload;
            layoutControlItem7.Location = new System.Drawing.Point(0, 1208);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(653, 52);
            layoutControlItem7.Text = " ";
            layoutControlItem7.TextSize = new System.Drawing.Size(120, 25);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = btnRegister;
            layoutControlItem8.Location = new System.Drawing.Point(0, 1260);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new System.Drawing.Size(653, 54);
            layoutControlItem8.TextVisible = false;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(MainViewDashboard);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(693, 0);
            panelControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1149, 1354);
            panelControl1.TabIndex = 1;
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            MainViewDashboard.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            MainViewDashboard.Location = new System.Drawing.Point(3, 3);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            MainViewDashboard.Size = new System.Drawing.Size(1143, 1348);
            MainViewDashboard.TabIndex = 0;
            MainViewDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDashboard, gridView1 });
            // 
            // gvDashboard
            // 
            gvDashboard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gvDashboard.DetailHeight = 861;
            gvDashboard.GridControl = MainViewDashboard;
            gvDashboard.Name = "gvDashboard";
            gvDashboard.OptionsEditForm.PopupEditFormWidth = 1733;
            gvDashboard.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "ID";
            gridColumn1.FieldName = "Id";
            gridColumn1.MinWidth = 43;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Image";
            gridColumn2.ColumnEdit = repositoryItemPictureEdit1;
            gridColumn2.FieldName = "Image";
            gridColumn2.MinWidth = 43;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 152;
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Student ID";
            gridColumn3.FieldName = "Student_Id";
            gridColumn3.MinWidth = 43;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 195;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "First Name";
            gridColumn4.FieldName = "FirstName";
            gridColumn4.MinWidth = 43;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 238;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Last Name";
            gridColumn5.FieldName = "LastName";
            gridColumn5.MinWidth = 43;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 238;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Section";
            gridColumn6.FieldName = "Section";
            gridColumn6.MinWidth = 43;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 173;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Registered Date";
            gridColumn7.FieldName = "Date";
            gridColumn7.MinWidth = 43;
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 217;
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 861;
            gridView1.GridControl = MainViewDashboard;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 1733;
            // 
            // RegisterDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(layoutControl1);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "RegisterDashboardUC";
            Size = new System.Drawing.Size(1842, 1354);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtBStudentId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBFirstName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBLastname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBEmail.Properties).EndInit(); // 🎯 ADDED
            ((System.ComponentModel.ISupportInitialize)cbSection.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemEmail).EndInit(); // 🎯 ADDED
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItemPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtBStudentId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtBFirstName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtBLastname;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtBEmail; // 🎯 ADDED
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemEmail; // 🎯 ADDED
        private DevExpress.XtraEditors.ComboBoxEdit cbSection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtBPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPassword;
        private DevExpress.XtraEditors.DateEdit Date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.PictureEdit PicBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl MainViewDashboard;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDashboard;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}