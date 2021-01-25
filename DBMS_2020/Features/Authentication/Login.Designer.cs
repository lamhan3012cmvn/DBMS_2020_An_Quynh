namespace DBMS_2020.Features.Authentication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_Login = new Guna.UI.WinForms.GunaPanel();
            this.pnl_form = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.rd_Manager = new Guna.UI.WinForms.GunaRadioButton();
            this.rd_Staff = new Guna.UI.WinForms.GunaRadioButton();
            this.lbl_forgot = new Guna.UI.WinForms.GunaLabel();
            this.btn_login = new Guna.UI.WinForms.GunaButton();
            this.txt_password = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_password = new Guna.UI.WinForms.GunaLabel();
            this.txt_user_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_login = new Guna.UI.WinForms.GunaLabel();
            this.pnl_img = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_img = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_Login.SuspendLayout();
            this.pnl_form.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.pnl_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.pnl_form);
            this.pnl_Login.Controls.Add(this.pnl_img);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(1179, 645);
            this.pnl_Login.TabIndex = 0;
            // 
            // pnl_form
            // 
            this.pnl_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_form.Controls.Add(this.gunaPanel1);
            this.pnl_form.Controls.Add(this.lbl_forgot);
            this.pnl_form.Controls.Add(this.btn_login);
            this.pnl_form.Controls.Add(this.txt_password);
            this.pnl_form.Controls.Add(this.lbl_password);
            this.pnl_form.Controls.Add(this.txt_user_name);
            this.pnl_form.Controls.Add(this.lbl_user_name);
            this.pnl_form.Controls.Add(this.lbl_login);
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(503, 0);
            this.pnl_form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(676, 645);
            this.pnl_form.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.rd_Manager);
            this.gunaPanel1.Controls.Add(this.rd_Staff);
            this.gunaPanel1.Location = new System.Drawing.Point(107, 373);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(543, 66);
            this.gunaPanel1.TabIndex = 9;
            // 
            // rd_Manager
            // 
            this.rd_Manager.BaseColor = System.Drawing.Color.White;
            this.rd_Manager.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_Manager.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_Manager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.rd_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Manager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.rd_Manager.Location = new System.Drawing.Point(271, 18);
            this.rd_Manager.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Manager.Name = "rd_Manager";
            this.rd_Manager.Size = new System.Drawing.Size(94, 22);
            this.rd_Manager.TabIndex = 1;
            this.rd_Manager.Text = "Quản Lý";
            // 
            // rd_Staff
            // 
            this.rd_Staff.BaseColor = System.Drawing.Color.White;
            this.rd_Staff.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_Staff.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_Staff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.rd_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.rd_Staff.Location = new System.Drawing.Point(101, 18);
            this.rd_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.rd_Staff.Name = "rd_Staff";
            this.rd_Staff.Size = new System.Drawing.Size(109, 22);
            this.rd_Staff.TabIndex = 0;
            this.rd_Staff.Text = "Nhân Viên";
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_forgot.Location = new System.Drawing.Point(496, 589);
            this.lbl_forgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(154, 28);
            this.lbl_forgot.TabIndex = 8;
            this.lbl_forgot.Text = "Quên mật khẩu?";
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_login.Location = new System.Drawing.Point(255, 458);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_login.Radius = 20;
            this.btn_login.Size = new System.Drawing.Size(243, 58);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Animated = true;
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_password.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_password.LineSize = 2;
            this.txt_password.Location = new System.Drawing.Point(159, 299);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(440, 52);
            this.txt_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_password.Location = new System.Drawing.Point(84, 265);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(112, 32);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // txt_user_name
            // 
            this.txt_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_user_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txt_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_user_name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_user_name.LineSize = 2;
            this.txt_user_name.Location = new System.Drawing.Point(159, 199);
            this.txt_user_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.PasswordChar = '\0';
            this.txt_user_name.Size = new System.Drawing.Size(440, 52);
            this.txt_user_name.TabIndex = 2;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(84, 165);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(126, 32);
            this.lbl_user_name.TabIndex = 1;
            this.lbl_user_name.Text = "UserName";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_login.Location = new System.Drawing.Point(221, 59);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(251, 60);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Đăng nhập";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // pnl_img
            // 
            this.pnl_img.Controls.Add(this.label1);
            this.pnl_img.Controls.Add(this.pbx_img);
            this.pnl_img.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_img.Location = new System.Drawing.Point(0, 0);
            this.pnl_img.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_img.Name = "pnl_img";
            this.pnl_img.Size = new System.Drawing.Size(503, 645);
            this.pnl_img.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // pbx_img
            // 
            this.pbx_img.BaseColor = System.Drawing.Color.White;
            this.pbx_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_img.Image = global::DBMS_2020.Properties.Resources.logo1;
            this.pbx_img.Location = new System.Drawing.Point(0, 0);
            this.pbx_img.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(503, 645);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_img.TabIndex = 0;
            this.pbx_img.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Login);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1179, 645);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_form.ResumeLayout(false);
            this.pnl_form.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.pnl_img.ResumeLayout(false);
            this.pnl_img.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Login;
        private Guna.UI.WinForms.GunaPanel pnl_form;
        private Guna.UI.WinForms.GunaLineTextBox txt_user_name;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaLabel lbl_login;
        private Guna.UI.WinForms.GunaPanel pnl_img;
        private Guna.UI.WinForms.GunaLineTextBox txt_password;
        private Guna.UI.WinForms.GunaLabel lbl_password;
        private Guna.UI.WinForms.GunaButton btn_login;
        private Guna.UI.WinForms.GunaPictureBox pbx_img;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLabel lbl_forgot;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaRadioButton rd_Manager;
        private Guna.UI.WinForms.GunaRadioButton rd_Staff;
    }
}
