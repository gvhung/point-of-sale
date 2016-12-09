using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Controller;
using PointOfSale.Data_Set;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace PointOfSale.Assets
{
    public partial class ReportBox : UserControl
    {
        public ReportBox()
        {
            InitializeComponent();
            RV.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            DateTime dt1 = From.Value;
            DateTime dt2 = To.Value;
            DataTable dt = new DBController().GetRecords(dt1.ToString(), dt2.ToString());
            PointOfSale.Data_Set.Report ds = new Data_Set.Report();
            ds.Merge(dt);
            RV.ProcessingMode = ProcessingMode.Local;
           // RV.LocalReport.ReportPath = "Reports/ReportFinal.rdlc";
            RV.LocalReport.ReportPath = Properties.Settings.Default.ReportsFolder+@"\ReportFinal.rdlc";
            ReportDataSource datasourcePersonal = new ReportDataSource("Report", ds.Tables["Table1"]);
            RV.LocalReport.DataSources.Clear();
            RV.LocalReport.DataSources.Add(datasourcePersonal);
            RV.RefreshReport();
            RV.Dock = DockStyle.Fill;
            RV.Visible = true;
        }

        private void RV_Load(object sender, EventArgs e)
        {

        }

        private void RV_Load_1(object sender, EventArgs e)
        {

        }
    }
}
