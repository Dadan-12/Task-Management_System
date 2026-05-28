using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Dashboard;
using Task_Management_System.Data;

namespace Task_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Initializes tables and seeds default user accounts
                DatabaseContext.InitializeDatabaseSchema();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 🎯 FIXED: Parameter removed to match your 0-argument form constructor cleanly
            Application.Run(new LoginDashboard());
        }
    }
}