﻿namespace PointOfSale.Assets
{
    partial class ReciptBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvoiceViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.InvoiceViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(584, 345);
            this.panel1.TabIndex = 0;
            // 
            // InvoiceViewer
            // 
            this.InvoiceViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceViewer.Location = new System.Drawing.Point(10, 10);
            this.InvoiceViewer.Name = "InvoiceViewer";
            this.InvoiceViewer.Size = new System.Drawing.Size(564, 325);
            this.InvoiceViewer.TabIndex = 0;
            // 
            // ReciptBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReciptBox";
            this.Size = new System.Drawing.Size(584, 345);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Microsoft.Reporting.WinForms.ReportViewer InvoiceViewer;
    }
}
