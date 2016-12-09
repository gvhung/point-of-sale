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
    public partial class FrmInvoice : Form
    {
        public POS dataset { get; set; }

        public FrmInvoice()
        {
            InitializeComponent();
        }

        public void SetDataAdapter()
        {
            reciptBox1.SetData(dataset);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
