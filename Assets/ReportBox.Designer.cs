namespace PointOfSale.Assets
{
    partial class ReportBox
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
            this.From = new System.Windows.Forms.DateTimePicker();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesomeIcons.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RV = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // From
            // 
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From.Location = new System.Drawing.Point(54, 6);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(96, 20);
            this.From.TabIndex = 0;
            // 
            // To
            // 
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To.Location = new System.Drawing.Point(185, 6);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(96, 20);
            this.To.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // iconButton1
            // 
            this.iconButton1.ActiveColor = System.Drawing.Color.Yellow;
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconType = FontAwesomeIcons.IconType.Check;
            this.iconButton1.InActiveColor = System.Drawing.Color.FloralWhite;
            this.iconButton1.Location = new System.Drawing.Point(287, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 23);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TabStop = false;
            this.iconButton1.ToolTipText = null;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RV);
            this.panel1.Location = new System.Drawing.Point(14, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 403);
            this.panel1.TabIndex = 6;
            // 
            // RV
            // 
            this.RV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RV.Location = new System.Drawing.Point(0, 0);
            this.RV.Name = "RV";
            this.RV.Size = new System.Drawing.Size(564, 403);
            this.RV.TabIndex = 1;
            this.RV.Load += new System.EventHandler(this.RV_Load_1);
            // 
            // ReportBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Name = "ReportBox";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(590, 448);
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesomeIcons.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        public Microsoft.Reporting.WinForms.ReportViewer RV;
    }
}
