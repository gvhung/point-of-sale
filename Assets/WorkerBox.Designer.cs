namespace PointOfSale.Assets
{
    partial class WorkerBox
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "101",
            "Hair Cutting",
            "Normal Hair Cutting, Show Shaw",
            "img url"}, -1);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LvServices = new System.Windows.Forms.ListView();
            this.w_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new FontAwesomeIcons.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.ViewBoxContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LvServices);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 345);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LvServices
            // 
            this.LvServices.BackColor = System.Drawing.Color.Ivory;
            this.LvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.w_id,
            this.worker});
            this.LvServices.ContextMenuStrip = this.ViewBoxContextMenu;
            this.LvServices.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvServices.FullRowSelect = true;
            this.LvServices.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Service Code";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Service";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "Price";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "Description";
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "Image";
            this.LvServices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.LvServices.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LvServices.Location = new System.Drawing.Point(0, 0);
            this.LvServices.Margin = new System.Windows.Forms.Padding(0);
            this.LvServices.MultiSelect = false;
            this.LvServices.Name = "LvServices";
            this.LvServices.ShowGroups = false;
            this.LvServices.ShowItemToolTips = true;
            this.LvServices.Size = new System.Drawing.Size(584, 284);
            this.LvServices.TabIndex = 0;
            this.LvServices.UseCompatibleStateImageBehavior = false;
            this.LvServices.View = System.Windows.Forms.View.Details;
            this.LvServices.SelectedIndexChanged += new System.EventHandler(this.LvServices_SelectedIndexChanged);
            // 
            // w_id
            // 
            this.w_id.Text = "Worker ID";
            this.w_id.Width = 82;
            // 
            // worker
            // 
            this.worker.Text = "Worker";
            this.worker.Width = 431;
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
            this.ViewBoxContextMenu.Size = new System.Drawing.Size(162, 166);
            this.ViewBoxContextMenu.Text = "View Box Context Menu";
            // 
            // deleteSelectedMenuItem
            // 
            this.deleteSelectedMenuItem.Image = global::PointOfSale.Properties.Resources.Erase;
            this.deleteSelectedMenuItem.Name = "deleteSelectedMenuItem";
            this.deleteSelectedMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteSelectedMenuItem.Text = "Delete Selected";
            this.deleteSelectedMenuItem.Click += new System.EventHandler(this.deleteSelectedMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.flat_seo2_32_24;
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editSelectedToolStripMenuItem.Text = "Edit Selected";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // addNewServiceToolStripMenuItem
            // 
            this.addNewServiceToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.document_new;
            this.addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            this.addNewServiceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewServiceToolStripMenuItem.Text = "Add NewWorker";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // reloadServicesToolStripMenuItem
            // 
            this.reloadServicesToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.Sync;
            this.reloadServicesToolStripMenuItem.Name = "reloadServicesToolStripMenuItem";
            this.reloadServicesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.reloadServicesToolStripMenuItem.Text = "Reload";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::PointOfSale.Properties.Resources.Logout;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(3, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveColor = System.Drawing.Color.Black;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.IconType = FontAwesomeIcons.IconType.SignOut;
            this.btnCancel.InActiveColor = System.Drawing.Color.Ivory;
            this.btnCancel.Location = new System.Drawing.Point(512, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 56);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.ToolTipText = null;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WorkerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WorkerBox";
            this.Size = new System.Drawing.Size(584, 345);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ViewBoxContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader w_id;
        private System.Windows.Forms.ColumnHeader worker;
        public System.Windows.Forms.ListView LvServices;
        public System.Windows.Forms.ContextMenuStrip ViewBoxContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public FontAwesomeIcons.IconButton btnCancel;
        public System.Windows.Forms.ToolStripMenuItem deleteSelectedMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewServiceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reloadServicesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}
