namespace Task_Management_System.Usercontrol
{
    partial class RegisterUC
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            label5 = new System.Windows.Forms.Label();
            txtBFirstName = new System.Windows.Forms.TextBox();
            btnUpload = new DevExpress.XtraEditors.SimpleButton();
            label4 = new System.Windows.Forms.Label();
            PicBox = new System.Windows.Forms.PictureBox();
            DatePicker = new System.Windows.Forms.DateTimePicker();
            btnRegister = new DevExpress.XtraEditors.SimpleButton();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtBLastname = new System.Windows.Forms.TextBox();
            txtBStudentId = new System.Windows.Forms.TextBox();
            cbSection = new System.Windows.Forms.ComboBox();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            MainViewDashboard = new DevExpress.XtraGrid.GridControl();
            gvDashboard = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(label5);
            groupControl1.Controls.Add(txtBFirstName);
            groupControl1.Controls.Add(btnUpload);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(PicBox);
            groupControl1.Controls.Add(DatePicker);
            groupControl1.Controls.Add(btnRegister);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(label1);
            groupControl1.Controls.Add(txtBLastname);
            groupControl1.Controls.Add(txtBStudentId);
            groupControl1.Controls.Add(cbSection);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(830, 268);
            groupControl1.TabIndex = 11;
            groupControl1.Text = "groupControl1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(75, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 13);
            label5.TabIndex = 26;
            label5.Text = "Lastname:";
            // 
            // txtBFirstName
            // 
            txtBFirstName.Location = new System.Drawing.Point(138, 95);
            txtBFirstName.Name = "txtBFirstName";
            txtBFirstName.Size = new System.Drawing.Size(198, 21);
            txtBFirstName.TabIndex = 25;
            // 
            // btnUpload
            // 
            btnUpload.Location = new System.Drawing.Point(660, 189);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(132, 41);
            btnUpload.TabIndex = 24;
            btnUpload.Text = "Upload";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(358, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(34, 13);
            label4.TabIndex = 23;
            label4.Text = "Date:";
            // 
            // PicBox
            // 
            PicBox.Location = new System.Drawing.Point(660, 37);
            PicBox.Name = "PicBox";
            PicBox.Size = new System.Drawing.Size(132, 124);
            PicBox.TabIndex = 22;
            PicBox.TabStop = false;
            // 
            // DatePicker
            // 
            DatePicker.Location = new System.Drawing.Point(410, 95);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new System.Drawing.Size(198, 21);
            DatePicker.TabIndex = 21;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(459, 177);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(103, 34);
            btnRegister.TabIndex = 20;
            btnRegister.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(358, 41);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 18;
            label3.Text = "Section:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 19;
            label2.Text = "Fullname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(70, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 17;
            label1.Text = "Student Id:";
            // 
            // txtBLastname
            // 
            txtBLastname.Location = new System.Drawing.Point(138, 152);
            txtBLastname.Name = "txtBLastname";
            txtBLastname.Size = new System.Drawing.Size(198, 21);
            txtBLastname.TabIndex = 16;
            // 
            // txtBStudentId
            // 
            txtBStudentId.Location = new System.Drawing.Point(138, 38);
            txtBStudentId.Name = "txtBStudentId";
            txtBStudentId.Size = new System.Drawing.Size(198, 21);
            txtBStudentId.TabIndex = 14;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Items.AddRange(new object[] { "Babbage", "Pascal" });
            cbSection.Location = new System.Drawing.Point(410, 37);
            cbSection.Name = "cbSection";
            cbSection.Size = new System.Drawing.Size(198, 21);
            cbSection.TabIndex = 15;
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(MainViewDashboard);
            groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            groupControl2.Location = new System.Drawing.Point(0, 248);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(830, 290);
            groupControl2.TabIndex = 12;
            groupControl2.Text = "groupControl2";
            // 
            // MainViewDashboard
            // 
            MainViewDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            MainViewDashboard.Location = new System.Drawing.Point(2, 26);
            MainViewDashboard.MainView = gvDashboard;
            MainViewDashboard.Name = "MainViewDashboard";
            MainViewDashboard.Size = new System.Drawing.Size(826, 262);
            MainViewDashboard.TabIndex = 11;
            MainViewDashboard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDashboard, gridView1 });
            // 
            // gvDashboard
            // 
            gvDashboard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
            gvDashboard.GridControl = MainViewDashboard;
            gvDashboard.Name = "gvDashboard";
            gvDashboard.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 35;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Photo";
            gridColumn2.FieldName = "picture";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 110;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Student ID";
            gridColumn3.FieldName = "Student_Id";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 110;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Firstname";
            gridColumn4.FieldName = "FirstName";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 110;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Lastname";
            gridColumn5.FieldName = "LastName";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 110;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "Section";
            gridColumn6.FieldName = "Section";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            gridColumn6.Width = 110;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Date";
            gridColumn7.FieldName = "Date";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            gridColumn7.Width = 121;
            // 
            // gridView1
            // 
            gridView1.GridControl = MainViewDashboard;
            gridView1.Name = "gridView1";
            // 
            // RegisterUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "RegisterUC";
            Size = new System.Drawing.Size(830, 538);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainViewDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBFirstName;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBLastname;
        private System.Windows.Forms.TextBox txtBStudentId;
        private System.Windows.Forms.ComboBox cbSection;
        private DevExpress.XtraEditors.GroupControl groupControl2;
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
    }
}
