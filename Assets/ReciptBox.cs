using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PointOfSale.Data_Set;
using System.IO;

namespace PointOfSale.Assets
{
    public partial class ReciptBox : UserControl
    {
        public ReciptBox()
        {
            InitializeComponent();
            this.Load += ReciptBox_Load;
        }

        void ReciptBox_Load(object sender, EventArgs e)
        {
        }

        public void SetData(POS arg)
        {
            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
           // string reportPath = Path.Combine(exeFolder, @"Reports\Invoice.rdlc");
           // string reportPath = @"D:\Official Work\Webtronix\PointOfSale\PointOfSale\Reports\Invoice.rdlc"; //for local
            string reportPath = Properties.Settings.Default.ReportsFolder + @"\Invoice.rdlc";
            POS ds = arg;
            InvoiceViewer.ProcessingMode = ProcessingMode.Local;
            InvoiceViewer.LocalReport.ReportPath =reportPath ;
            ReportDataSource datasourcePersonal = new ReportDataSource("POS", ds.Tables[0]);
            InvoiceViewer.LocalReport.DataSources.Clear();
            InvoiceViewer.LocalReport.DataSources.Add(datasourcePersonal);
            InvoiceViewer.RefreshReport();
        }
    }
}
