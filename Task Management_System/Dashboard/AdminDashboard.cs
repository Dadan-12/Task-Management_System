using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Task_Management_System.Usercontrol;

namespace Task_Management_System.Dashboards
{
    public partial class AdminDashboard : XtraForm
    {
        AdminDashboardUC dashboardUC = new AdminDashboardUC();
        AdminScheduleUC AdminScheduleUC = new AdminScheduleUC();
        RegisterDashboardUC registerUC = new RegisterDashboardUC();
        ReportDashboardUC reportDashboardUC = new ReportDashboardUC();

        public AdminDashboard(string user)
        {
            InitializeComponent();
            panelDashboard.Controls.Add(dashboardUC);
            panelDashboard.Controls.Add(AdminScheduleUC);
            panelDashboard.Controls.Add(registerUC);
            panelDashboard.Controls.Add(reportDashboardUC);
            dashboardUC.Dock = DockStyle.Fill;
            AdminScheduleUC.Dock = DockStyle.Fill;
            registerUC.Dock = DockStyle.Fill;
            reportDashboardUC.Dock = DockStyle.Fill;
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

        private void acSchedule_Click(object sender, EventArgs e)
        {
           AdminScheduleUC.BringToFront();
        }
        private void acReport_Click(object sender, EventArgs e)
        {
           reportDashboardUC.BringToFront();
        }
    }
}