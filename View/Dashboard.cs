using MetroFramework;
using PointOfSale.Assets;
using PointOfSale.Controller;
using PointOfSale.Helpers;
using PointOfSale.Model;
using PointOfSale.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class Dashboard : Form
    {
        public Size CurrentSize { get; set; }
        public int MarginTop { get; set; }
        public Size DefaultSize { get; set; }
        public int role { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            MarginTop = (92 + 24 + 2);
            menuStrip1.Cursor = Cursors.Hand;
            DefaultSize = this.Size;
            role = GetRole();
            AddDashboardControl(role); //TESTDB();
        }

        private void TESTDB()
        {
            string errors = "N/A";
            int state = 0;
            new DBController().TestConnection(ref errors, ref state);
            MessageBox.Show(errors, state.ToString());
        }

        private int GetRole()
        {
            return Global.Role;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        void btnInvoice_Click(object sender, EventArgs e)
        {
            AddInvoiceControl();
        }

        private void AddDashboardControl(int res)
        {
            if (res == 1)
            {
                ClearPanel();
                MainMenu control = new MainMenu();
                control.btnInvoice.Click += btnInvoice_Click;
                control.iconServices.Click += btnServices_Click;
                control.iconReports.Click += btnReports_Click;
                control.iconUpdateServices.Click += btnUpdateServices_Click;
                control.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(control);
                this.WindowState = FormWindowState.Normal;
                this.Size = DefaultSize;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                ClearPanel();
                UserMainMenuBox control = new UserMainMenuBox();
                control.btnInvoice.Click += btnInvoice_Click;
                control.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(control);
                this.WindowState = FormWindowState.Normal;
                this.Size = DefaultSize;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        InvoiceBox InvoiceControl;
        ViewBox ViewBox;
        WorkerBox WorkerBox1;
        ServiceBox Services;
        WorkerFormBox WorkerForm;
        private void AddInvoiceControl()
        {
            ClearPanel();
            saveToolStripMenuItem.Tag = "Invoice";
            InvoiceControl = new InvoiceBox();
            InvoiceControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(InvoiceControl);
            int width = (InvoiceControl.Width > this.Width) ? InvoiceControl.Width : this.Width;
            int height = (InvoiceControl.Height > (this.Height - MarginTop)) ? (InvoiceControl.Height + MarginTop) : this.Height;
            DataSet ServicesDataset = new ServiceController().GetAllServies();
             InvoiceControl.AvailableItems = DSParser.ParseServices(ref ServicesDataset);
            InvoiceControl.ApplyAvailableItemsViaOutSideController();
            CurrentSize = new Size(width, height);
            //ChangeCurrentSize(CurrentSize);
            this.WindowState = FormWindowState.Maximized;
            AdjustInvoiceControlSize();
            InvoiceControl.btnExit.Click += iconButton1_Click;

        }

        private void AdjustInvoiceControlSize()
        {
            //InvoiceControl.AvailableItemsList.Width = (this.Width / 2 + 10) - (InvoiceControl.panel1.Width);
            InvoiceControl.panel1.Width = 100;
            InvoiceControl.panel1.Height = InvoiceControl.PnlInvoice.Height = (this.Height - 200 - MarginTop);
            InvoiceControl.PnlInvoice.Width = this.Width - 45;
            //InvoiceControl.SelectedItemsViewPanel.Width = this.Width - (InvoiceControl.AvailableItemsList.Width + InvoiceControl.panel1.Width);
            InvoiceControl.flowLayoutPanel2.Width = InvoiceControl.flowLayoutPanel1.Width;
            //InvoiceControl.AvailableItemsList.Height += 5;
            //InvoiceControl.panel1.Height = InvoiceControl.AvailableItemsList.Height;
            InvoiceControl.panel1.Dock = DockStyle.Top;

        }

        private void ChangeCurrentSize(System.Drawing.Size size)
        {
            this.Size = this.MinimumSize = this.MaximumSize = size;
        }

        private void ClearPanel()
        {
            MainPanel.Controls.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AddDashboardControl(role);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            ProcessExit();
        }

        private void ProcessExit()
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void MiniMizeApp()
        {
            foreach (Form item in Application.OpenForms)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessExit();
        }
        private void WorkersClick()
        {
            ClearPanel();
            WorkerBox1 = new WorkerBox();
            WorkerBox1.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(WorkerBox1);
            this.WindowState = FormWindowState.Normal;
            this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            WorkerBox1.btnCancel.Click += LoadDashboard;
            WorkerBox1.deleteSelectedMenuItem.Click += DeleteItemFromWorkerBox1;
            WorkerBox1.addNewServiceToolStripMenuItem.Click += addNewWorkerToolStripMenuItem_Click;
            WorkerBox1.editSelectedToolStripMenuItem.Click += editWorkerToolStripMenuItem_Click;
            WorkerBox1.reloadServicesToolStripMenuItem.Click += btnUpdateServices_Click;
            WorkerBox1.cancelToolStripMenuItem.Click += btnUpdateServices_Click;
        }
        WorkerController WController = new WorkerController();

        private void editWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editWorker();
        }

        private void editWorker()
        {
            EditWorker();
        }

        private void addNewWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewWorker();
        }

        private void DeleteItemFromWorkerBox1(object sender, EventArgs e)
        {
            if (WorkerBox1.LvServices.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Select a file first");
            }
            else
            {
                //WindowStateHelper.DoMinimize();
                if (MessageBox.Show(string.Format("Are you sure you want to Delete {0} ?", WorkerBox1.LvServices.SelectedItems[0].SubItems[1].Text), "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    int ID = Convert.ToInt16(WorkerBox1.LvServices.SelectedItems[0].Text);
                    WController.DeleteWorker(ID);
                    btnUpdateServices_Click(sender, e);
                }
            }
        }
        private void btnServices_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ViewBox = new ViewBox();
            ViewBox.Dock = DockStyle.Fill;
            ViewBox.LvServices.Width = ViewBox.Width;
            MainPanel.Controls.Add(ViewBox);
            this.WindowState = FormWindowState.Maximized;
            //this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            ViewBox.btnCancel.Click += LoadDashboard;
            ViewBox.deleteSelectedMenuItem.Click += DeleteItemFromServiceViewBox;
            ViewBox.addNewServiceToolStripMenuItem.Click += addNewServiceToolStripMenuItem_Click;
            ViewBox.editSelectedToolStripMenuItem.Click += editSelectedToolStripMenuItem_Click;
            ViewBox.reloadServicesToolStripMenuItem.Click += btnServices_Click;
            ViewBox.cancelToolStripMenuItem.Click += btnServices_Click;
        }

        void editSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditService();
        }
        private void EditWorker()
        {
            ClearPanel();
            WorkerForm = new WorkerFormBox();
            WorkerForm.Dock = DockStyle.Fill;
            WorkerForm.TxtServiceName.Text = WorkerBox1.LvServices.SelectedItems[0].SubItems[1].Text;

            WorkerForm.ID = WorkerBox1.LvServices.SelectedItems[0].SubItems[0].Text;
            MainPanel.Controls.Add(WorkerForm);
            this.WindowState = FormWindowState.Maximized;
            this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            WorkerForm.BtnSave.ToolTipText = "Update(" + WorkerForm.ID + ")";
            WorkerForm.BtnClose.Click += btnUpdateServices_Click;
        }
        private void EditService()
        {
            ClearPanel();
            Services = new ServiceBox();
            Services.Dock = DockStyle.Fill;
            Services.ID = ViewBox.LvServices.SelectedItems[0].SubItems[0].Text;
            DataSet ds = ServiceController.GetItemByID(Services.ID);
           if (ds.Tables[0].Rows.Count != 0)
           {
               Services.TxtCode.Enabled = false;
               Services.TxtCode.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();

               Services.TxtName.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
               Services.TxtLocation.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
               Services.MU.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
               Services.DpCellPrice.Value = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[0]);
               Services.dpCostPrice.Value = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[1]);
               Services.DpCrate.Value = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[6]);
               Services.DpDiscount.Value = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[11]);
               Services.dpReorder.Value = Convert.ToDecimal(ds.Tables[0].Rows[0].ItemArray[8]);
               Services.ISActive.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[5]);
               Services.IsDis.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[10]);
               Services.IsImp.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[7]);
               Services.Isrw.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0].ItemArray[12]);
               MainPanel.Controls.Add(Services);
           }
            this.WindowState = FormWindowState.Maximized;
            this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            Services.BtnSave.ToolTipText = "Update(" + Services.ID + ")";
            Services.BtnClose.Click += btnServices_Click;
        }

        private void addNewServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewService();
        }
        public void AddNewWorker()
        {
            ClearPanel();
            WorkerForm = new WorkerFormBox();
            WorkerForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(WorkerForm);
            this.WindowState = FormWindowState.Normal;
            this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            WorkerForm.BtnSave.ToolTipText = "Save";
            WorkerForm.BtnClose.Click += btnUpdateServices_Click;
        }
        public void AddNewService()
        {
            ClearPanel();

            Services = new ServiceBox();
            Services.Dock = DockStyle.Fill;
            
            int width = (Services.Width > this.Width) ? Services.Width : this.Width;
            int height = (Services.Height > (this.Height - MarginTop)) ? (Services.Height + MarginTop) : this.Height;
            MainPanel.Controls.Add(Services);
            this.WindowState = FormWindowState.Maximized;
           // this.Size = DefaultSize;
            this.StartPosition = FormStartPosition.CenterScreen;
            Services.BtnSave.ToolTipText = "Save";
            Services.BtnClose.Click += btnServices_Click;
        }

        ServiceController SvController = new ServiceController();


        void DeleteItemFromServiceViewBox(object sender, EventArgs e)
        {
            if (ViewBox.LvServices.SelectedIndices.Count <= 0)
            {
                MetroMessageBox.Show(this,"Select a file first");
            }
            else
            {
                //WindowStateHelper.DoMinimize();
                if (MetroMessageBox.Show(this,string.Format("Are you sure you want to Delete {0} ?", ViewBox.LvServices.SelectedItems[0].SubItems[1].Text), "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    int ID = Convert.ToInt16(ViewBox.LvServices.SelectedItems[0].Text);
                    SvController.DeleteService(ID);
                    btnServices_Click(sender, e);
                }
            }
        }

        void LoadDashboard(object sender, EventArgs e)
        {
            AddDashboardControl(role);
        }
        ReportBox ReportControl;
        public void AddReport()
        {
            ClearPanel();
            ReportControl = new ReportBox();
            ReportControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(ReportControl);
            int width = (ReportControl.Width > this.Width) ? ReportControl.Width : this.Width;
            int height = (ReportControl.Height > (this.Height - MarginTop)) ? (ReportControl.Height + MarginTop) : this.Height;
            CurrentSize = new Size(width, height);
            //ChangeCurrentSize(CurrentSize);
            this.WindowState = FormWindowState.Normal;
            ReportControl.RV.Dock = DockStyle.Fill;

        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            AddReport();
        }

        private void btnUpdateServices_Click(object sender, EventArgs e)
        {
            WorkersClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveToolStripMenuItem.Tag.ToString().Equals("Invoice"))
            {
                InvoiceControl.SaveInvoice();
            }
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnInvoice_Click(sender, e);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowStateHelper.DoMinimize();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReports_Click(sender, e);
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            btnInvoice_Click(sender, e);
        }

    }
}
