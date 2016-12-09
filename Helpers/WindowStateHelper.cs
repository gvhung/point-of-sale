using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Helpers
{
    public class WindowStateHelper
    {
        public static void DoMinimize()
        {
            foreach (Form item in Application.OpenForms)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }
        public static void DoMaximize()
        {
            foreach (Form item in Application.OpenForms)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
