namespace DBMS_2020.Features.Staff
{
    partial class Staff
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
            this.pnl_Staff = new Guna.UI.WinForms.GunaPanel();
            this.pnl_load = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_Sell = new Guna.UI.WinForms.GunaLabel();
            this.lbl_InfoStaff = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Staff.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Staff
            // 
            this.pnl_Staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_Staff.Controls.Add(this.pnl_load);
            this.pnl_Staff.Controls.Add(this.gunaPanel1);
            this.pnl_Staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Staff.Location = new System.Drawing.Point(0, 0);
            this.pnl_Staff.Name = "pnl_Staff";
            this.pnl_Staff.Size = new System.Drawing.Size(884, 524);
            this.pnl_Staff.TabIndex = 0;
            // 
            // pnl_load
            // 
            this.pnl_load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_load.Location = new System.Drawing.Point(0, 52);
            this.pnl_load.Name = "pnl_load";
            this.pnl_load.Size = new System.Drawing.Size(884, 472);
            this.pnl_load.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.lbl_Sell);
            this.gunaPanel1.Controls.Add(this.lbl_InfoStaff);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(884, 52);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lbl_Sell
            // 
            this.lbl_Sell.AutoSize = true;
            this.lbl_Sell.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_Sell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_Sell.Location = new System.Drawing.Point(267, 12);
            this.lbl_Sell.Name = "lbl_Sell";
            this.lbl_Sell.Size = new System.Drawing.Size(94, 25);
            this.lbl_Sell.TabIndex = 8;
            this.lbl_Sell.Text = "Bán Hàng";
            this.lbl_Sell.Click += new System.EventHandler(this.lbl_Sell_Click);
            // 
            // lbl_InfoStaff
            // 
            this.lbl_InfoStaff.AutoSize = true;
            this.lbl_InfoStaff.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_InfoStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_InfoStaff.Location = new System.Drawing.Point(46, 12);
            this.lbl_InfoStaff.Name = "lbl_InfoStaff";
            this.lbl_InfoStaff.Size = new System.Drawing.Size(187, 25);
            this.lbl_InfoStaff.TabIndex = 7;
            this.lbl_InfoStaff.Text = "Thông tin Nhân Viên";
            this.lbl_InfoStaff.Click += new System.EventHandler(this.lbl_InfoStaff_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Staff);
            this.Name = "Staff";
            this.Size = new System.Drawing.Size(884, 524);
            this.pnl_Staff.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Staff;
        private Guna.UI.WinForms.GunaPanel pnl_load;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lbl_Sell;
        private Guna.UI.WinForms.GunaLabel lbl_InfoStaff;
    }
}
