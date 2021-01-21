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
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(884, 524);
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
            this.pnl_form.Location = new System.Drawing.Point(377, 0);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(507, 524);
            this.pnl_form.TabIndex = 1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.rd_Manager);
            this.gunaPanel1.Controls.Add(this.rd_Staff);
            this.gunaPanel1.Location = new System.Drawing.Point(80, 303);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(407, 54);
            this.gunaPanel1.TabIndex = 9;
            // 
            // rd_Manager
            // 
            this.rd_Manager.BaseColor = System.Drawing.SystemColors.Control;
            this.rd_Manager.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_Manager.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_Manager.FillColor = System.Drawing.Color.White;
            this.rd_Manager.Location = new System.Drawing.Point(203, 15);
            this.rd_Manager.Name = "rd_Manager";
            this.rd_Manager.Size = new System.Drawing.Size(72, 20);
            this.rd_Manager.TabIndex = 1;
            this.rd_Manager.Text = "Quản Lý";
            // 
            // rd_Staff
            // 
            this.rd_Staff.BaseColor = System.Drawing.SystemColors.Control;
            this.rd_Staff.CheckedOffColor = System.Drawing.Color.Gray;
            this.rd_Staff.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rd_Staff.FillColor = System.Drawing.Color.White;
            this.rd_Staff.Location = new System.Drawing.Point(76, 15);
            this.rd_Staff.Name = "rd_Staff";
            this.rd_Staff.Size = new System.Drawing.Size(82, 20);
            this.rd_Staff.TabIndex = 0;
            this.rd_Staff.Text = "Nhân Viên";
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_forgot.Location = new System.Drawing.Point(400, 454);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(67, 25);
            this.lbl_forgot.TabIndex = 8;
            this.lbl_forgot.Text = "Forgot";
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
            this.btn_login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_login.Location = new System.Drawing.Point(183, 363);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_login.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_login.Radius = 20;
            this.btn_login.Size = new System.Drawing.Size(160, 42);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txt_password.Location = new System.Drawing.Point(119, 243);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(330, 35);
            this.txt_password.TabIndex = 4;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_password.Location = new System.Drawing.Point(63, 215);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 25);
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
            this.txt_user_name.Location = new System.Drawing.Point(119, 162);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.PasswordChar = '\0';
            this.txt_user_name.Size = new System.Drawing.Size(330, 35);
            this.txt_user_name.TabIndex = 2;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(63, 134);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(100, 25);
            this.lbl_user_name.TabIndex = 1;
            this.lbl_user_name.Text = "UserName";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_login.Location = new System.Drawing.Point(206, 48);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(112, 47);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // pnl_img
            // 
            this.pnl_img.Controls.Add(this.label1);
            this.pnl_img.Controls.Add(this.pbx_img);
            this.pnl_img.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_img.Location = new System.Drawing.Point(0, 0);
            this.pnl_img.Name = "pnl_img";
            this.pnl_img.Size = new System.Drawing.Size(377, 524);
            this.pnl_img.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kiếm cái hình banner để vào gắn lên picture";
            // 
            // pbx_img
            // 
            this.pbx_img.BaseColor = System.Drawing.Color.White;
            this.pbx_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx_img.Location = new System.Drawing.Point(0, 0);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(377, 524);
            this.pbx_img.TabIndex = 0;
            this.pbx_img.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Login);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(884, 524);
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
