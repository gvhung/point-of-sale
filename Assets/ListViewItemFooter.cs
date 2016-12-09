using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.Helpers;

namespace PointOfSale.Assets
{
    public partial class ListViewItemFooter : UserControl
    {
        public double TTL { get; set; }
        public double discount { get; set; }
        public double discount_amount { get; set; }
        public ListViewItemFooter()
        {
            InitializeComponent();
            this.Discount.ValueChanged += Discount_ValueChanged;
            discount = 0D;
        }

        void Discount_ValueChanged(object sender, EventArgs e)
        {
            discount = (double)Discount.Value;
            discount_amount = (TTL * discount) / 100;
            setValues();
        }

        public void setValues()
        {
            TTL = TTL - discount_amount;
            lblAmount.Text = Math .Round(TTL,2).ToString()+"/- RS Only";
            //LblWords.Text = CountHelper.NumbersToWords((int)TTL);
        }
    }
}
