namespace DBMS_2020.Componets
{
    partial class heading
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
            this.lbl_login = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_NamePage = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Menu.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_login.Location = new System.Drawing.Point(264, 52);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(112, 47);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.gunaPanel3);
            this.pnl_Menu.Controls.Add(this.gunaCirclePictureBox1);
            this.pnl_Menu.Controls.Add(this.gunaLabel2);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(971, 85);
            this.pnl_Menu.TabIndex = 4;
            this.pnl_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Menu_Paint);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.lbl_NamePage);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(774, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(197, 85);
            this.gunaPanel3.TabIndex = 15;
            // 
            // lbl_NamePage
            // 
            this.lbl_NamePage.AutoSize = true;
            this.lbl_NamePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_NamePage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_NamePage.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_NamePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.lbl_NamePage.Location = new System.Drawing.Point(99, 0);
            this.lbl_NamePage.Name = "lbl_NamePage";
            this.lbl_NamePage.Size = new System.Drawing.Size(98, 25);
            this.lbl_NamePage.TabIndex = 9;
            this.lbl_NamePage.Text = "Trang Chủ";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(13, 5);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(60, 60);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 14;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.gunaLabel2.Location = new System.Drawing.Point(314, 14);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.gunaLabel2.Size = new System.Drawing.Size(261, 39);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Tiểu Lý Phi Đao";
            // 
            // heading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.lbl_login);
            this.Name = "heading";
            this.Size = new System.Drawing.Size(971, 454);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbl_login;
        private Guna.UI.WinForms.GunaPanel pnl_Menu;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLabel lbl_NamePage;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}
