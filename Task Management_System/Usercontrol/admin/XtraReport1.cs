using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Dapper;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.admin
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        // 📍 MASTER HYDRATION PIPELINE: Extracts and sorts the entire master dataset for massive batch printing runs
        public void LoadReportData()
        {
            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    const string query = @"
                        SELECT Student_Id, FirstName, LastName, Section, Date 
                        FROM Admin 
                        ORDER BY Section ASC, Student_Id ASC;";

                    var dataRecords = db.Query<dynamic>(query);

                    this.DataSource = dataRecords;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Report engine hydration failure tracking exception: {ex.Message}");
            }
        }

        // 📍 FILTERED SINGLE HYDRATION OVERLOAD: Isolates database queries down to a single student profile parameters payload
        public void LoadSingleStudentReport(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId)) return;

            try
            {
                using (IDbConnection db = DatabaseContext.CreateConnection())
                {
                    const string query = @"
                        SELECT Student_Id, FirstName, LastName, Section, Date 
                        FROM Admin 
                        WHERE Student_Id = @StudentId 
                        LIMIT 1;";

                    var dataRecord = db.Query<dynamic>(query, new { StudentId = studentId });
                    this.DataSource = dataRecord;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Single profile report execution failure anomaly: {ex.Message}");
            }
        }
    }
}