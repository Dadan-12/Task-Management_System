namespace Task_Management_System.Usercontrol
{
    partial class AdminDashboardUC
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
            pnlTotalStudent = new DevExpress.XtraEditors.PanelControl();
            lblTotalValue = new DevExpress.XtraEditors.LabelControl();
            lblTotalTitle = new DevExpress.XtraEditors.LabelControl();
            lblDateValue = new DevExpress.XtraEditors.LabelControl();
            lblDateTitle = new DevExpress.XtraEditors.LabelControl();
            pnlSection = new DevExpress.XtraEditors.PanelControl();
            lblSectionValue = new DevExpress.XtraEditors.LabelControl();
            lblSectionTitle = new DevExpress.XtraEditors.LabelControl();
            pnlDate = new DevExpress.XtraEditors.PanelControl();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            ((System.ComponentModel.ISupportInitialize)pnlTotalStudent).BeginInit();
            pnlTotalStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlSection).BeginInit();
            pnlSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDate).BeginInit();
            pnlDate.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTotalStudent
            // 
            pnlTotalStudent.Controls.Add(lblTotalValue);
            pnlTotalStudent.Controls.Add(lblTotalTitle);
            pnlTotalStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTotalStudent.Location = new System.Drawing.Point(3, 3);
            pnlTotalStudent.Name = "pnlTotalStudent";
            pnlTotalStudent.Padding = new System.Windows.Forms.Padding(10);
            pnlTotalStudent.Size = new System.Drawing.Size(290, 114);
            pnlTotalStudent.TabIndex = 1;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalValue.Appearance.ForeColor = System.Drawing.Color.Black;
            lblTotalValue.Appearance.Options.UseFont = true;
            lblTotalValue.Appearance.Options.UseForeColor = true;
            lblTotalValue.Location = new System.Drawing.Point(98, 44);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new System.Drawing.Size(20, 39);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblTotalTitle.Appearance.Options.UseFont = true;
            lblTotalTitle.Appearance.Options.UseForeColor = true;
            lblTotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblTotalTitle.Location = new System.Drawing.Point(12, 12);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new System.Drawing.Size(97, 14);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "TOTAL STUDENT";
            // 
            // lblDateValue
            // 
            lblDateValue.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDateValue.Appearance.Options.UseFont = true;
            lblDateValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDateValue.Location = new System.Drawing.Point(12, 12);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new System.Drawing.Size(176, 90);
            lblDateValue.TabIndex = 1;
            lblDateValue.Text = "0";
            // 
            // lblDateTitle
            // 
            lblDateTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDateTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblDateTitle.Appearance.Options.UseFont = true;
            lblDateTitle.Appearance.Options.UseForeColor = true;
            lblDateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblDateTitle.Location = new System.Drawing.Point(12, 12);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new System.Drawing.Size(86, 14);
            lblDateTitle.TabIndex = 0;
            lblDateTitle.Text = "TODAY'S DATE";
            // 
            // pnlSection
            // 
            pnlSection.Controls.Add(lblSectionValue);
            pnlSection.Controls.Add(lblSectionTitle);
            pnlSection.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSection.Location = new System.Drawing.Point(299, 3);
            pnlSection.Name = "pnlSection";
            pnlSection.Padding = new System.Windows.Forms.Padding(10);
            pnlSection.Size = new System.Drawing.Size(291, 114);
            pnlSection.TabIndex = 1;
            pnlSection.Paint += pnlSection_Paint;
            // 
            // lblSectionValue
            // 
            lblSectionValue.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSectionValue.Appearance.Options.UseFont = true;
            lblSectionValue.Location = new System.Drawing.Point(101, 44);
            lblSectionValue.Name = "lblSectionValue";
            lblSectionValue.Size = new System.Drawing.Size(20, 39);
            lblSectionValue.TabIndex = 1;
            lblSectionValue.Text = "2";
            // 
            // lblSectionTitle
            // 
            lblSectionTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSectionTitle.Appearance.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblSectionTitle.Appearance.Options.UseFont = true;
            lblSectionTitle.Appearance.Options.UseForeColor = true;
            lblSectionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblSectionTitle.Location = new System.Drawing.Point(12, 12);
            lblSectionTitle.Name = "lblSectionTitle";
            lblSectionTitle.Size = new System.Drawing.Size(50, 14);
            lblSectionTitle.TabIndex = 0;
            lblSectionTitle.Text = "SECTION";
            lblSectionTitle.Click += lblSectionTitle_Click;
            // 
            // pnlDate
            // 
            pnlDate.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pnlDate.Appearance.Options.UseBackColor = true;
            pnlDate.Controls.Add(lblDateTitle);
            pnlDate.Controls.Add(lblDateValue);
            pnlDate.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDate.Location = new System.Drawing.Point(596, 3);
            pnlDate.MaximumSize = new System.Drawing.Size(200, 0);
            pnlDate.Name = "pnlDate";
            pnlDate.Padding = new System.Windows.Forms.Padding(10);
            pnlDate.Size = new System.Drawing.Size(200, 114);
            pnlDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(891, 652);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(groupControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlSection, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlDate, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlTotalStudent, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            tableLayoutPanel1.Size = new System.Drawing.Size(891, 652);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            tableLayoutPanel1.SetColumnSpan(groupControl1, 3);
            groupControl1.Controls.Add(MainViewDashboard);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            groupControl1.Location = new System.Drawing.Point(4, 125);
            groupControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(883, 522);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "REGISTERED STUDENT";
            groupControl1.Paint += groupControl1_Paint;
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            MainViewDashboard.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MainViewDashboard.Location = new System.Drawing.Point(2, 23);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            MainViewDashboard.Size = new System.Drawing.Size(879, 497);
            MainViewDashboard.TabIndex = 11;
            MainViewDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDashboard, gridView1 });
            MainViewDashboard.Click += MainViewDashboard_Click;
            // 
            // gvDashboard
            // 
            gvDashboard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gvDashboard.DetailHeight = 511;
            gvDashboard.GridControl = MainViewDashboard;
            gvDashboard.Name = "gvDashboard";
            gvDashboard.OptionsEditForm.PopupEditFormWidth = 1200;
            gvDashboard.OptionsView.ShowFooter = true;
            gvDashboard.RowHeight = 30;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "Id";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 70;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Photo";
            gridColumn2.ColumnEdit = repositoryItemPictureEdit1;
            gridColumn2.FieldName = "picture";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 80;
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Student ID";
            gridColumn3.FieldName = "Student_Id";
            gridColumn3.MinWidth = 30;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 184;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Firstname";
            gridColumn4.FieldName = "FirstName";
            gridColumn4.MinWidth = 30;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 99;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Lastname";
            gridColumn5.FieldName = "LastName";
            gridColumn5.MinWidth = 30;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 204;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Section";
            gridColumn6.FieldName = "Section";
            gridColumn6.MinWidth = 30;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 204;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Date";
            gridColumn7.FieldName = "Date";
            gridColumn7.MinWidth = 30;
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 265;
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 511;
            gridView1.GridControl = MainViewDashboard;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 1200;
            // 
            // AdminDashboardUC
            // 
            Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "AdminDashboardUC";
            Size = new System.Drawing.Size(891, 652);
            ((System.ComponentModel.ISupportInitialize)pnlTotalStudent).EndInit();
            pnlTotalStudent.ResumeLayout(false);
            pnlTotalStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlSection).EndInit();
            pnlSection.ResumeLayout(false);
            pnlSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlDate).EndInit();
            pnlDate.ResumeLayout(false);
            pnlDate.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnlDate;
        private DevExpress.XtraEditors.PanelControl pnlTotalStudent;
        private DevExpress.XtraEditors.PanelControl pnlSection;
        private DevExpress.XtraEditors.LabelControl lblTotalValue;
        private DevExpress.XtraEditors.LabelControl lblTotalTitle;
        private DevExpress.XtraEditors.LabelControl lblSectionTitle;
        private DevExpress.XtraEditors.LabelControl lblDateValue;
        private DevExpress.XtraEditors.LabelControl lblDateTitle;
        private DevExpress.XtraEditors.LabelControl lblSectionValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
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
