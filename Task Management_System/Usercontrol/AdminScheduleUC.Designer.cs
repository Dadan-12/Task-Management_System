namespace Task_Management_System.Usercontrol
{
    partial class AdminScheduleUC
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler7 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler8 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler9 = new DevExpress.XtraScheduler.TimeRuler();
            schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            storageSection1 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            storageSection2 = new DevExpress.XtraScheduler.SchedulerDataStorage(components);
            xtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPageA = new DevExpress.XtraTab.XtraTabPage();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            cbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tFrom = new DevExpress.XtraEditors.TimeEdit();
            label4 = new System.Windows.Forms.Label();
            tTo = new DevExpress.XtraEditors.TimeEdit();
            label3 = new System.Windows.Forms.Label();
            dtFrom = new DevExpress.XtraScheduler.DateNavigator();
            xtraTabPage2 = new DevExpress.XtraScheduler.SchedulerControl();
            btnAdd = new System.Windows.Forms.Button();
            xtraTabPageN = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage1 = new DevExpress.XtraScheduler.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageSection1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageSection2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbSubject.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPageN).BeginInit();
            xtraTabPageN.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage1).BeginInit();
            SuspendLayout();
            // 
            // schedulerDataStorage1
            // 
            // 
            // 
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            schedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            schedulerDataStorage1.Appointments.Mappings.End = "EndTime";
            schedulerDataStorage1.Appointments.Mappings.Start = "StartTime";
            schedulerDataStorage1.Appointments.Mappings.Subject = "Title";
            // 
            // storageSection1
            // 
            // 
            // 
            // 
            storageSection1.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            storageSection1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            storageSection1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            storageSection1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            storageSection1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            storageSection1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            storageSection1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            storageSection1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            storageSection1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            storageSection1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            storageSection1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            storageSection1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            // 
            // storageSection2
            // 
            // 
            // 
            // 
            storageSection2.AppointmentDependencies.AutoReload = false;
            // 
            // 
            // 
            storageSection2.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window);
            storageSection2.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(255, 194, 190));
            storageSection2.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(168, 213, 255));
            storageSection2.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(193, 244, 156));
            storageSection2.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(243, 228, 199));
            storageSection2.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(244, 206, 147));
            storageSection2.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(199, 244, 255));
            storageSection2.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(207, 219, 152));
            storageSection2.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(224, 207, 233));
            storageSection2.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(141, 233, 223));
            storageSection2.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(255, 247, 165));
            // 
            // xtraTabPage
            // 
            xtraTabPage.Name = "xtraTabPage";
            xtraTabPage.Size = new System.Drawing.Size(721, 509);
            // 
            // xtraTabPageA
            // 
            xtraTabPageA.Name = "xtraTabPageA";
            xtraTabPageA.Size = new System.Drawing.Size(721, 509);
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(tableLayoutPanel1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            panelControl1.Location = new System.Drawing.Point(748, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(228, 596);
            panelControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            tableLayoutPanel1.Controls.Add(cbSubject, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tFrom, 0, 7);
            tableLayoutPanel1.Controls.Add(label4, 0, 8);
            tableLayoutPanel1.Controls.Add(tTo, 0, 9);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(dtFrom, 0, 6);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 10);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.0677948F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.9322052F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tableLayoutPanel1.Size = new System.Drawing.Size(224, 592);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cbSubject
            // 
            cbSubject.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbSubject.Location = new System.Drawing.Point(3, 62);
            cbSubject.Name = "cbSubject";
            cbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbSubject.Size = new System.Drawing.Size(218, 20);
            cbSubject.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 7;
            label2.Text = "Subject:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 6;
            label1.Text = "Section:";
            // 
            // tFrom
            // 
            tFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            tFrom.EditValue = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            tFrom.Location = new System.Drawing.Point(3, 374);
            tFrom.Name = "tFrom";
            tFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tFrom.Size = new System.Drawing.Size(218, 20);
            tFrom.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 401);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 13);
            label4.TabIndex = 9;
            label4.Text = "To:";
            // 
            // tTo
            // 
            tTo.Dock = System.Windows.Forms.DockStyle.Fill;
            tTo.EditValue = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            tTo.Location = new System.Drawing.Point(3, 420);
            tTo.Name = "tTo";
            tTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tTo.Size = new System.Drawing.Size(218, 20);
            tTo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 13);
            label3.TabIndex = 8;
            label3.Text = "From:";
            // 
            // dtFrom
            // 
            dtFrom.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            dtFrom.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            dtFrom.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtFrom.DateTime = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            dtFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            dtFrom.EditValue = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            dtFrom.FirstDayOfWeek = System.DayOfWeek.Sunday;
            dtFrom.Location = new System.Drawing.Point(3, 102);
            dtFrom.Name = "dtFrom";
            dtFrom.SchedulerControl = xtraTabPage2;
            dtFrom.Size = new System.Drawing.Size(218, 266);
            dtFrom.TabIndex = 10;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            xtraTabPage2.DataStorage = schedulerDataStorage1;
            xtraTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPage2.Location = new System.Drawing.Point(0, 0);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(746, 571);
            xtraTabPage2.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            xtraTabPage2.TabIndex = 1;
            xtraTabPage2.Text = "schedulerControl2";
            xtraTabPage2.Views.AgendaView.Enabled = false;
            xtraTabPage2.Views.DayView.Enabled = false;
            xtraTabPage2.Views.DayView.TimeRulers.Add(timeRuler1);
            xtraTabPage2.Views.FullWeekView.Enabled = true;
            xtraTabPage2.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            xtraTabPage2.Views.GanttView.Enabled = false;
            xtraTabPage2.Views.MonthView.Enabled = false;
            xtraTabPage2.Views.TimelineView.Enabled = false;
            xtraTabPage2.Views.WeekView.Enabled = false;
            xtraTabPage2.Views.WorkWeekView.Enabled = false;
            xtraTabPage2.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            xtraTabPage2.Views.YearView.UseOptimizedScrolling = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAdd.Location = new System.Drawing.Point(3, 477);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(218, 44);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // xtraTabPageN
            // 
            xtraTabPageN.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPageN.Location = new System.Drawing.Point(0, 0);
            xtraTabPageN.Name = "xtraTabPageN";
            xtraTabPageN.SelectedTabPage = xtraTabPage3;
            xtraTabPageN.Size = new System.Drawing.Size(748, 596);
            xtraTabPageN.TabIndex = 0;
            xtraTabPageN.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage3, xtraTabPage4 });
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(schedulerControl1);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new System.Drawing.Size(746, 571);
            xtraTabPage3.Text = "NEUMANN";
            // 
            // schedulerControl1
            // 
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 0);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(746, 571);
            schedulerControl1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            schedulerControl1.TabIndex = 0;
            schedulerControl1.Text = "schedulerControl1";
            schedulerControl1.Views.AgendaView.Enabled = false;
            schedulerControl1.Views.DayView.Enabled = false;
            schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            schedulerControl1.Views.FullWeekView.Enabled = true;
            schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            schedulerControl1.Views.GanttView.Enabled = false;
            schedulerControl1.Views.MonthView.Enabled = false;
            schedulerControl1.Views.TimelineView.Enabled = false;
            schedulerControl1.Views.WeekView.Enabled = false;
            schedulerControl1.Views.WorkWeekView.Enabled = false;
            schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            schedulerControl1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(xtraTabPage2);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new System.Drawing.Size(746, 571);
            xtraTabPage4.Text = "AIKEN";
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            xtraTabPage1.DataStorage = schedulerDataStorage1;
            xtraTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPage1.Location = new System.Drawing.Point(1, 24);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(746, 571);
            xtraTabPage1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            xtraTabPage1.TabIndex = 2;
            xtraTabPage1.Text = "schedulerControl1";
            xtraTabPage1.Views.AgendaView.Enabled = false;
            xtraTabPage1.Views.DayView.Enabled = false;
            xtraTabPage1.Views.DayView.TimeRulers.Add(timeRuler7);
            xtraTabPage1.Views.FullWeekView.Enabled = true;
            xtraTabPage1.Views.FullWeekView.TimeRulers.Add(timeRuler8);
            xtraTabPage1.Views.GanttView.Enabled = false;
            xtraTabPage1.Views.MonthView.Enabled = false;
            xtraTabPage1.Views.TimelineView.Enabled = false;
            xtraTabPage1.Views.WeekView.Enabled = false;
            xtraTabPage1.Views.WorkWeekView.Enabled = false;
            xtraTabPage1.Views.WorkWeekView.TimeRulers.Add(timeRuler9);
            xtraTabPage1.Views.YearView.UseOptimizedScrolling = false;
            // 
            // AdminScheduleUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(xtraTabPageN);
            Controls.Add(panelControl1);
            Name = "AdminScheduleUC";
            Size = new System.Drawing.Size(976, 596);
            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)storageSection1).EndInit();
            ((System.ComponentModel.ISupportInitialize)storageSection2).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbSubject.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPageN).EndInit();
            xtraTabPageN.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabPage1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.SchedulerDataStorage storageSection1;
        private DevExpress.XtraScheduler.SchedulerDataStorage storageSection2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageA;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabPageN;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSubject;
        private DevExpress.XtraEditors.TimeEdit tFrom;
        private DevExpress.XtraEditors.TimeEdit tTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraScheduler.SchedulerControl xtraTabPage2;
        private DevExpress.XtraScheduler.DateNavigator dtFrom;
        private DevExpress.XtraScheduler.SchedulerControl xtraTabPage1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    }
}
