using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Task_Management_System.Usercontrol;

namespace Task_Management_System.Dashboards
{
    public partial class AdminDashboard : XtraForm
    {
        AdminDashboardUC dashboardUC = new AdminDashboardUC();
        RegisterDashboardUC registerUC = new RegisterDashboardUC();

        public AdminDashboard(string user)
        {
            InitializeComponent();
            panelDashboard.Controls.Add(dashboardUC);
            panelDashboard.Controls.Add(registerUC);
            dashboardUC.Dock = DockStyle.Fill;
            registerUC.Dock = DockStyle.Fill;
            dashboardUC.BringToFront();
        }

        private void acDashboard_Click(object sender, EventArgs e)
        {
            dashboardUC.BringToFront();
        }

        private void acRegister_Click(object sender, EventArgs e)
        {
            registerUC.BringToFront();
        }

        private void acReport_Click(object sender, EventArgs e)
        {
            // report page here
        }
    }
}