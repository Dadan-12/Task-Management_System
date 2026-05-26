namespace Task_Management_System.Usercontrol
{
    partial class StudentDashboardUC
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
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            SuspendLayout();
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Element1";
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new System.Drawing.Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new System.Drawing.Size(120, 554);
            accordionControl1.TabIndex = 24;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // StudentDashboardUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(accordionControl1);
            Name = "StudentDashboardUC";
            Size = new System.Drawing.Size(804, 554);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
    }
}
