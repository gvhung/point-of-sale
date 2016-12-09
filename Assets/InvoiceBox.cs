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
using FontAwesomeIcons;
using PointOfSale.Helpers;
using PointOfSale.Controller;
using PointOfSale.Data_Set;
using Microsoft.Reporting.WinForms;
using PointOfSale.View;
using MetroFramework;
using System.Text.RegularExpressions;

namespace PointOfSale.Assets
{
    public partial class InvoiceBox : UserControl
    {
        public ListBox AvailableItemsList { get; set; }
        public ListView SelectedItemsList { get; set; }
        public List<ModelService> AvailableItems { get; set; }
        public List<ModelService> SelectedItems { get; set; }
        public List<ModelWorker> WorkersFound { get; set; }
        public List<ListViewItem> Items { get; set; }
        POS PosDataSet = new POS();
        public InvoiceBox()
        {
            ListViewItem itm = new ListViewItem();
            InitializeComponent();
            this.Load += InvoiceBox_Load;
            itm.BtnRemove.Click += BtnRemove_Click;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            Items = new List<ListViewItem>();
            //listView1.View = View.Details;
            // WindowStateHelper.DoMinimize();
           //WorkersFound = new DSParser().ParseWorkersDataSet(new WorkerController().GetAllWorkers());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                AddToList();
            }
           
        }

        public void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        void InvoiceBox_Load(object sender, EventArgs e)
        {

            AvailableItemsList = listBox1;
            SelectedItemsList = listView1;
            if (AvailableItems != null && AvailableItems.Count > 0)
            {
                ApplyAvailableItems();
                AvailableItemsList.SelectedIndexChanged += AvailableItemsList_SelectedIndexChanged;
                AvailableItemsList.KeyDown += MonitorForSaveKey;
            }
            AddHeaderItem();
        }

        public void ApplyAvailableItemsViaOutSideController()
        {
            ApplyAvailableItems();
            AvailableItemsList.SelectedIndexChanged += AvailableItemsList_SelectedIndexChanged;
        }

        private void ApplyAvailableItems()
        {
            AvailableItemsList.Items.Clear();
            if (AvailableItems != null)
            {
                foreach (ModelService item in AvailableItems)
                {
                    AvailableItemsList.Items.Add(item.ItemName);
                }
            }
            SelectedItems = new List<ModelService>();
        }

