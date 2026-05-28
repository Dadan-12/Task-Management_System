using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Task_Management_System.Data;

namespace Task_Management_System.Usercontrol
{
    public partial class ReportDashboardUC : XtraUserControl
    {
        private readonly DataBase db = new DataBase();
        private DataTable reportData = new DataTable();

        public ReportDashboardUC()
        {
            InitializeComponent();
            LoadSections();
            LoadReport("All");


            cmbSection.SelectedIndexChanged += (s, e) =>
            {
                string selected = cmbSection.Text;
                LoadReport(selected == "All Sections" ? "All" : selected);
            };
        }

        // ── LOAD SECTIONS INTO FILTER ────────────────────────
        private void LoadSections()
        {
            try
            {
                using (var con = db.GetConnection())
                {
                    var sections = con.Query<string>(
                        "SELECT DISTINCT Section FROM Admin ORDER BY Section"
                    ).ToList();

                    cmbSection.Properties.Items.Clear();
                    cmbSection.Properties.Items.Add("All Sections");
                    foreach (var s in sections)
                        cmbSection.Properties.Items.Add(s);

                    cmbSection.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Section error: " + ex.Message);
            }
        }

        // ── LOAD DATA → PASS TO REPORT ───────────────────────
        public void LoadReport(string section)
        {
            try
            {
                using (var con = db.GetConnection())
                {
                    string query = section == "All"
                        ? "SELECT Student_Id, FirstName, LastName, Section, Date FROM Admin ORDER BY Section"
                        : "SELECT Student_Id, FirstName, LastName, Section, Date FROM Admin WHERE Section=@Section ORDER BY Section";

                    var result = section == "All"
                        ? con.Query(query).ToList()
                        : con.Query(query, new { Section = section }).ToList();

                    reportData = new DataTable();
                    reportData.TableName = "AdminData"; // ← important
                    reportData.Columns.Add("Student_Id", typeof(string));
                    reportData.Columns.Add("FirstName", typeof(string));
                    reportData.Columns.Add("LastName", typeof(string));
                    reportData.Columns.Add("Section", typeof(string));
                    reportData.Columns.Add("Date", typeof(string));

                    foreach (var row in result)
                    {
                        var d = (IDictionary<string, object>)row;
                        reportData.Rows.Add(
                            d["Student_Id"], d["FirstName"],
                            d["LastName"], d["Section"], d["Date"]
                        );
                    }
                }

                // ── KEY FIX: assign BEFORE CreateDocument ────────
                var report = new XtraReport1();
                report.DataSource = reportData;
                report.DataMember = "";          // ← clear DataMember
                report.CreateDocument();

                // ── Assign to viewer ──────────────────────────────
                documentViewer1.DocumentSource = report;
                documentViewer1.InitiateDocumentCreation(); // ← forces refresh
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Report error: " + ex.Message);
            }
        }

        // ── PRINT ────────────────────────────────────────────
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var report = new XtraReport1();
                report.DataSource = reportData;
                report.CreateDocument();
                report.Print();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Print error: " + ex.Message);
            }
        }

        // ── EXPORT PDF ───────────────────────────────────────
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files|*.pdf";
                    sfd.FileName = $"StudentList_{DateTime.Today:yyyyMMdd}.pdf";

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    var report = new XtraReport1();
                    report.DataSource = reportData;
                    report.CreateDocument();
                    report.ExportToPdf(sfd.FileName);

                    XtraMessageBox.Show("PDF exported successfully!");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Export error: " + ex.Message);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}