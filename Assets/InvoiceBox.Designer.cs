namespace PointOfSale.Assets
{
    partial class InvoiceBox
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlInvoice = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SelectedItemsViewPanel = new System.Windows.Forms.Panel();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.Panel();
            this.btnProceed = new FontAwesomeIcons.IconButton();
            this.btnRefresh = new FontAwesomeIcons.IconButton();
            this.btnExit = new FontAwesomeIcons.IconButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.PnlInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SelectedItemsViewPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProceed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Ivory;
            this.flowLayoutPanel1.Controls.Add(this.PnlInvoice);
            this.flowLayoutPanel1.Controls.Add(this.SelectedItemsViewPanel);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(923, 428);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PnlInvoice
            // 
            this.PnlInvoice.AutoScroll = true;
            this.PnlInvoice.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.PnlInvoice.BackColor = System.Drawing.Color.Ivory;
            this.PnlInvoice.Controls.Add(this.panel1);
            this.PnlInvoice.Controls.Add(this.listView1);
            this.PnlInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlInvoice.Location = new System.Drawing.Point(11, 11);
            this.PnlInvoice.Name = "PnlInvoice";
            this.PnlInvoice.Size = new System.Drawing.Size(900, 263);
            this.PnlInvoice.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 263);
            this.panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(159, 263);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.DarkCyan;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView1.Location = new System.Drawing.Point(165, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(735, 263);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.VirtualListSize = 10;
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonitorForDeleteButtonKey);
            // 
            // SelectedItemsViewPanel
            // 
            this.SelectedItemsViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemsViewPanel.BackColor = System.Drawing.Color.Ivory;
            this.SelectedItemsViewPanel.Controls.Add(this.metroTextBox1);
            this.SelectedItemsViewPanel.Controls.Add(this.TxtSearch);
            this.SelectedItemsViewPanel.Location = new System.Drawing.Point(11, 280);
            this.SelectedItemsViewPanel.Name = "SelectedItemsViewPanel";
            this.SelectedItemsViewPanel.Size = new System.Drawing.Size(900, 48);
            this.SelectedItemsViewPanel.TabIndex = 5;
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(3, 16);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.Size = new System.Drawing.Size(241, 23);
            this.TxtSearch.TabIndex = 8;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnProceed);
            this.flowLayoutPanel2.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel2.Controls.Add(this.btnExit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 334);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 75);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btnProceed
            // 
            this.btnProceed.ActiveColor = System.Drawing.Color.Gold;
            this.btnProceed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.IconType = FontAwesomeIcons.IconType.Foursquare;
            this.btnProceed.InActiveColor = System.Drawing.Color.DimGray;
            this.btnProceed.Location = new System.Drawing.Point(705, 3);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(60, 56);
            this.btnProceed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProceed.TabIndex = 3;
            this.btnProceed.TabStop = false;
            this.btnProceed.ToolTipText = null;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveColor = System.Drawing.Color.Gold;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.IconType = FontAwesomeIcons.IconType.Repeat;
            this.btnRefresh.InActiveColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Location = new System.Drawing.Point(771, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 56);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.ToolTipText = null;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveColor = System.Drawing.Color.Gold;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.IconType = FontAwesomeIcons.IconType.SignOut;
            this.btnExit.InActiveColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(837, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.ToolTipText = null;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(268, 16);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvoiceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InvoiceBox";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(943, 448);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PnlInvoice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.SelectedItemsViewPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnProceed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlInvoice;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel SelectedItemsViewPanel;
        public FontAwesomeIcons.IconButton btnExit;
        public FontAwesomeIcons.IconButton btnProceed;
        public FontAwesomeIcons.IconButton btnRefresh;
        public System.Windows.Forms.Panel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
