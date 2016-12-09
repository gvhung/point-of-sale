namespace PointOfSale.Assets
{
    partial class WorkerFormBox
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblServiceName = new System.Windows.Forms.Label();
            this.TxtServiceName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new FontAwesomeIcons.IconButton();
            this.BtnClose = new FontAwesomeIcons.IconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 265);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.11245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.88755F));
            this.tableLayoutPanel1.Controls.Add(this.LblServiceName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtServiceName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblServiceName
            // 
            this.LblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblServiceName.AutoSize = true;
            this.LblServiceName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceName.ForeColor = System.Drawing.Color.White;
            this.LblServiceName.Location = new System.Drawing.Point(3, 7);
            this.LblServiceName.Name = "LblServiceName";
            this.LblServiceName.Size = new System.Drawing.Size(68, 18);
            this.LblServiceName.TabIndex = 0;
            this.LblServiceName.Text = "Name: ";
            // 
            // TxtServiceName
            // 
            this.TxtServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtServiceName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServiceName.Location = new System.Drawing.Point(142, 3);
            this.TxtServiceName.Name = "TxtServiceName";
            this.TxtServiceName.Size = new System.Drawing.Size(353, 27);
            this.TxtServiceName.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 51);
            this.panel1.TabIndex = 11;
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveColor = System.Drawing.Color.Black;
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.IconType = FontAwesomeIcons.IconType.FloppyO;
            this.BtnSave.InActiveColor = System.Drawing.Color.Ivory;
            this.BtnSave.Location = new System.Drawing.Point(180, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(70, 56);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.TabStop = false;
            this.BtnSave.ToolTipText = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveColor = System.Drawing.Color.Black;
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.IconType = FontAwesomeIcons.IconType.SignOut;
            this.BtnClose.InActiveColor = System.Drawing.Color.Ivory;
            this.BtnClose.Location = new System.Drawing.Point(256, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(70, 55);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.ToolTipText = "Close";
            // 
            // WorkerFormBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WorkerFormBox";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(544, 305);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblServiceName;
        public System.Windows.Forms.TextBox TxtServiceName;
        private System.Windows.Forms.Panel panel1;
        public FontAwesomeIcons.IconButton BtnSave;
        public FontAwesomeIcons.IconButton BtnClose;
    }
}
