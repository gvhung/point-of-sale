using Microsoft.Reporting.WinForms;
using PointOfSale.Controller;
using PointOfSale.Data_Set;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.View
{
    public partial class FrmReport : Form
    {
      
        public FrmReport()
        {
            InitializeComponent();
        }
        public void SetDataSource(DateTime From,DateTime To)
        {
            DateTime dt1 = From;
            DateTime dt2 = To;
           
        }
    }
}
