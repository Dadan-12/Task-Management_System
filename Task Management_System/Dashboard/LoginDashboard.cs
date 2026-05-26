using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Data;
using Task_Management_System.Models;

namespace Task_Management_System.Dashboards
{
    public partial class LoginDashboard : DevExpress.XtraEditors.XtraForm
    {
        DataBase db = new DataBase();

        public LoginDashboard()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqliteConnection con = db.GetConnection())
            {
                try
                {
                    con.Open();
                    string username = txtBoxUsername.Text;
                    string password = txtBoxPassword.Text;
                    string query = @"SELECT * FROM User
                              WHERE Username=@Username
                              AND Password=@Password";
                    SqliteCommand command = new SqliteCommand(query, con);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    SqliteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        XtraMessageBox.Show("Login Successfully!");
                        AdminDashboard dashboard = new AdminDashboard(username);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        XtraMessageBox.Show("Invalid Username or Password!");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}