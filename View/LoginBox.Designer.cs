namespace PointOfSale.View
{
    partial class LoginBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new FontAwesomeIcons.IconButton();
            this.iconButton4 = new FontAwesomeIcons.IconButton();
            this.tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesomeIcons.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesomeIcons.IconButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton4)).BeginInit();
            this.tableLayoutPanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanelLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 205);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconButton4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(285, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 42);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveColor = System.Drawing.Color.Black;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.IconType = FontAwesomeIcons.IconType.Key;
            this.btnLogin.InActiveColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(44, 36);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.ToolTipText = null;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // iconButton4
            // 
            this.iconButton4.ActiveColor = System.Drawing.Color.Black;
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton4.IconType = FontAwesomeIcons.IconType.Times;
            this.iconButton4.InActiveColor = System.Drawing.Color.DimGray;
            this.iconButton4.Location = new System.Drawing.Point(53, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(44, 36);
            this.iconButton4.TabIndex = 1;
            this.iconButton4.TabStop = false;
            this.iconButton4.ToolTipText = null;
            // 
            // tableLayoutPanelLogin
            // 
            this.tableLayoutPanelLogin.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelLogin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelLogin.ColumnCount = 3;
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelLogin.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.TxtUserName, 1, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.iconButton1, 2, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.TxtPwd, 1, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.iconButton2, 2, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.ErrorLabel, 0, 2);
            this.tableLayoutPanelLogin.Location = new System.Drawing.Point(21, 30);
            this.tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
            this.tableLayoutPanelLogin.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelLogin.RowCount = 3;
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLogin.Size = new System.Drawing.Size(364, 110);
            this.tableLayoutPanelLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(101, 15);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(212, 26);
            this.TxtUserName.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.ActiveColor = System.Drawing.Color.Black;
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.Enabled = false;
            this.iconButton1.IconType = FontAwesomeIcons.IconType.UserMd;
            this.iconButton1.InActiveColor = System.Drawing.Color.DimGray;
            this.iconButton1.Location = new System.Drawing.Point(321, 15);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 25);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.TabStop = false;
            this.iconButton1.ToolTipText = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPwd.Location = new System.Drawing.Point(101, 48);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(212, 26);
            this.TxtPwd.TabIndex = 6;
            this.TxtPwd.UseSystemPasswordChar = true;
            // 
            // iconButton2
            // 
            this.iconButton2.ActiveColor = System.Drawing.Color.Black;
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.Enabled = false;
            this.iconButton2.IconType = FontAwesomeIcons.IconType.Lock;
            this.iconButton2.InActiveColor = System.Drawing.Color.DimGray;
            this.iconButton2.Location = new System.Drawing.Point(321, 48);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(28, 25);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.TabStop = false;
            this.iconButton2.ToolTipText = null;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelLogin.SetColumnSpan(this.ErrorLabel, 3);
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorLabel.Location = new System.Drawing.Point(15, 78);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ErrorLabel.Size = new System.Drawing.Size(334, 20);
            this.ErrorLabel.TabIndex = 8;
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(421, 205);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginBox";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginBox";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DarkCyan;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton4)).EndInit();
            this.tableLayoutPanelLogin.ResumeLayout(false);
            this.tableLayoutPanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesomeIcons.IconButton btnLogin;
        private FontAwesomeIcons.IconButton iconButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserName;
        private FontAwesomeIcons.IconButton iconButton1;
        private System.Windows.Forms.TextBox TxtPwd;
        private FontAwesomeIcons.IconButton iconButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLabel;
    }
}