using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Test
{
    public partial class Form1 : Form
    {
        DBConnection db = new DBConnection();
        SqlCommand cmd;
        SqlDataAdapter adp;
        public Form1()
        {
            db.Connection();
            InitializeComponent();
            dtpEdate.Value = DateTime.Now;
            dtpSdate.Value = dtpSdate.Value.AddMonths(-1);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dtpSdate.Value < dtpEdate.Value)
            {
                SaleReport report = new SaleReport();
                cmd = new SqlCommand("SelectDateRange", db.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sDate", dtpSdate.Value);
                cmd.Parameters.AddWithValue("@eDate", dtpEdate.Value);
                adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "SelectDateRange");
                //ds.Tables.Add(dt);
                if (ds.Tables != null)
                {
                    report.DataSource = ds;
                    report.DataMember = "SelectDateRange";
                    report.CreateDocument();
                    //report.ShowPreviewDialog();
                    dcvReport.DocumentSource = report;
                    dcvReport.CreateControl();
                }
                else
                {
                    MessageBox.Show("Data not found...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    report.DataSource = null;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Start date cannot larger than End date", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
