namespace Task_Management_System.Usercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDashboardUC));
            panelToolbar = new DevExpress.XtraEditors.PanelControl();
            cmbSection = new DevExpress.XtraEditors.ComboBoxEdit();
            btnExportPDF = new DevExpress.XtraEditors.SimpleButton();
            documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)panelToolbar).BeginInit();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSection.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelToolbar
            // 
            panelToolbar.Controls.Add(cmbSection);
            panelToolbar.Controls.Add(btnExportPDF);
            panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            panelToolbar.Location = new System.Drawing.Point(0, 0);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Size = new System.Drawing.Size(856, 66);
            panelToolbar.TabIndex = 0;
            // 
            // cmbSection
            // 
            cmbSection.EditValue = "Sections";
            cmbSection.Location = new System.Drawing.Point(620, 22);
            cmbSection.Name = "cmbSection";
            cmbSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbSection.Size = new System.Drawing.Size(195, 20);
            cmbSection.TabIndex = 2;
            cmbSection.SelectedIndexChanged += cmbSection_SelectedIndexChanged;
            // 
            // btnExportPDF
            // 
            btnExportPDF.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnExportPDF.ImageOptions.SvgImage");
            btnExportPDF.Location = new System.Drawing.Point(84, 15);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new System.Drawing.Size(127, 33);
            btnExportPDF.TabIndex = 1;
            btnExportPDF.Text = "Export PDF";
            // 
            // documentViewer1
            // 
            documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            documentViewer1.IsMetric = false;
            documentViewer1.Location = new System.Drawing.Point(0, 66);
            documentViewer1.Name = "documentViewer1";
            documentViewer1.Size = new System.Drawing.Size(856, 502);
            documentViewer1.TabIndex = 1;
            // 
            // ReportDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(documentViewer1);
            Controls.Add(panelToolbar);
            Name = "ReportDashboardUC";
            Size = new System.Drawing.Size(856, 568);
            ((System.ComponentModel.ISupportInitialize)panelToolbar).EndInit();
            panelToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbSection.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelToolbar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSection;
        private DevExpress.XtraEditors.SimpleButton btnExportPDF;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}
