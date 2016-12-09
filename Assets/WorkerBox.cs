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
    public partial class WorkerBox : UserControl
    {
        List<ModelWorker> AvailableWorkers { get; set; }

        public WorkerBox()
        {
            InitializeComponent();
            this.Load += ViewBox_Load;
        }

        void ViewBox_Load(object sender, EventArgs e)
        {
            DataSet ds=new WorkerController().GetAllWorkers();
            AvailableWorkers = new DSParser().ParseWorkersDataSet(ds);
            if (AvailableWorkers != null && AvailableWorkers.Count > 0)
            {
                SetAdapter();
            }
        }

        private void SetAdapter()
        {
            this.LvServices.Items.Clear();
            foreach (ModelWorker item in AvailableWorkers)
            {
                string[] arr = new string[] { item.ID + "", item.Worker };
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void deleteSelectedMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
