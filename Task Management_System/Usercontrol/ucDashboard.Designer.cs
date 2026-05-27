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
            panelGrid = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
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
            panelGrid.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(groupBox1);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelGrid.Location = new System.Drawing.Point(0, 224);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new System.Drawing.Size(870, 405);
            panelGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MainViewDashboard);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupBox1.Location = new System.Drawing.Point(0, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(870, 398);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "STUDENT LIST";
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Location = new System.Drawing.Point(3, 20);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            MainViewDashboard.Size = new System.Drawing.Size(864, 375);
            MainViewDashboard.TabIndex = 11;
            MainViewDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDashboard, gridView1 });
            // 
            // gvDashboard
            // 
            gvDashboard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gvDashboard.GridControl = MainViewDashboard;
            gvDashboard.Name = "gvDashboard";
            gvDashboard.OptionsView.ShowFooter = true;
            gvDashboard.RowHeight = 100;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 47;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Photo";
            gridColumn2.ColumnEdit = repositoryItemPictureEdit1;
            gridColumn2.FieldName = "picture";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 130;
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
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 123;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Firstname";
            gridColumn4.FieldName = "FirstName";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 126;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Lastname";
            gridColumn5.FieldName = "LastName";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 136;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Section";
            gridColumn6.FieldName = "Section";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 136;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Date";
            gridColumn7.FieldName = "Date";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 177;
            // 
            // gridView1
            // 
            gridView1.GridControl = MainViewDashboard;
            gridView1.Name = "gridView1";
            // 
            // AdminDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelGrid);
            Name = "AdminDashboardUC";
            Size = new System.Drawing.Size(870, 629);
            panelGrid.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.GroupBox groupBox1;
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
