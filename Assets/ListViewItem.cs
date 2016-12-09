using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesomeIcons;
using PointOfSale.Controller;
using PointOfSale.Model;

namespace PointOfSale.Assets
{
    public partial class ListViewItem : UserControl
    {
        public String ItemCode { get; set; }
        public String ItemTitle { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public double AcctualItemPrice { get; set; }
        public double ItemTotalPrice { get; set; }
        public bool ItemSelected { get; set; }
        public double Discount { get; set; }

        public List<ModelWorker> WorkersList { get; set; }

        public double TotalPaisay { get; set; }

        public Label Label_ServiceName { get; set; }
        public NumericUpDown Numeric_Quantity { get; set; }
        public Label Label_ItemAmount { get; set; }
        public Label Label_ItemTotalAmount { get; set; }

        //public bool SetWorkers()
        //{
        //    if (WorkersList != null && WorkersList.Count > 0)
        //    {
        //        WorkersDropDown.Items.Clear();
        //        foreach (ModelWorker item in WorkersList)
        //        {
        //            WorkersDropDown.Items.Add(item.Worker);
        //        }
        //        if (WorkersDropDown.Items.Count > 0)
        //        {
        //            WorkersDropDown.SelectedIndex = 0;
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        //public ModelWorker GetSelectedWorker()
        //{
        //    if (WorkersDropDown.SelectedIndex >= 0)
        //    {
        //        return WorkersList[WorkersDropDown.SelectedIndex];
        //    }
        //    return null;
        //}
       
        public double SetTotalPaisay(ref double ttl)
        {
            this.TotalPaisay = ttl;
            ttl += this.ItemTotalPrice;
            return ttl;
        }

        public ListViewItem()
        {
            InitializeComponent();
            ItemSelected = false;
            this.Load += ListViewItem_Load;
        }

        void ListViewItem_Load(object sender, EventArgs e)
        {
            InvoiceBox ib = new InvoiceBox();
            Label_ServiceName = label1;
            Numeric_Quantity = numericUpDown1;
            Label_ItemAmount = label2;
            Label_ItemTotalAmount = label3;
            ItemQuantity = 1;
            AcctualItemPrice= ItemTotalPrice = ItemPrice;
            Numeric_Quantity.ValueChanged += Numeric_Quantity_ValueChanged;
            discount.ValueChanged+=discount_ValueChanged;
            Commit();
        }

        public void Commit()
        {
            Label_ServiceName.Text = ItemTitle;
            Numeric_Quantity.Value = ItemQuantity;
            Label_ItemAmount.Text = AcctualItemPrice + "";
            ChangeTotalPrice();
        }

        void Numeric_Quantity_ValueChanged(object sender, EventArgs e)
        {
            ItemQuantity = (int)Numeric_Quantity.Value;
            UpdateItem();
        }

        private void UpdateItem()
        {
            Commit();
        }

        private void ChangeTotalPrice()
        {
            ItemTotalPrice = ItemPrice * ItemQuantity;
            Label_ItemTotalAmount.Text = ItemTotalPrice + "";
        }
        private void btnCheckChange_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (ItemSelected)
            {
                ItemSelected = false;
                btn.IconType = IconType.StarO;
            }
            else
            {
                ItemSelected = true;
                btn.IconType = IconType.Star;
            }
        }

        private void discount_ValueChanged(object sender, EventArgs e)
        {
            CalculateIndiviualDiscount();
        }

        private void CalculateIndiviualDiscount()
        {
            //foreach (Form item in Application.OpenForms)
            //{
            //    item.WindowState = FormWindowState.Minimized;
            //}
            ItemPrice = AcctualItemPrice - ((AcctualItemPrice * (double)discount.Value) / 100);
            ItemTotalPrice = ItemPrice * ItemQuantity;
            UpdateItem();
        }
    }
}
