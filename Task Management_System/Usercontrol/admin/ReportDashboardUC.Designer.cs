namespace Task_Management_System.Usercontrol.admin
{
    partial class ReportDashboardUC
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
            this.panelToolbar = new DevExpress.XtraEditors.PanelControl();
            this.cmbSection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnExportPDF = new DevExpress.XtraEditors.SimpleButton();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelToolbar)).BeginInit();
            this.panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSection.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.cmbSection);
            this.panelToolbar.Controls.Add(this.btnExportPDF);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(850, 50);
            this.panelToolbar.TabIndex = 0;
            // 
            // cmbSection
            // 
            this.cmbSection.Location = new System.Drawing.Point(15, 14);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.Properties.Appearance.Options.UseFont = true;
            this.cmbSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSection.Size = new System.Drawing.Size(180, 24);
            this.cmbSection.TabIndex = 0;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.Appearance.Options.UseFont = true;
            this.btnExportPDF.Location = new System.Drawing.Point(210, 10);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(130, 30);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 50);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(850, 500);
            this.documentViewer1.TabIndex = 1;
            // 
            // ReportDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.panelToolbar);
            this.Name = "ReportDashboardUC";
            this.Size = new System.Drawing.Size(850, 550);
            ((System.ComponentModel.ISupportInitialize)(this.panelToolbar)).EndInit();
            this.panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSection.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelToolbar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSection;
        private DevExpress.XtraEditors.SimpleButton btnExportPDF;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}