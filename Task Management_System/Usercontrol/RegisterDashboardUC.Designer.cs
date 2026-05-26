namespace Task_Management_System.Usercontrol
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
            ucRegister = new DevExpress.XtraEditors.GroupControl();
            gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            gvMainView = new DevExpress.XtraGrid.GridControl();
            gvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            panel1 = new System.Windows.Forms.Panel();
            txtBLastname = new System.Windows.Forms.TextBox();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)ucRegister).BeginInit();
            ucRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).BeginInit();
            gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).BeginInit();
            gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvMainView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            SuspendLayout();
            // 
            // ucRegister
            // 
            ucRegister.CaptionLocation = DevExpress.Utils.Locations.Top;
            ucRegister.Controls.Add(gridSplitContainer1);
            ucRegister.Controls.Add(panel1);
            ucRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            ucRegister.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            ucRegister.Location = new System.Drawing.Point(0, 0);
            ucRegister.Name = "ucRegister";
            ucRegister.Size = new System.Drawing.Size(768, 593);
            ucRegister.TabIndex = 6;
            ucRegister.Text = "Register Field";
            // 
            // gridSplitContainer1
            // 
            gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridSplitContainer1.Grid = gvMainView;
            gridSplitContainer1.Location = new System.Drawing.Point(2, 235);
            gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            gridSplitContainer1.Panel1.Controls.Add(gvMainView);
            gridSplitContainer1.Size = new System.Drawing.Size(764, 356);
            gridSplitContainer1.TabIndex = 16;
            // 
            // gvMainView
            // 
            gvMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            gvMainView.Location = new System.Drawing.Point(0, 0);
            gvMainView.MainView = gvMain;
            gvMainView.Name = "gvMainView";
            gvMainView.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            gvMainView.Size = new System.Drawing.Size(764, 356);
            gvMainView.TabIndex = 9;
            gvMainView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvMain });
            // 
            // gvMain
            // 
            gvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn8, gridColumn9, gridColumn10, gridColumn11, gridColumn12, gridColumn13 });
            gvMain.GridControl = gvMainView;
            gvMain.Name = "gvMain";
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "Photo";
            gridColumn8.ColumnEdit = repositoryItemPictureEdit1;
            gridColumn8.FieldName = "Photo";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 0;
            gridColumn8.Width = 90;
            // 
            // repositoryItemPictureEdit1
            // 
            repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "Student ID";
            gridColumn9.FieldName = "Student_Id";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 1;
            gridColumn9.Width = 187;
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "FirstName";
            gridColumn10.FieldName = "Firstname";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 2;
            gridColumn10.Width = 163;
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "LastName";
            gridColumn11.FieldName = "Lastname";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 3;
            gridColumn11.Width = 140;
            // 
            // gridColumn12
            // 
            gridColumn12.Caption = "Section";
            gridColumn12.FieldName = "Section";
            gridColumn12.Name = "gridColumn12";
            gridColumn12.Visible = true;
            gridColumn12.VisibleIndex = 4;
            gridColumn12.Width = 126;
            // 
            // gridColumn13
            // 
            gridColumn13.Caption = "Date";
            gridColumn13.Name = "gridColumn13";
            gridColumn13.Visible = true;
            gridColumn13.VisibleIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(layoutControl1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(2, 23);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(764, 212);
            panel1.TabIndex = 15;
            // 
            // txtBLastname
            // 
            txtBLastname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtBLastname.Cursor = System.Windows.Forms.Cursors.No;
            txtBLastname.Location = new System.Drawing.Point(117, 12);
            txtBLastname.Name = "txtBLastname";
            txtBLastname.Size = new System.Drawing.Size(408, 20);
            txtBLastname.TabIndex = 2;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Location = new System.Drawing.Point(0, 0);
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(180, 120);
            // 
            // layoutControl1
            // 
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(601, 38, 650, 400);
            layoutControl1.Root = layoutControlGroup1;
            layoutControl1.Size = new System.Drawing.Size(764, 212);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new System.Drawing.Size(764, 212);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            layoutControlGroup2.Name = "layoutControlGroup1";
            layoutControlGroup2.Size = new System.Drawing.Size(764, 212);
            layoutControlGroup2.TextVisible = false;
            // 
            // RegisterDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(ucRegister);
            Name = "RegisterDashboardUC";
            Size = new System.Drawing.Size(768, 593);
            ((System.ComponentModel.ISupportInitialize)ucRegister).EndInit();
            ucRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel1).EndInit();
            gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1.Panel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSplitContainer1).EndInit();
            gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvMainView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ucRegister;
        private System.Windows.Forms.TextBox txtBLastname;
        private DevExpress.XtraGrid.GridControl gvMainView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
