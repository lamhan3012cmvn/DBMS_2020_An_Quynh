namespace DBMS_2020.Features.Admin
{
    partial class Admin
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
            this.pnl_Admin = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.lbl_Staff = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Menu = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Customer = new Guna.UI.WinForms.GunaLabel();
            this.lbl_bracnh = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Admin.Location = new System.Drawing.Point(0, 51);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(884, 473);
            this.pnl_Admin.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.lbl_Staff);
            this.pnl_Menu.Controls.Add(this.lbl_Menu);
            this.pnl_Menu.Controls.Add(this.lbl_Customer);
            this.pnl_Menu.Controls.Add(this.lbl_bracnh);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(884, 51);
            this.pnl_Menu.TabIndex = 2;
            // 
            // lbl_Staff
            // 
            this.lbl_Staff.AutoSize = true;
            this.lbl_Staff.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_Staff.Location = new System.Drawing.Point(387, 14);
            this.lbl_Staff.Name = "lbl_Staff";
            this.lbl_Staff.Size = new System.Drawing.Size(101, 25);
            this.lbl_Staff.TabIndex = 6;
            this.lbl_Staff.Text = "Nhân Viên";
            this.lbl_Staff.Click += new System.EventHandler(this.lbl_Staff_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_Menu.Location = new System.Drawing.Point(308, 14);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(61, 25);
            this.lbl_Menu.TabIndex = 5;
            this.lbl_Menu.Text = "Menu";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_Customer.Location = new System.Drawing.Point(177, 14);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(114, 25);
            this.lbl_Customer.TabIndex = 4;
            this.lbl_Customer.Text = "Khách Hàng";
            this.lbl_Customer.Click += new System.EventHandler(this.lbl_Customer_Click);
            // 
            // lbl_bracnh
            // 
            this.lbl_bracnh.AutoSize = true;
            this.lbl_bracnh.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_bracnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_bracnh.Location = new System.Drawing.Point(49, 14);
            this.lbl_bracnh.Name = "lbl_bracnh";
            this.lbl_bracnh.Size = new System.Drawing.Size(102, 25);
            this.lbl_bracnh.TabIndex = 3;
            this.lbl_bracnh.Text = "Chi Nhánh";
            this.lbl_bracnh.Click += new System.EventHandler(this.lbl_bracnh_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Admin);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(884, 524);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Admin;
        private Guna.UI.WinForms.GunaPanel pnl_Menu;
        private Guna.UI.WinForms.GunaLabel lbl_Staff;
        private Guna.UI.WinForms.GunaLabel lbl_Menu;
        private Guna.UI.WinForms.GunaLabel lbl_Customer;
        private Guna.UI.WinForms.GunaLabel lbl_bracnh;
    }
}
