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
using MetroFramework;

namespace PointOfSale.Assets
{
    public partial class ServiceBox : UserControl
    {
        public ServiceBox()
        {
            InitializeComponent();
        }
        public string ID { get; set; }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.ToolTipText == "Save")
            {
                SaveService();
            }
            else
            {
                UpdateService();
            }
        }

        private void UpdateService()
        {
            List<ModelService> services = new List<ModelService>();
            ModelService service = new ModelService()
            {
                ItemName = TxtName.Text,
                costprice = Convert.ToDouble(dpCostPrice.Value),
                Crate = Convert.ToDouble(DpCrate.Value),
                Discount = Convert.ToDouble(DpDiscount.Value),
                IsActive = ISActive.Checked,
                IsDisc = IsDis.Checked,
                IsImp = IsImp.Checked,
                IsRaw = Isrw.Checked,
                Location = TxtLocation.Text,
                munit = MU.Text,
                ReorderLvl = (int)dpReorder.Value,
                sellprice = (double)DpCellPrice.Value,
                ItemCode =TxtCode.Text,
            };
            services.Add(service);
            ServiceController saver = new ServiceController();
            foreach (ModelService item in services)
            {
                if (!saver.UpdateService(item.ItemName, (float)item.sellprice, item.costprice,item.Crate,item.Discount,item.IsActive,
                    item.IsDisc,item.IsImp,item.Location,item.munit,item.ReorderLvl,item.IsRaw, ID))
                {
                    MetroMessageBox.Show(this,string.Format("{0} Service not saved ", item.ItemName), "");
                }
                else
                {
                    MetroMessageBox.Show(this,string.Format("{0} Saved Succesfully", item.ItemName), "Info");
                }
            }
        }

        private void SaveService()
        {

            List<ModelService> services = new List<ModelService>();
            ModelService service = new ModelService()
            {
                ItemName = TxtName.Text,
                costprice = Convert.ToDouble(dpCostPrice.Value),
                Crate = Convert.ToDouble(DpCrate.Value),
                Discount = Convert.ToDouble(DpDiscount.Value),
                IsActive = ISActive.Checked,
                IsDisc = IsDis.Checked,
                IsImp = IsImp.Checked,
                IsRaw = Isrw.Checked,
                Location = TxtLocation.Text,
                munit = MU.Text,
                ReorderLvl = (int)dpReorder.Value,
                sellprice = (double)DpCellPrice.Value,
              ItemCode= TxtCode.Text,
            };
            services.Add(service);
            ServiceController saver = new ServiceController();
            foreach (ModelService item in services)
            {
                if (!saver.AddService(item.ItemName,item.ItemCode,item.costprice,item.Crate,item.Discount,item.IsActive,item.IsDisc,item.IsImp,item.IsRaw,item.Location,item.munit,item.ReorderLvl,item.sellprice))
                {
                    MetroMessageBox.Show(this,"Service not saved ", "");
                }
                else
                {
                    MetroMessageBox.Show(this,"Service saved ", "");
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
