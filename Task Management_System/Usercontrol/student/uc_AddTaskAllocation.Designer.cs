namespace Task_Management_System.Usercontrol.student
{
    partial class uc_AddTaskAllocation
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
            lblHeaderTitle = new DevExpress.XtraEditors.LabelControl();
            labelSubject = new DevExpress.XtraEditors.LabelControl();
            txtSubject = new DevExpress.XtraEditors.TextEdit();
            labelDescription = new DevExpress.XtraEditors.LabelControl();
            txtDescription = new DevExpress.XtraEditors.MemoEdit();
            labelLocation = new DevExpress.XtraEditors.LabelControl();
            txtLocation = new DevExpress.XtraEditors.TextEdit();
            labelStart = new DevExpress.XtraEditors.LabelControl();
            dateEditStart = new DevExpress.XtraEditors.DateEdit();
            labelEnd = new DevExpress.XtraEditors.LabelControl();
            dateEditEnd = new DevExpress.XtraEditors.DateEdit();
            labelLabel = new DevExpress.XtraEditors.LabelControl();
            comboLabel = new DevExpress.XtraEditors.ComboBoxEdit();
            labelStatus = new DevExpress.XtraEditors.LabelControl();
            comboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            chkAllDay = new DevExpress.XtraEditors.CheckEdit();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtSubject.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditStart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditStart.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditEnd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditEnd.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboLabel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkAllDay.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblHeaderTitle.Appearance.Options.UseFont = true;
            lblHeaderTitle.Location = new System.Drawing.Point(43, 29);
            lblHeaderTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new System.Drawing.Size(478, 50);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "➕ Add New Task Allocation";
            // 
            // labelSubject
            // 
            labelSubject.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelSubject.Appearance.Options.UseFont = true;
            labelSubject.Location = new System.Drawing.Point(43, 110);
            labelSubject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new System.Drawing.Size(139, 35);
            labelSubject.TabIndex = 1;
            labelSubject.Text = "Subject Title:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new System.Drawing.Point(43, 147);
            txtSubject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtSubject.Name = "txtSubject";
            txtSubject.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSubject.Properties.Appearance.Options.UseFont = true;
            txtSubject.Size = new System.Drawing.Size(943, 52);
            txtSubject.TabIndex = 2;
            // 
            // labelDescription
            // 
            labelDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelDescription.Appearance.Options.UseFont = true;
            labelDescription.Location = new System.Drawing.Point(43, 213);
            labelDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(132, 35);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(43, 250);
            txtDescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDescription.Properties.Appearance.Options.UseFont = true;
            txtDescription.Size = new System.Drawing.Size(943, 132);
            txtDescription.TabIndex = 4;
            // 
            // labelLocation
            // 
            labelLocation.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelLocation.Appearance.Options.UseFont = true;
            labelLocation.Location = new System.Drawing.Point(43, 404);
            labelLocation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new System.Drawing.Size(100, 35);
            labelLocation.TabIndex = 5;
            labelLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new System.Drawing.Point(43, 441);
            txtLocation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtLocation.Properties.Appearance.Options.UseFont = true;
            txtLocation.Size = new System.Drawing.Size(943, 52);
            txtLocation.TabIndex = 6;
            // 
            // labelStart
            // 
            labelStart.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelStart.Appearance.Options.UseFont = true;
            labelStart.Location = new System.Drawing.Point(43, 507);
            labelStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelStart.Name = "labelStart";
            labelStart.Size = new System.Drawing.Size(179, 35);
            labelStart.TabIndex = 7;
            labelStart.Text = "Start Date/Time:";
            // 
            // dateEditStart
            // 
            dateEditStart.EditValue = null;
            dateEditStart.Location = new System.Drawing.Point(43, 544);
            dateEditStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateEditStart.Name = "dateEditStart";
            dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            dateEditStart.Properties.Appearance.Options.UseFont = true;
            dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditStart.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            dateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditStart.Properties.DisplayFormat.FormatString = "g";
            dateEditStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditStart.Properties.EditFormat.FormatString = "g";
            dateEditStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditStart.Properties.MaskSettings.Set("mask", "g");
            dateEditStart.Size = new System.Drawing.Size(446, 52);
            dateEditStart.TabIndex = 8;
            // 
            // labelEnd
            // 
            labelEnd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelEnd.Appearance.Options.UseFont = true;
            labelEnd.Location = new System.Drawing.Point(540, 507);
            labelEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new System.Drawing.Size(170, 35);
            labelEnd.TabIndex = 9;
            labelEnd.Text = "End Date/Time:";
            // 
            // dateEditEnd
            // 
            dateEditEnd.EditValue = null;
            dateEditEnd.Location = new System.Drawing.Point(540, 544);
            dateEditEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateEditEnd.Name = "dateEditEnd";
            dateEditEnd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            dateEditEnd.Properties.Appearance.Options.UseFont = true;
            dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditEnd.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            dateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditEnd.Properties.DisplayFormat.FormatString = "g";
            dateEditEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditEnd.Properties.EditFormat.FormatString = "g";
            dateEditEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            dateEditEnd.Properties.MaskSettings.Set("mask", "g");
            dateEditEnd.Size = new System.Drawing.Size(446, 52);
            dateEditEnd.TabIndex = 10;
            // 
            // labelLabel
            // 
            labelLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelLabel.Appearance.Options.UseFont = true;
            labelLabel.Location = new System.Drawing.Point(43, 610);
            labelLabel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new System.Drawing.Size(84, 35);
            labelLabel.TabIndex = 11;
            labelLabel.Text = "Priority:";
            // 
            // comboLabel
            // 
            comboLabel.Location = new System.Drawing.Point(43, 647);
            comboLabel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboLabel.Name = "comboLabel";
            comboLabel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            comboLabel.Properties.Appearance.Options.UseFont = true;
            comboLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboLabel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboLabel.Size = new System.Drawing.Size(446, 52);
            comboLabel.TabIndex = 12;
            // 
            // labelStatus
            // 
            labelStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            labelStatus.Appearance.Options.UseFont = true;
            labelStatus.Location = new System.Drawing.Point(540, 610);
            labelStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(128, 35);
            labelStatus.TabIndex = 13;
            labelStatus.Text = "Task Status:";
            // 
            // comboStatus
            // 
            comboStatus.Location = new System.Drawing.Point(540, 647);
            comboStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            comboStatus.Properties.Appearance.Options.UseFont = true;
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboStatus.Size = new System.Drawing.Size(446, 52);
            comboStatus.TabIndex = 14;
            // 
            // chkAllDay
            // 
            chkAllDay.Location = new System.Drawing.Point(43, 713);
            chkAllDay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            chkAllDay.Name = "chkAllDay";
            chkAllDay.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            chkAllDay.Properties.Appearance.Options.UseFont = true;
            chkAllDay.Properties.Caption = "All Day Event Allocation";
            chkAllDay.Size = new System.Drawing.Size(343, 43);
            chkAllDay.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnSave.Appearance.Options.UseFont = true;
            btnSave.Location = new System.Drawing.Point(523, 787);
            btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(223, 59);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save Allocation";
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new System.Drawing.Point(763, 787);
            btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(223, 59);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.Click += BtnCancel_Click;
            // 
            // uc_AddTaskAllocation
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblHeaderTitle);
            Controls.Add(labelSubject);
            Controls.Add(txtSubject);
            Controls.Add(labelDescription);
            Controls.Add(txtDescription);
            Controls.Add(labelLocation);
            Controls.Add(txtLocation);
            Controls.Add(labelStart);
            Controls.Add(dateEditStart);
            Controls.Add(labelEnd);
            Controls.Add(dateEditEnd);
            Controls.Add(labelLabel);
            Controls.Add(comboLabel);
            Controls.Add(labelStatus);
            Controls.Add(comboStatus);
            Controls.Add(chkAllDay);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "uc_AddTaskAllocation";
            Size = new System.Drawing.Size(1029, 882);
            ((System.ComponentModel.ISupportInitialize)txtSubject.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLocation.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditStart.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditStart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditEnd.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditEnd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboLabel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkAllDay.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblHeaderTitle;
        private DevExpress.XtraEditors.LabelControl labelSubject;
        private DevExpress.XtraEditors.TextEdit txtSubject;
        private DevExpress.XtraEditors.LabelControl labelDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelLocation;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraEditors.LabelControl labelStart;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private DevExpress.XtraEditors.LabelControl labelEnd;
        private DevExpress.XtraEditors.DateEdit dateEditEnd;
        private DevExpress.XtraEditors.LabelControl labelLabel;
        private DevExpress.XtraEditors.ComboBoxEdit comboLabel;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.ComboBoxEdit comboStatus;
        private DevExpress.XtraEditors.CheckEdit chkAllDay;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}