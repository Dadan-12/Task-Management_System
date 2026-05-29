using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol.admin
{
    public partial class ReportDashboardUC : DevExpress.XtraEditors.XtraUserControl
    {
        // 📍 STORAGE STACK: Database reference context and structural remapping caches
        private readonly DataBase db = new DataBase();
        private DataTable reportData = new DataTable();

        public ReportDashboardUC()
        {
            InitializeComponent();

            LoadSections();
            LoadReport("All");
        }

        // 📍 DROP-DOWN POPULATION: Extracts distinct administrative section filters out of database tracking rows
        private void LoadSections()
        {
            try
            {
                using (var con = db.GetConnection())
                {
                    var sections = con.Query<string>(
                        "SELECT DISTINCT Section FROM Admin WHERE Section IS NOT NULL AND Section != '' ORDER BY Section"
                    ).ToList();

                    cmbSection.Properties.Items.Clear();
                    cmbSection.Properties.Items.Add("All Sections");

                    foreach (var s in sections)
                    {
                        cmbSection.Properties.Items.Add(s);
                    }

                    cmbSection.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Loading section dropdown filter indices failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 COMPILATION PIPELINE: Queries filtered records and passes memory data structures into the reporting control
        private void LoadReport(string sectionFilter)
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = @"SELECT Student_Id, FirstName, LastName, Section, Date FROM Admin";

                    if (sectionFilter != "All")
                    {
                        query += " WHERE Section = @Section";
                    }

                    var result = con.Query(query, new { Section = sectionFilter }).ToList();

                    // 📍 SCHEMA INITIALIZATION: Rebuild local tracking columns to hold remapped datasets safely
                    reportData = new DataTable();
                    reportData.Columns.Add("Student_Id", typeof(string));
                    reportData.Columns.Add("FirstName", typeof(string));
                    reportData.Columns.Add("LastName", typeof(string));
                    reportData.Columns.Add("Section", typeof(string));
                    reportData.Columns.Add("Date", typeof(string));

                    foreach (var row in result)
                    {
                        var dict = (IDictionary<string, object>)row;
                        reportData.Rows.Add(
                            dict["Student_Id"]?.ToString(),
                            dict["FirstName"]?.ToString(),
                            dict["LastName"]?.ToString(),
                            dict["Section"]?.ToString(),
                            dict["Date"]?.ToString()
                        );
                    }

                    // 📍 DOCUMENT BINDING ENGINE: Instantiates the XtraReport template and builds the interactive print preview layout
                    XtraReport1 report = new XtraReport1();
                    report.DataSource = reportData;
                    report.CreateDocument();

                    documentViewer1.DocumentSource = report;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Compiling reporting dataset parameters crashed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 📍 FILTER TRIGGER: Intercepts selection shifts to automatically regenerate document canvases sequential
        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbSection.Text;
            LoadReport(selected == "All Sections" ? "All" : selected);
        }

        // 📍 PDF EXPORT ENGINE: Validates workspace records availability and streams layouts into compiled file paths on disk
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (reportData == null || reportData.Rows.Count == 0)
                {
                    XtraMessageBox.Show("There are no records found to generate or write to a PDF document.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Documents|*.pdf";
                    sfd.FileName = $"Student_Report_{DateTime.Today:yyyyMMdd}.pdf";
                    sfd.Title = "Save Student List Report Document";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        XtraReport1 report = new XtraReport1();
                        report.DataSource = reportData;
                        report.CreateDocument();
                        report.ExportToPdf(sfd.FileName);

                        XtraMessageBox.Show("PDF Document exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Export layout writing exception details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}