namespace Task_Management_System.Usercontrol
{
    partial class RegisterDashboardUC
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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
            btnRegister = new DevExpress.XtraEditors.SimpleButton();
            PicBox = new System.Windows.Forms.PictureBox();
            txtBLastname = new DevExpress.XtraEditors.TextEdit();
            txtBFirstName = new DevExpress.XtraEditors.TextEdit();
            txtBStudentId = new DevExpress.XtraEditors.TextEdit();
            btnUpload = new DevExpress.XtraEditors.SimpleButton();
            Date = new DevExpress.XtraEditors.DateEdit();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            cbSection = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBLastname.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBFirstName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBStudentId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties.CalendarTimeProperties).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            MainViewDashboard.Location = new System.Drawing.Point(0, 213);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            MainViewDashboard.Size = new System.Drawing.Size(900, 357);
            MainViewDashboard.TabIndex = 10;
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
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(431, 173);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(122, 34);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // PicBox
            // 
            PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PicBox.Location = new System.Drawing.Point(688, 46);
            PicBox.Name = "PicBox";
            tableLayoutPanel1.SetRowSpan(PicBox, 2);
            PicBox.Size = new System.Drawing.Size(120, 78);
            PicBox.TabIndex = 6;
            PicBox.TabStop = false;
            // 
            // txtBLastname
            // 
            txtBLastname.Location = new System.Drawing.Point(171, 130);
            txtBLastname.Name = "txtBLastname";
            txtBLastname.Size = new System.Drawing.Size(202, 20);
            txtBLastname.TabIndex = 3;
            // 
            // txtBFirstName
            // 
            txtBFirstName.Location = new System.Drawing.Point(171, 87);
            txtBFirstName.Name = "txtBFirstName";
            txtBFirstName.Size = new System.Drawing.Size(202, 20);
            txtBFirstName.TabIndex = 2;
            // 
            // txtBStudentId
            // 
            txtBStudentId.Location = new System.Drawing.Point(171, 46);
            txtBStudentId.Name = "txtBStudentId";
            txtBStudentId.Size = new System.Drawing.Size(202, 20);
            txtBStudentId.TabIndex = 1;
            // 
            // btnUpload
            // 
            btnUpload.Location = new System.Drawing.Point(688, 173);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(115, 34);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload Photo";
            btnUpload.Click += btnUpload_Click;
            // 
            // Date
            // 
            Date.EditValue = new System.DateTime(2026, 5, 27, 0, 0, 0, 0);
            Date.Location = new System.Drawing.Point(431, 87);
            Date.Name = "Date";
            Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            Date.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            Date.Properties.Name = "Date";
            Date.Size = new System.Drawing.Size(201, 20);
            Date.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.7777777F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.888889F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.11111F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.77777767F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.5555553F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            tableLayoutPanel1.Controls.Add(cbSection, 4, 1);
            tableLayoutPanel1.Controls.Add(txtBStudentId, 2, 1);
            tableLayoutPanel1.Controls.Add(Date, 4, 2);
            tableLayoutPanel1.Controls.Add(btnUpload, 5, 4);
            tableLayoutPanel1.Controls.Add(txtBLastname, 2, 3);
            tableLayoutPanel1.Controls.Add(btnRegister, 4, 4);
            tableLayoutPanel1.Controls.Add(txtBFirstName, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 3, 2);
            tableLayoutPanel1.Controls.Add(label6, 5, 3);
            tableLayoutPanel1.Controls.Add(PicBox, 5, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.1964283F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0892849F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(900, 215);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new System.Drawing.Point(431, 46);
            cbSection.Name = "cbSection";
            cbSection.Size = new System.Drawing.Size(201, 21);
            cbSection.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 10;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(100, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 11;
            label2.Text = "Firstname:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(100, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 13);
            label3.TabIndex = 12;
            label3.Text = "Lastname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(379, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 13;
            label4.Text = "Section";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(379, 84);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 13);
            label5.TabIndex = 14;
            label5.Text = "Date:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(688, 127);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 26);
            label6.TabIndex = 15;
            label6.Text = "Insert your image here:";
            // 
            // RegisterDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainViewDashboard);
            Name = "RegisterDashboardUC";
            Size = new System.Drawing.Size(900, 570);
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemPictureEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBLastname.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBFirstName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBStudentId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Date.Properties).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private DevExpress.XtraGrid.GridControl MainViewDashboard;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDashboard;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private System.Windows.Forms.PictureBox PicBox;
        private DevExpress.XtraEditors.TextEdit txtBLastname;
        private DevExpress.XtraEditors.TextEdit txtBFirstName;
        private DevExpress.XtraEditors.TextEdit txtBStudentId;
        private DevExpress.XtraEditors.DateEdit Date;           // ✔ only one declaration
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSection;
    }
}