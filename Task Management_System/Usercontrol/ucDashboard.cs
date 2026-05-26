using Dapper;
using DevExpress.XtraEditors;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class AdminDashboardUC : XtraUserControl
    {
        DataBase db = new DataBase();

        public AdminDashboardUC()
        {
            InitializeComponent();
            LoadData();
        }

        // LOAD DATABASE TO GRID
        public void LoadData()
        {
            using (SqliteConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM Admin";
                var result = con.Query(query).ToList();
                DataTable dt = new DataTable();
                if (result.Count > 0)
                {
                    var first = (IDictionary<string, object>)result[0];
                    foreach (var key in first.Keys)
                        dt.Columns.Add(key);
                    foreach (var row in result)
                    {
                        var dict = (IDictionary<string, object>)row;
                        dt.Rows.Add(dict.Values.ToArray());
                    }
                }
                MainViewDashboard.DataSource = dt;
            }
        }
    }
}