        void AvailableItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableItemsList.SelectedIndices.Count > 0)
            {
                //tnAddItem.Enabled = true;
            }
            else
            {
                // btnAddItem.Enabled = false;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<ModelService> NewlySelected = GetToAddSelectedItems();
            AddSelection(NewlySelected, SelectedItems);
            ApplyDataSource();
        }

        private void ApplyDataSource()
        {
            ClearPreviousItems();
            AddFooterItem();
            AddNewItems();
            AddHeaderItem();
            
        }

        private void AddHeaderItem()
        {
            ListViewItemHeader header = new ListViewItemHeader();
            header.Dock = DockStyle.Top;
            header.KeyDown += MonitorForSaveKey;
            header.SetBounds(0, 0, header.Width, header.Height);
            SelectedItemsList.Controls.Add(header);
        }
        private void AddListViewItem()
        {
            ListViewItem LvItem = new ListViewItem();

            SelectedItemsList.Controls.Add(LvItem);
        }

        void discount_ValueChanged(object sender, EventArgs e)
        {
            TTL = 0;
            foreach (ListViewItem item in Items)
            {
                TTL = item.SetTotalPaisay(ref TTL);
            }
            UpdateFooter();
        }

        public double TTL = 0;
        ListViewItemFooter footer;
        private void AddFooterItem()
        {
            footer = new ListViewItemFooter();
            footer.Dock = DockStyle.Top;
            footer.KeyDown += MonitorForSaveKey;
            footer.SetBounds(0, 0, footer.Width, footer.Height);
            SelectedItemsList.Controls.Add(footer);
            //footer.TTL = TTL;
            //footer.setValues();
            footer.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            SaveInvoice();
        }

        public void SaveInvoice()
        {
            try
            {
                ServiceController sc= new ServiceController();
                string INV_Nmbr = "";
                DataTable sdt = new POS.InvoiceDataTable();
                if (Items.Count > 0)
                {
                    int length = 4;
                    string reference_no = sc.GetMaxId();
                    if(reference_no!="")
                    {
                        string[] lines = Regex.Split(reference_no, "/");
                        int nmbr =Convert.ToInt32(lines[0]);
                        nmbr = nmbr + 1;
                        INV_Nmbr = nmbr.ToString().PadLeft(length, '0');
                    }

                    string CurrentMachineName = Environment.MachineName;
                    List<ModelService> services = new List<ModelService>();
                    TTL = 0;
                    foreach (ListViewItem item in Items)
                    {
                        ModelService service = new ModelService()
                        {
                            ItemCode = item.ItemCode,
                            sellprice = item.ItemPrice,
                            costprice=item.ItemTotalPrice,
                            INVDate = DateTime.Now,
                            DisAmount = (float)footer.discount,
                            ReAmount = (float)(TTL - footer.discount),
                            INVNO = INV_Nmbr,
                            comp_id = 1,
                            ModeofPay = "Cash",
                            FinYear = "2014-2015",
                            Party = "1",
                            Remarks = "Thnaks",
                            Tr_Time = DateTime.Now.TimeOfDay,
                            TrType = 3,
                            userid = "1",
                            Vkey = "1",
                            workstation = CurrentMachineName,
                            BalAmount = 0F,
                            
                            

                        };
                       // ModelWorker worker = item.GetSelectedWorker();
                        //service.WorkerID = worker.ID;
                        services.Add(service);
                        TTL = item.SetTotalPaisay(ref TTL);
                    }

                    OrderController saver = new OrderController();
                    string error = "";
                    foreach (ModelService item in services)
                    {
                        if (!saver.AddNewSale(ref error, INV_Nmbr, Global.UserId + "", item))
                        {
                            MetroMessageBox.Show(this,error,"Sale not saved ");
                        }
                     
                    }
                    error = "";
                  //  if (!saver.AddNewOrder(ref error, reference_no, services))
                   // {
                    //    MetroMessageBox.Show(this, error, "Order not saved successfully");
                   // }
                    foreach (ListViewItem item in Items)
                    {
                        String _User = Global.Name;
                        DataRow nRow = sdt.NewRow();
                        nRow["Service"] = item.ItemTitle + "";
                        nRow["User"] = _User;
                        nRow["Worker"] = "Admin";
                        nRow["Price"] = item.ItemPrice;
                        nRow["Discount"] = item.discount.Value;
                        nRow["GrandTotal"] = TTL;
                        nRow["OverAllDiscount"] = footer.discount_amount;
                        nRow["ItemCode"] = item.ItemCode + "";
                        nRow["DiscountedTotal"] = footer.TTL;
                        sdt.Rows.Add(nRow);
                    }
                    POS ds = new POS();
                    ds.Merge(sdt);
                    FrmInvoice invoice = new FrmInvoice();
                    invoice.dataset = ds;
                    invoice.SetDataAdapter();
                    ClearList();
                    invoice.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Nothing to save", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int iteration;
        private void AddNewItems()
        {
            iteration = 0;
            foreach (ModelService item in SelectedItems)
            {
                StartAddItemThread(item, SelectedItemsList);
                iteration++;
            }
        }

        private void StartAddItemThread(ModelService item, ListView SelectedItemsList)
        {
            ListViewItem controll = new ListViewItem();
            controll.Tag = iteration;
            controll.Dock = DockStyle.Top;
            controll.VerticalScroll.Enabled = true;
            controll.ItemCode = item.ItemCode + "";
            controll.ItemTitle = item.ItemName;
            controll.ItemPrice = item.sellprice;
            controll.ItemQuantity = 1;
            controll.ItemSelected = false;
            controll.ItemTotalPrice = item.costprice;
            controll.Tag = item.ItemCode.ToString();
            controll.BtnRemove.Tag = item.ItemCode;
            controll.BtnRemove.Click += BtnRemoveClicked;
            controll.KeyDown += MonitorForDeleteButtonKey;
            controll.WorkersList = WorkersFound;
           // controll.SetWorkers();
            controll.discount.ValueChanged += discount_ValueChanged;
            foreach (Control ctrl in controll.Controls)
            {
                ctrl.KeyDown += MonitorForDeleteButtonKey;
                ctrl.KeyDown += MonitorForSaveKey;
            }
            controll.SetBounds(0, (controll.Height * SelectedItemsList.Controls.Count) + 6, controll.Width, controll.Height);
            SelectedItemsList.AutoScrollOffset = controll.AutoScrollPosition;
            SelectedItemsList.Controls.Add(controll);
            controll.Numeric_Quantity.Tag = Items.Count;
            controll.Numeric_Quantity.ValueChanged += Numeric_Quantity_ValueChanged;
            TTL = controll.SetTotalPaisay(ref TTL);
            Items.Add(controll);
            UpdateFooter();
        }

        private void MonitorForSaveKey(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control && e.KeyCode == Keys.S))
            {
                SaveInvoice();
                ClearList();
            }
        }

        private void BtnRemoveClicked(object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            int tag = (int)btn.Tag;
            ListViewItem toRemove = null;
            foreach (ListViewItem item in Items)
            {
                if (item.ItemCode == tag + "")
                {
                    toRemove = item;
                }
            }
            if (toRemove != null)
            {
                ModelService itemToR = AvailableItems.Where(av => av.ItemCode == toRemove.ItemCode).FirstOrDefault();
                if (itemToR != null)
                {
                    SelectedItems.Remove(itemToR);
                }
                Items.Remove(toRemove);
                 UpdateCompleteSelectedList(toRemove);
                if (SelectedItems.Count < 1)
                {
                    Remove();
                }
               
            }
        }

        private void UpdateCompleteSelectedList(ListViewItem arg)
        {
            SelectedItemsList.Controls.Remove(arg);
            UpdateFooter();

        }

        void Numeric_Quantity_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown obj = sender as NumericUpDown;
            int tag = Convert.ToInt32(obj.Tag.ToString());
            UpdateFooter();
        }

        public void UpdateFooter()
        {
            TTL = 0;
            foreach (ListViewItem item in Items)
            {
                TTL = item.SetTotalPaisay(ref TTL);
            }
            
            if (footer != null)
            {
                footer.TTL = TTL;
                footer.setValues();
            }
        }

        private void ClearPreviousItems()
        {
            SelectedItemsList.Controls.Clear();
            Items.Clear();
            SelectedItemsList.Items.Clear();
            SelectedItemsList.Refresh();
        }

        private void AddSelection(List<ModelService> SourceList, List<ModelService> DestinationList)
        {
            foreach (ModelService item in SourceList)
            {
                if (!DestinationList.Contains(item))
                {
                    DestinationList.Add(item);
                }
            }
        }

        private List<ModelService> GetToAddSelectedItems()
        {
            List<ModelService> res = new List<ModelService>();
            foreach (int index in AvailableItemsList.SelectedIndices)
            {
                res.Add(AvailableItems[index]);
            }
            return res;
        }



        private void Remove()
        {
            foreach (Control item in SelectedItemsList.Controls)
            {
                if (item.GetType() == typeof(ListViewItem))
                {
                    ListViewItem itm = (ListViewItem)item;
                    if (itm.ItemSelected)
                    {
                        SelectedItemsList.Controls.Remove(item);
                    }
                }
            }
        }
        public void ClearList()
        {
            SelectedItems.Clear();
            SelectedItemsList.Clear();
            SelectedItemsList.Controls.Clear();
            AddHeaderItem();
            ClearFooter();
        }

        private void ClearFooter()
        {
            TTL = 0;
            foreach (ListViewItem item in Items)
            {
                TTL = 0;
            }

            if (footer != null)
            {
                footer.TTL = TTL;
                footer.setValues();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear selected list?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                ClearList();
            }
        }

        private void AddToList()
        {
            //WindowStateHelper.DoMinimize();
            List<ModelService> NewlySelected = GetToAddSelectedItems();
            AddSelection(NewlySelected, SelectedItems);
            ApplyDataSource();
           // WindowStateHelper.DoMaximize();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddToList();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddToList();
        }

        private void MonitorForDeleteButtonKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Remove();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            int index = listBox1.FindString(TxtSearch.Text.ToUpper());
            if (index > -1)
            {
                listBox1.SelectedIndex = index;
                if (TxtSearch.Text == "")
                {
                    listBox1.SelectedIndex = -1;
                }
            }

        }
    }
}
