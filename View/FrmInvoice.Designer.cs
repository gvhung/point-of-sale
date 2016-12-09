namespace PointOfSale.View
{
    partial class FrmInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesomeIcons.IconButton();
            this.reciptBox1 = new PointOfSale.Assets.ReciptBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.reciptBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 453);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.ActiveColor = System.Drawing.Color.Red;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.IconType = FontAwesomeIcons.IconType.SignOut;
            this.btnClose.InActiveColor = System.Drawing.Color.Ivory;
            this.btnClose.Location = new System.Drawing.Point(419, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.ToolTipText = null;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reciptBox1
            // 
            this.reciptBox1.Location = new System.Drawing.Point(2, 0);
            this.reciptBox1.Name = "reciptBox1";
            this.reciptBox1.Size = new System.Drawing.Size(497, 402);
            this.reciptBox1.TabIndex = 0;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(500, 453);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoice";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInvoice";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Assets.ReciptBox reciptBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesomeIcons.IconButton btnClose;

    }
}