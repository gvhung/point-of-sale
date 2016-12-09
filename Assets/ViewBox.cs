using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Model;
using PointOfSale.Controller;
using PointOfSale.Helpers;

namespace PointOfSale.Assets
{
    public partial class ViewBox : UserControl
    {
        List<ModelService> AvailableServices { get; set; }

        public ViewBox()
        {
            InitializeComponent();
            this.Load += ViewBox_Load;
        }

        void ViewBox_Load(object sender, EventArgs e)
        {
            TxtSearch.Focus();
            DataSet ds = new ServiceController().GetAllServies();
            AvailableServices = DSParser.ParseServices(ref ds);
            if (AvailableServices != null && AvailableServices.Count > 0)
            {
                SetAdapter();
            }
        }
        Dashboard dsh = new Dashboard();
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                TxtSearch.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                dsh.AddNewService();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void SetAdapter()
        {
            this.LvServices.Items.Clear();
            foreach (ModelService item in AvailableServices)
            {
                string[] arr = new string[] { item.ItemCode + "", item.ItemName, item.costprice.ToString(), item.sellprice.ToString(), item.IsActive.ToString(), item.Location, item.munit, item.Crate.ToString() };
                this.LvServices.Items.Add(new System.Windows.Forms.ListViewItem(arr));
            }
        }

        private void LvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvServices.SelectedIndices.Count < 0)
            {
                LvServices.ContextMenuStrip = null;
            }
            else
            {
                LvServices.ContextMenuStrip = ViewBoxContextMenu;
            }
        }

        private void LvServices_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LvServices.SelectedItems.Clear();
            for (int i = 0; i < LvServices.Items.Count; i++)
            {
                string matching = LvServices.Items[i].SubItems[1].ToString();
                string tomatched = TxtSearch.Text.ToUpper();
                if (matching.Contains(tomatched))
                {
                    LvServices.Items[i].BackColor = Color.CornflowerBlue;
                    LvServices.EnsureVisible(i);
                    if (TxtSearch.Text == "")
                    {
                        LvServices.EnsureVisible(0);
                        LvServices.Items[i].BackColor = Color.Ivory;
                    }
                }
                else
                {
                    LvServices.Items[i].BackColor = Color.Ivory;
                    if (TxtSearch.Text == "")
                    {
                        LvServices.EnsureVisible(0);
                        LvServices.Items[i].BackColor = Color.Ivory;
                    }
                }
            }

        }
    }
}
