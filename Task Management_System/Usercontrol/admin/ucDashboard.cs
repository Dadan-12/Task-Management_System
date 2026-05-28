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
        // Koneksyon sa database
        private readonly DataBase db = new DataBase();

        public AdminDashboardUC()
        {
            InitializeComponent();
            // I-load ang datos pag-abli sa dashboard
            LoadData();
            LoadDashboardStats();
        }

        // Mag-refresh ang data nga makita ang dashboard
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            // Kung makita na ang dashboard, i-load pag-usab ang datos
            if (this.Visible)
            {
                LoadData();
                LoadDashboardStats();
            }
        }

        // I-load ang lista sa mga estudyante ngadto sa grid
        public void LoadData()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    // Kuha tanan nga estudyante gikan sa database
                    string query = "SELECT * FROM Admin";
                    var result = con.Query(query).ToList();
                    DataTable dt = new DataTable();

                    if (result.Count > 0)
                    {
                        var first = (IDictionary<string, object>)result[0];

                        // I-set ang mga kolum sa table
                        foreach (var key in first.Keys)
                        {
                            // Kung picture ang kolum, i-set isip byte array
                            if (key == "picture")
                                dt.Columns.Add(key, typeof(byte[]));
                            else
                                dt.Columns.Add(key);
                        }

                        // I-fill ang matag row sa table
                        foreach (var row in result)
                        {
                            var dict = (IDictionary<string, object>)row;
                            dt.Rows.Add(dict.Values.ToArray());
                        }
                    }

                    // Ipakita ang datos sa grid
                    MainViewDashboard.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Load error: " + ex.Message);
            }
        }

        // I-update ang mga tile sa ibabaw (total, section, petsa)
        public void LoadDashboardStats()
        {
            try
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    // Ihap kung pila ka estudyante ang naka-rehistro
                    int total = con.ExecuteScalar<int>("SELECT COUNT(*) FROM Admin");
                    lblTotalValue.Text = total.ToString();

                    // Ihap kung pila ka lahi-lahing section
                    int sections = con.ExecuteScalar<int>("SELECT COUNT(DISTINCT Section) FROM Admin");
                    lblSectionValue.Text = sections.ToString();

                    // Ipakita ang karon nga petsa
                    lblDateValue.Text = DateTime.Today.ToString("MMM dd, yyyy");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Stats error: " + ex.Message);
            }
        }

        private void MainViewDashboard_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void lblSectionTitle_Click(object sender, EventArgs e) { }
        private void groupControl1_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void pnlSection_Paint(object sender, PaintEventArgs e) { }
    }
}