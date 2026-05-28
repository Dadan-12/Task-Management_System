namespace Task_Management_System.Usercontrol
{
    partial class RegisterDashboardUC
    {
        // Kini ang mga gamit sa form, i-dispose kung dili na gamiton
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterDashboardUC));
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            MainViewDashboard.Location = new System.Drawing.Point(2, 2);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemPictureEdit1 });
            MainViewDashboard.Size = new System.Drawing.Size(896, 367);
            MainViewDashboard.TabIndex = 10;
            MainViewDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDashboard, gridView1 });
            // 
            // gvDashboard
            // 
            gvDashboard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gvDashboard.GridControl = MainViewDashboard;
            gvDashboard.Name = "gvDashboard";
            gvDashboard.OptionsView.ShowFooter = true;
            gvDashboard.OptionsView.ShowGroupPanel = false;
            gvDashboard.RowHeight = 55;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 27;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Photo";
            gridColumn2.ColumnEdit = repositoryItemPictureEdit1;
            gridColumn2.FieldName = "picture";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 114;
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
            gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Firstname";
            gridColumn4.FieldName = "FirstName";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 146;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Lastname";
            gridColumn5.FieldName = "LastName";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 144;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Section";
            gridColumn6.FieldName = "Section";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 120;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Date";
            gridColumn7.FieldName = "Date";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 213;
            // 
            // gridView1
            // 
            gridView1.GridControl = MainViewDashboard;
            gridView1.Name = "gridView1";
            // 
            // btnRegister
            // 
            btnRegister.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnRegister.ImageOptions.SvgImage");
            btnRegister.Location = new System.Drawing.Point(422, 152);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(201, 34);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // PicBox
            // 
            PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PicBox.Location = new System.Drawing.Point(681, 33);
            PicBox.Name = "PicBox";
            tableLayoutPanel1.SetRowSpan(PicBox, 2);
            PicBox.Size = new System.Drawing.Size(172, 77);
            PicBox.TabIndex = 6;
            PicBox.TabStop = false;
            // 
            // txtBLastname
            // 
            txtBLastname.Location = new System.Drawing.Point(170, 116);
            txtBLastname.Name = "txtBLastname";
            txtBLastname.Size = new System.Drawing.Size(196, 20);
            txtBLastname.TabIndex = 3;
            // 
            // txtBFirstName
            // 
            txtBFirstName.Location = new System.Drawing.Point(170, 74);
            txtBFirstName.Name = "txtBFirstName";
            txtBFirstName.Size = new System.Drawing.Size(196, 20);
            txtBFirstName.TabIndex = 2;
            // 
            // txtBStudentId
            // 
            txtBStudentId.Location = new System.Drawing.Point(170, 33);
            txtBStudentId.Name = "txtBStudentId";
            txtBStudentId.Size = new System.Drawing.Size(196, 20);
            txtBStudentId.TabIndex = 1;
            // 
            // btnUpload
            // 
            btnUpload.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnUpload.ImageOptions.SvgImage");
            btnUpload.Location = new System.Drawing.Point(681, 152);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(170, 34);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Upload Photo";
            btnUpload.Click += btnUpload_Click;
            // 
            // Date
            // 
            Date.EditValue = new System.DateTime(2026, 5, 27, 0, 0, 0, 0);
            Date.Location = new System.Drawing.Point(422, 74);
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
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.77777767F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.4444447F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.55555534F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.7777786F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.888889F));
            tableLayoutPanel1.Controls.Add(cbSection, 4, 1);
            tableLayoutPanel1.Controls.Add(txtBStudentId, 2, 1);
            tableLayoutPanel1.Controls.Add(Date, 4, 2);
            tableLayoutPanel1.Controls.Add(btnUpload, 5, 4);
            tableLayoutPanel1.Controls.Add(txtBLastname, 2, 3);
            tableLayoutPanel1.Controls.Add(txtBFirstName, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 3, 2);
            tableLayoutPanel1.Controls.Add(label6, 5, 3);
            tableLayoutPanel1.Controls.Add(PicBox, 5, 1);
            tableLayoutPanel1.Controls.Add(btnRegister, 4, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0753765F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.6030159F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.1055279F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5929642F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.6231155F));
            tableLayoutPanel1.Size = new System.Drawing.Size(900, 199);
            tableLayoutPanel1.TabIndex = 11;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Items.AddRange(new object[] { "Neumann", "Aiken" });
            cbSection.Location = new System.Drawing.Point(422, 33);
            cbSection.Name = "cbSection";
            cbSection.Size = new System.Drawing.Size(201, 21);
            cbSection.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 13);
            label1.TabIndex = 10;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(100, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 11;
            label2.Text = "Firstname:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(100, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 13);
            label3.TabIndex = 12;
            label3.Text = "Lastname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(372, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 26);
            label4.TabIndex = 13;
            label4.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(372, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(34, 13);
            label5.TabIndex = 14;
            label5.Text = "Date:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(681, 113);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(121, 13);
            label6.TabIndex = 15;
            label6.Text = "Insert your image here:";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(MainViewDashboard);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Location = new System.Drawing.Point(0, 199);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(900, 371);
            panelControl1.TabIndex = 12;
            // 
            // RegisterDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(tableLayoutPanel1);
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
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Mga gideklara nga controls sa form
        private DevExpress.XtraGrid.GridControl MainViewDashboard;         // Grid para sa lista
        private DevExpress.XtraGrid.Views.Grid.GridView gvDashboard;       // View sa grid
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;        // Kolum ID
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;        // Kolum Photo
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;        // Kolum Student ID
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;        // Kolum Firstname
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;        // Kolum Lastname
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;        // Kolum Section
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;        // Kolum Date
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;         // Extra grid view
        private DevExpress.XtraEditors.SimpleButton btnRegister;           // Buton para mag-register
        private System.Windows.Forms.PictureBox PicBox;                    // Kahon sa litrato
        private DevExpress.XtraEditors.TextEdit txtBLastname;              // Textbox apelyido
        private DevExpress.XtraEditors.TextEdit txtBFirstName;             // Textbox unang ngalan
        private DevExpress.XtraEditors.TextEdit txtBStudentId;             // Textbox Student ID
        private DevExpress.XtraEditors.DateEdit Date;                      // Para sa petsa
        private DevExpress.XtraEditors.SimpleButton btnUpload;             // Buton upload litrato
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;   // Nag-organisar sa layout
        private System.Windows.Forms.Label label1;                         // Label Student ID
        private System.Windows.Forms.Label label2;                         // Label Firstname
        private System.Windows.Forms.Label label3;                         // Label Lastname
        private System.Windows.Forms.Label label4;                         // Label Section
        private System.Windows.Forms.Label label5;                         // Label Date
        private System.Windows.Forms.Label label6;                         // Label litrato
        private System.Windows.Forms.ComboBox cbSection;                   // Dropdown seksyon
        private DevExpress.XtraEditors.PanelControl panelControl1;        // Panel sa grid
    }
}