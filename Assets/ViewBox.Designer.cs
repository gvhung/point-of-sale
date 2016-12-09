namespace PointOfSale.Assets
{
    partial class ViewBox
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "101",
            "Hair Cutting",
            "Normal Hair Cutting, Show Shaw",
            "img url"}, -1);
            this.ViewBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LvServices = new System.Windows.Forms.ListView();
            this.ItemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new FontAwesomeIcons.IconButton();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.ViewBoxContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewBoxContextMenu
            // 
            this.ViewBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedMenuItem,
            this.toolStripSeparator5,
            this.editSelectedToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewServiceToolStripMenuItem,
            this.toolStripSeparator2,
            this.reloadServicesToolStripMenuItem,
            this.toolStripSeparator3,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator4});
            this.ViewBoxContextMenu.Name = "ViewBoxContextMenu";
            this.ViewBoxContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ViewBoxContextMenu.Size = new System.Drawing.Size(156, 144);
            this.ViewBoxContextMenu.Text = "View Box Context Menu";
            // 
            // deleteSelectedMenuItem
            // 
            this.deleteSelectedMenuItem.Image = global::PointOfSale.Properties.Resources.Erase;
            this.deleteSelectedMenuItem.Name = "deleteSelectedMenuItem";
            this.deleteSelectedMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteSelectedMenuItem.Text = "Delete Selected";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(152, 6);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.flat_seo2_32_24;
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editSelectedToolStripMenuItem.Text = "Edit Selected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // addNewServiceToolStripMenuItem
            // 
            this.addNewServiceToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.document_new;
            this.addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            this.addNewServiceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addNewServiceToolStripMenuItem.Text = "Add New Item";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // reloadServicesToolStripMenuItem
            // 
            this.reloadServicesToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.Sync;
            this.reloadServicesToolStripMenuItem.Name = "reloadServicesToolStripMenuItem";
            this.reloadServicesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.reloadServicesToolStripMenuItem.Text = "Reload Services";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(152, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.Logout;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(152, 6);
            // 
            // LvServices
            // 
            this.LvServices.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.LvServices.BackColor = System.Drawing.Color.Ivory;
            this.LvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemCode,
            this.Service,
            this.columnHeader3,
            this.Descp,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.LvServices.ContextMenuStrip = this.ViewBoxContextMenu;
            this.LvServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvServices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvServices.FullRowSelect = true;
            this.LvServices.GridLines = true;
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "Service Code";
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "Service";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "Price";
            listViewGroup9.Header = "ListViewGroup";
            listViewGroup9.Name = "Description";
            listViewGroup10.Header = "ListViewGroup";
            listViewGroup10.Name = "Image";
            this.LvServices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.LvServices.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.LvServices.Location = new System.Drawing.Point(0, 0);
            this.LvServices.Margin = new System.Windows.Forms.Padding(0);
            this.LvServices.MultiSelect = false;
            this.LvServices.Name = "LvServices";
            this.LvServices.ShowGroups = false;
            this.LvServices.ShowItemToolTips = true;
            this.LvServices.Size = new System.Drawing.Size(1000, 546);
            this.LvServices.TabIndex = 5;
            this.LvServices.UseCompatibleStateImageBehavior = false;
            this.LvServices.View = System.Windows.Forms.View.Details;
            this.LvServices.SelectedIndexChanged += new System.EventHandler(this.LvServices_SelectedIndexChanged_1);
            // 
            // ItemCode
            // 
            this.ItemCode.Text = "Item Code";
            this.ItemCode.Width = 132;
            // 
            // Service
            // 
            this.Service.Text = "Item Name";
            this.Service.Width = 306;
            // 
            // Descp
            // 
            this.Descp.Text = "Sell Price";
            this.Descp.Width = 84;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IS Active";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 102;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveColor = System.Drawing.Color.Black;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.IconType = FontAwesomeIcons.IconType.SignOut;
            this.btnCancel.InActiveColor = System.Drawing.Color.Ivory;
            this.btnCancel.Location = new System.Drawing.Point(0, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(1000, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.ToolTipText = null;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost Price";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Measuring Unit";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Crate";
            this.columnHeader5.Width = 117;
            // 
            // TxtSearch
            // 
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = null;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.CustomButton.Visible = false;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(3, 549);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.Size = new System.Drawing.Size(292, 23);
            this.TxtSearch.TabIndex = 7;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // ViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.LvServices);
            this.Name = "ViewBox";
            this.Size = new System.Drawing.Size(1000, 574);
            this.ViewBoxContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ContextMenuStrip ViewBoxContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripMenuItem deleteSelectedMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewServiceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reloadServicesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        public System.Windows.Forms.ListView LvServices;
        private System.Windows.Forms.ColumnHeader ItemCode;
        private System.Windows.Forms.ColumnHeader Service;
        private System.Windows.Forms.ColumnHeader Descp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public FontAwesomeIcons.IconButton btnCancel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
    }
}
