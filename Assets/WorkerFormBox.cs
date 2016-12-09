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

namespace PointOfSale.Assets
{
    public partial class WorkerFormBox : UserControl
    {
        public WorkerFormBox()
        {
            InitializeComponent();
        }
        public string ID { get; set; }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BtnSave.ToolTipText == "Save")
            {
                SaveWorker();
            }
            else
            {
                UpdateWorker();
            }
        }

        private void UpdateWorker()
        {
            List<ModelWorker> services = new List<ModelWorker>();
            ModelWorker service = new ModelWorker()
            {
                Worker = TxtServiceName.Text,
               
            };
            services.Add(service);
            WorkerController saver = new WorkerController();
            foreach (ModelWorker item in services)
            {
                if (!saver.UpdateWorker(item.Worker, ID))
                {
                    MessageBox.Show(string.Format("{0} Service not saved ", item.Worker), "");
                }
                else
                {
                    MessageBox.Show(string.Format("{0} Saved Succesfully", item.Worker), "Info");
                }
            }
        }

        private void SaveWorker()
        {

            List<ModelWorker> services = new List<ModelWorker>();
            ModelWorker service = new ModelWorker()
            {
                Worker = TxtServiceName.Text,
            };
            services.Add(service);
            WorkerController saver = new WorkerController();
            foreach (ModelWorker item in services)
            {
                if (!saver.AddNewWorker(item.Worker))
                {
                    MessageBox.Show("Worker not saved ", "");
                }
                else
                {
                    MessageBox.Show("Worker saved ", "");
                }
            }

        }
    }
}
