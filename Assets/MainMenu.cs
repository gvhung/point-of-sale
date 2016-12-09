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

namespace PointOfSale
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            lblUserName.Text = Global.FullName.ToString().ToUpper();
        }

        private void Icon_MainPanel_Profile_MouseEnter(object sender, EventArgs e)
        {
            Icon_MainPanel_Profile.InActiveColor = Color.Yellow;
        }

        private void Icon_MainPanel_Profile_MouseLeave(object sender, EventArgs e)
        {
            Icon_MainPanel_Profile.InActiveColor = Color.MintCream;
        }

        public void iconSignout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to sign out?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
