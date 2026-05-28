using Dapper;
using DevExpress.XtraReports.UI;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly DataBase db = new DataBase();

        public XtraReport1()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = @"SELECT 
                                        Student_Id, 
                                        FirstName, 
                                        LastName, 
                                        Section, 
                                        Date 
                                    FROM Admin";

                    var result = con.Query(query).ToList();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("Student_Id", typeof(string));
                    dt.Columns.Add("FirstName", typeof(string));
                    dt.Columns.Add("LastName", typeof(string));
                    dt.Columns.Add("Section", typeof(string));
                    dt.Columns.Add("Date", typeof(string));

                    foreach (var row in result)
                    {
                        var dict = (IDictionary<string, object>)row;
                        dt.Rows.Add(
                            dict["Student_Id"]?.ToString(),
                            dict["FirstName"]?.ToString(),
                            dict["LastName"]?.ToString(),
                            dict["Section"]?.ToString(),
                            dict["Date"]?.ToString()
                        );
                    }

                    this.DataSource = dt; // ✔ bind to report
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(
                    "Report error: " + ex.Message,
                    "Error", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}