using PointOfSale.Controller;
using PointOfSale.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.View
{
    public partial class LoginBox : Form
    {
        AuthenticationController auth;
        public LoginBox()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            TxtPwd.KeyDown += TB_KeyDown;
            TxtUserName.KeyDown += TB_KeyDown;
            iconButton4.Click += btnExit_Click;
            this.Load += LoginBox_Load;
            //TESTDB();
        }

        void LoginBox_Load(object sender, EventArgs e)
        {
           // Settings();
        }

        private void Settings()
        {
            if (!Properties.Settings.Default.Configured)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = Application.StartupPath;
                fbd.Description = "Please select the database folder.";
                fbd.ShowNewFolderButton = false;
                if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    Properties.Settings.Default.ConnectionStringFolder = fbd.SelectedPath;
                    fbd = new FolderBrowserDialog();
                    fbd.SelectedPath = Application.StartupPath;
                    fbd.Description = "Please select the reports folder.";
                    fbd.ShowNewFolderButton = false;
                    if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        Properties.Settings.Default.ReportsFolder = fbd.SelectedPath;
                        Properties.Settings.Default.Configured = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
            }
        }


        void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActivateLoginProcess();
        }

        void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateLoginProcess();
        }

        private void ActivateLoginProcess()
        {
            try
            {
                auth = new AuthenticationController();
                Global.Role = 1;
                Global.UserId = 2;
                Global.FullName = "ADMIN";
                //auth.AuthenticateUser(TxtUserName.Text, TxtPwd.Text);
                if (Global.Role == 0)
                {
                    ErrorLabel.Text = "UserName or Password is invalid";
                }
                else if (Global.Role == 1)
                {
                    new Dashboard().Show();
                  //dsh.Show(this);
                    this.Hide();
                }
                else
                {
                    new Dashboard().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :", ex.Message);
            }
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

    }
}
