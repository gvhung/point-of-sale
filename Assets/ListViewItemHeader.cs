using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Assets
{
    public partial class ListViewItemHeader : UserControl
    {
        public ListViewItemHeader()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.OrangeRed;
            ChangeItemsColor();
        }

        private void ChangeItemsColor(bool over=true)
        {
            if (over)
            {
              //  metroLabel1.ForeColor = metroLabel1.ForeColor = metroLabel1.ForeColor = metroLabel1.ForeColor = Color.Ivory;
            }
            else
            {
           // metroLabel1.ForeColor = metroLabel1.ForeColor = metroLabel1.ForeColor = metroLabel1.ForeColor = Color.Black;
            }
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.LemonChiffon;
            ChangeItemsColor(false);
        }
    }
}
