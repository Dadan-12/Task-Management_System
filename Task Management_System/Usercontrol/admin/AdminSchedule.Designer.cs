using System.Windows.Controls;
using System.Windows.Forms;

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

            xtraTabPageN = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabPage2 = new DevExpress.XtraScheduler.SchedulerControl();
            xtraTabPage1 = new DevExpress.XtraScheduler.SchedulerControl();

            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            dataLayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            lblSection = new DevExpress.XtraEditors.LabelControl();
            lblSubject = new DevExpress.XtraEditors.LabelControl();
            cbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            lblFrom = new DevExpress.XtraEditors.LabelControl();
            dtFrom = new DevExpress.XtraScheduler.DateNavigator();
            tFrom = new DevExpress.XtraEditors.TimeEdit();
            lblTo = new DevExpress.XtraEditors.LabelControl();
            tTo = new DevExpress.XtraEditors.TimeEdit();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();

            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();

            ((System.ComponentModel.ISupportInitialize)schedulerDataStorage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageSection1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageSection2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPageN).BeginInit();
            xtraTabPageN.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).BeginInit();
            xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbSubject.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tFrom.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tTo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            SuspendLayout();

            // 
            // schedulerDataStorage1
            // 
            schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
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
            storageSection1.AppointmentDependencies.AutoReload = false;

            // 
            // storageSection2
            // 
            storageSection2.AppointmentDependencies.AutoReload = false;

            // 
            // xtraTabPageN
            // 
            xtraTabPageN.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPageN.Location = new System.Drawing.Point(0, 0);
            xtraTabPageN.Name = "xtraTabPageN";
            xtraTabPageN.SelectedTabPage = xtraTabPage3;
            xtraTabPageN.Size = new System.Drawing.Size(718, 596);
            xtraTabPageN.TabIndex = 0;
            xtraTabPageN.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage3, xtraTabPage4 });

            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(schedulerControl1);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new System.Drawing.Size(716, 571);
            xtraTabPage3.Text = "NEUMANN";

            // 
            // schedulerControl1
            // 
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            schedulerControl1.DataStorage = schedulerDataStorage1;
            schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            schedulerControl1.Location = new System.Drawing.Point(0, 0);
            schedulerControl1.Name = "schedulerControl1";
            schedulerControl1.Size = new System.Drawing.Size(716, 571);
            schedulerControl1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            schedulerControl1.TabIndex = 0;
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

            // 
            // xtraTabPage4
            // 
            xtraTabPage4.Controls.Add(xtraTabPage2);
            xtraTabPage4.Name = "xtraTabPage4";
            xtraTabPage4.Size = new System.Drawing.Size(716, 571);
            xtraTabPage4.Text = "AIKEN";

            // 
            // xtraTabPage2
            // 
            xtraTabPage2.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            xtraTabPage2.DataStorage = schedulerDataStorage1;
            xtraTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPage2.Location = new System.Drawing.Point(0, 0);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(716, 571);
            xtraTabPage2.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            xtraTabPage2.TabIndex = 1;
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

            // 
            // xtraTabPage1
            // 
            xtraTabPage1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.FullWeek;
            xtraTabPage1.DataStorage = schedulerDataStorage1;
            xtraTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabPage1.Location = new System.Drawing.Point(0, 0);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(716, 571);
            xtraTabPage1.Start = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            xtraTabPage1.TabIndex = 2;
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

            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(dataLayoutControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            panelControl1.Location = new System.Drawing.Point(718, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(258, 596);
            panelControl1.TabIndex = 1;

            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(lblSection);
            dataLayoutControl1.Controls.Add(lblSubject);
            dataLayoutControl1.Controls.Add(cbSubject);
            dataLayoutControl1.Controls.Add(lblFrom);
            dataLayoutControl1.Controls.Add(dtFrom);
            dataLayoutControl1.Controls.Add(tFrom);
            dataLayoutControl1.Controls.Add(lblTo);
            dataLayoutControl1.Controls.Add(tTo);
            dataLayoutControl1.Controls.Add(btnAdd);
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(2, 2);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.Root = layoutControlGroup1;
            dataLayoutControl1.Size = new System.Drawing.Size(254, 592);
            dataLayoutControl1.TabIndex = 0;

            // 
            // lblSection
            // 
            lblSection.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            lblSection.Appearance.Options.UseFont = true;
            lblSection.Location = new System.Drawing.Point(12, 12);
            lblSection.Name = "lblSection";
            lblSection.Size = new System.Drawing.Size(230, 13);
            lblSection.StyleController = dataLayoutControl1;
            lblSection.TabIndex = 0;
            lblSection.Text = "Section:";

            // 
            // lblSubject
            // 
            lblSubject.Location = new System.Drawing.Point(12, 29);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new System.Drawing.Size(230, 13);
            lblSubject.StyleController = dataLayoutControl1;
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject:";

            // 
            // cbSubject
            // 
            cbSubject.Location = new System.Drawing.Point(12, 46);
            cbSubject.Name = "cbSubject";
            cbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cbSubject.Size = new System.Drawing.Size(230, 20);
            cbSubject.StyleController = dataLayoutControl1;
            cbSubject.TabIndex = 3;

            // 
            // lblFrom
            // 
            lblFrom.Location = new System.Drawing.Point(12, 70);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new System.Drawing.Size(230, 13);
            lblFrom.StyleController = dataLayoutControl1;
            lblFrom.TabIndex = 4;
            lblFrom.Text = "From:";

            // 
            // dtFrom
            // 
            dtFrom.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtFrom.DateTime = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            dtFrom.EditValue = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            dtFrom.Location = new System.Drawing.Point(12, 87);
            dtFrom.Name = "dtFrom";
            dtFrom.SchedulerControl = xtraTabPage2;
            dtFrom.Size = new System.Drawing.Size(230, 230);
            dtFrom.StyleController = dataLayoutControl1;
            dtFrom.TabIndex = 5;

            // 
            // tFrom
            // 
            tFrom.EditValue = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            tFrom.Location = new System.Drawing.Point(12, 321);
            tFrom.Name = "tFrom";
            tFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tFrom.Size = new System.Drawing.Size(230, 20);
            tFrom.StyleController = dataLayoutControl1;
            tFrom.TabIndex = 6;

            // 
            // lblTo
            // 
            lblTo.Location = new System.Drawing.Point(12, 345);
            lblTo.Name = "lblTo";
            lblTo.Size = new System.Drawing.Size(230, 13);
            lblTo.StyleController = dataLayoutControl1;
            lblTo.TabIndex = 7;
            lblTo.Text = "To:";

            // 
            // tTo
            // 
            tTo.EditValue = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            tTo.Location = new System.Drawing.Point(12, 362);
            tTo.Name = "tTo";
            tTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tTo.Size = new System.Drawing.Size(230, 20);
            tTo.StyleController = dataLayoutControl1;
            tTo.TabIndex = 8;

            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(230, 36);
            btnAdd.StyleController = dataLayoutControl1;
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add Schedule";
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4,
            layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8,
            layoutControlItem9});
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(254, 592);
            layoutControlGroup1.TextVisible = false;

            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = lblSection;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(234, 17);
            layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem1.TextVisible = false;

            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = lblSubject;
            layoutControlItem2.Location = new System.Drawing.Point(0, 17);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(234, 17);
            layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem2.TextVisible = false;

            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = cbSubject;
            layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(234, 24);
            layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem3.TextVisible = false;

            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = lblFrom;
            layoutControlItem4.Location = new System.Drawing.Point(0, 58);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(234, 17);
            layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem4.TextVisible = false;

            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = dtFrom;
            layoutControlItem5.Location = new System.Drawing.Point(0, 75);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(234, 234);
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;

            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = tFrom;
            layoutControlItem6.Location = new System.Drawing.Point(0, 309);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(234, 24);
            layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem6.TextVisible = false;

            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = lblTo;
            layoutControlItem7.Location = new System.Drawing.Point(0, 333);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(234, 17);
            layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem7.TextVisible = false;

            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = tTo;
            layoutControlItem8.Location = new System.Drawing.Point(0, 350);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new System.Drawing.Size(234, 24);
            layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem8.TextVisible = false;

            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = btnAdd;
            layoutControlItem9.Location = new System.Drawing.Point(0, 374);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new System.Drawing.Size(234, 198);
            layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem9.TextVisible = false;

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
            ((System.ComponentModel.ISupportInitialize)xtraTabPageN).EndInit();
            xtraTabPageN.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)schedulerControl1).EndInit();
            xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabPage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabPage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbSubject.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)tFrom.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tTo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraScheduler.SchedulerDataStorage storageSection1;
        private DevExpress.XtraScheduler.SchedulerDataStorage storageSection2;

        private DevExpress.XtraTab.XtraTabControl xtraTabPageN;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerControl xtraTabPage2;
        private DevExpress.XtraScheduler.SchedulerControl xtraTabPage1;

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

        private DevExpress.XtraEditors.LabelControl lblSection;
        private DevExpress.XtraEditors.LabelControl lblSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cbSubject;
        private DevExpress.XtraEditors.LabelControl lblFrom;
        private DevExpress.XtraScheduler.DateNavigator dtFrom;
        private DevExpress.XtraEditors.TimeEdit tFrom;
        private DevExpress.XtraEditors.LabelControl lblTo;
        private DevExpress.XtraEditors.TimeEdit tTo;
        private DevExpress.XtraEditors.SimpleButton btnAdd;

        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}