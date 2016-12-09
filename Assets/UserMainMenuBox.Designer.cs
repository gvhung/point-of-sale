namespace PointOfSale.Assets
{
    partial class UserMainMenuBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconSettings = new FontAwesomeIcons.IconButton();
            this.Icon_MainPanel_Profile = new FontAwesomeIcons.IconButton();
            this.btnInvoice = new FontAwesomeIcons.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconSignout = new FontAwesomeIcons.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_MainPanel_Profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSignout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.3254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.53968F));
            this.tableLayoutPanel1.Controls.Add(this.iconSettings, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Icon_MainPanel_Profile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInvoice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.58491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.41509F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 305);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iconSettings
            // 
            this.iconSettings.ActiveColor = System.Drawing.Color.Black;
            this.iconSettings.BackColor = System.Drawing.Color.Transparent;
            this.iconSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconSettings.IconType = FontAwesomeIcons.IconType.Wrench;
            this.iconSettings.InActiveColor = System.Drawing.Color.MintCream;
            this.iconSettings.Location = new System.Drawing.Point(362, 23);
            this.iconSettings.Name = "iconSettings";
            this.iconSettings.Size = new System.Drawing.Size(85, 83);
            this.iconSettings.TabIndex = 12;
            this.iconSettings.TabStop = false;
            this.iconSettings.ToolTipText = "Setting";
            // 
            // Icon_MainPanel_Profile
            // 
            this.Icon_MainPanel_Profile.ActiveColor = System.Drawing.Color.Black;
            this.Icon_MainPanel_Profile.BackColor = System.Drawing.Color.Transparent;
            this.Icon_MainPanel_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon_MainPanel_Profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Icon_MainPanel_Profile.IconType = FontAwesomeIcons.IconType.User;
            this.Icon_MainPanel_Profile.InActiveColor = System.Drawing.Color.MintCream;
            this.Icon_MainPanel_Profile.Location = new System.Drawing.Point(23, 23);
            this.Icon_MainPanel_Profile.Name = "Icon_MainPanel_Profile";
            this.tableLayoutPanel1.SetRowSpan(this.Icon_MainPanel_Profile, 2);
            this.Icon_MainPanel_Profile.Size = new System.Drawing.Size(161, 259);
            this.Icon_MainPanel_Profile.TabIndex = 0;
            this.Icon_MainPanel_Profile.TabStop = false;
            this.Icon_MainPanel_Profile.ToolTipText = "Profile";
            // 
            // btnInvoice
            // 
            this.btnInvoice.ActiveColor = System.Drawing.Color.Black;
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.IconType = FontAwesomeIcons.IconType.ShoppingCart;
            this.btnInvoice.InActiveColor = System.Drawing.Color.MintCream;
            this.btnInvoice.Location = new System.Drawing.Point(190, 23);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(85, 82);
            this.btnInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.TabStop = false;
            this.btnInvoice.ToolTipText = "Invoice";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Location = new System.Drawing.Point(190, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 82);
            this.panel2.TabIndex = 8;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.MintCream;
            this.lblUserName.Location = new System.Drawing.Point(3, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 35);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconSignout);
            this.panel3.Location = new System.Drawing.Point(362, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 82);
            this.panel3.TabIndex = 13;
            // 
            // iconSignout
            // 
            this.iconSignout.ActiveColor = System.Drawing.Color.Black;
            this.iconSignout.BackColor = System.Drawing.Color.Transparent;
            this.iconSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSignout.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconSignout.IconType = FontAwesomeIcons.IconType.SignOut;
            this.iconSignout.InActiveColor = System.Drawing.Color.MintCream;
            this.iconSignout.Location = new System.Drawing.Point(0, 0);
            this.iconSignout.Name = "iconSignout";
            this.iconSignout.Size = new System.Drawing.Size(85, 82);
            this.iconSignout.TabIndex = 12;
            this.iconSignout.TabStop = false;
            this.iconSignout.ToolTipText = "Logout";
            this.iconSignout.Click += new System.EventHandler(this.iconSignout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(584, 345);
            this.panel1.TabIndex = 2;
            // 
            // UserMainMenuBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserMainMenuBox";
            this.Size = new System.Drawing.Size(584, 345);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_MainPanel_Profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconSignout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public FontAwesomeIcons.IconButton btnInvoice;
        private System.Windows.Forms.Panel panel1;
        public FontAwesomeIcons.IconButton iconSettings;
        private System.Windows.Forms.Panel panel3;
        public FontAwesomeIcons.IconButton iconSignout;
        public FontAwesomeIcons.IconButton Icon_MainPanel_Profile;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblUserName;

    }
}
