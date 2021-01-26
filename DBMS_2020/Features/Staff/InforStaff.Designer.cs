namespace DBMS_2020.Features.Staff
{
    partial class InforStaff
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
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.txt_DaBan = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.btn_save = new Guna.UI.WinForms.GunaButton();
            this.cb_ChangePassword = new Guna.UI.WinForms.GunaCheckBox();
            this.pnl_ChangePassword = new Guna.UI.WinForms.GunaPanel();
            this.txt_PasswordConfim = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PasswordNew = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PasswordOld = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_NameBranch = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PhoneNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Dob = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Control.SuspendLayout();
            this.pnl_ChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.AnimationHoverSpeed = 0.07F;
            this.btn_Back.AnimationSpeed = 0.03F;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.BorderColor = System.Drawing.Color.White;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = global::DBMS_2020.Properties.Resources.back;
            this.btn_Back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Back.Location = new System.Drawing.Point(21, 15);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Back.Radius = 20;
            this.btn_Back.Size = new System.Drawing.Size(141, 52);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.txt_DaBan);
            this.pnl_Control.Controls.Add(this.gunaLabel9);
            this.pnl_Control.Controls.Add(this.btn_save);
            this.pnl_Control.Controls.Add(this.cb_ChangePassword);
            this.pnl_Control.Controls.Add(this.pnl_ChangePassword);
            this.pnl_Control.Controls.Add(this.txt_NameBranch);
            this.pnl_Control.Controls.Add(this.gunaLabel5);
            this.pnl_Control.Controls.Add(this.txt_PhoneNumber);
            this.pnl_Control.Controls.Add(this.gunaLabel4);
            this.pnl_Control.Controls.Add(this.txt_Dob);
            this.pnl_Control.Controls.Add(this.gunaLabel2);
            this.pnl_Control.Controls.Add(this.txt_Name);
            this.pnl_Control.Controls.Add(this.gunaLabel1);
            this.pnl_Control.Controls.Add(this.txt_Code);
            this.pnl_Control.Controls.Add(this.lbl_user_name);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Control.Location = new System.Drawing.Point(0, 91);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1179, 554);
            this.pnl_Control.TabIndex = 25;
            // 
            // txt_DaBan
            // 
            this.txt_DaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_DaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DaBan.Enabled = false;
            this.txt_DaBan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_DaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.LineSize = 2;
            this.txt_DaBan.Location = new System.Drawing.Point(101, 364);
            this.txt_DaBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DaBan.Name = "txt_DaBan";
            this.txt_DaBan.PasswordChar = '\0';
            this.txt_DaBan.Size = new System.Drawing.Size(315, 43);
            this.txt_DaBan.TabIndex = 53;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel9.Location = new System.Drawing.Point(64, 336);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(72, 25);
            this.gunaLabel9.TabIndex = 52;
            this.gunaLabel9.Text = "Đã Bán";
            // 
            // btn_save
            // 
            this.btn_save.AnimationHoverSpeed = 0.07F;
            this.btn_save.AnimationSpeed = 0.03F;
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.BorderColor = System.Drawing.Color.Black;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = global::DBMS_2020.Properties.Resources.sacek;
            this.btn_save.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_save.Location = new System.Drawing.Point(868, 466);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_save.Radius = 20;
            this.btn_save.Size = new System.Drawing.Size(236, 52);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_ChangePassword
            // 
            this.cb_ChangePassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.cb_ChangePassword.CheckedOffColor = System.Drawing.Color.Black;
            this.cb_ChangePassword.CheckedOnColor = System.Drawing.Color.White;
            this.cb_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.cb_ChangePassword.Location = new System.Drawing.Point(633, 234);
            this.cb_ChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ChangePassword.Name = "cb_ChangePassword";
            this.cb_ChangePassword.Size = new System.Drawing.Size(109, 20);
            this.cb_ChangePassword.TabIndex = 50;
            this.cb_ChangePassword.Text = "Đổi mật khẩu";
            this.cb_ChangePassword.CheckedChanged += new System.EventHandler(this.cb_ChangePassword_CheckedChanged);
            // 
            // pnl_ChangePassword
            // 
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordConfim);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel8);
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordNew);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel7);
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordOld);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel6);
            this.pnl_ChangePassword.Location = new System.Drawing.Point(605, 263);
            this.pnl_ChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ChangePassword.Name = "pnl_ChangePassword";
            this.pnl_ChangePassword.Size = new System.Drawing.Size(455, 167);
            this.pnl_ChangePassword.TabIndex = 49;
            this.pnl_ChangePassword.Visible = false;
            // 
            // txt_PasswordConfim
            // 
            this.txt_PasswordConfim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_PasswordConfim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordConfim.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordConfim.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_PasswordConfim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordConfim.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordConfim.LineSize = 2;
            this.txt_PasswordConfim.Location = new System.Drawing.Point(148, 105);
            this.txt_PasswordConfim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PasswordConfim.Name = "txt_PasswordConfim";
            this.txt_PasswordConfim.PasswordChar = '*';
            this.txt_PasswordConfim.Size = new System.Drawing.Size(236, 43);
            this.txt_PasswordConfim.TabIndex = 52;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel8.Location = new System.Drawing.Point(12, 118);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(126, 25);
            this.gunaLabel8.TabIndex = 51;
            this.gunaLabel8.Text = "Xác Nhận MK";
            // 
            // txt_PasswordNew
            // 
            this.txt_PasswordNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_PasswordNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordNew.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordNew.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_PasswordNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordNew.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordNew.LineSize = 2;
            this.txt_PasswordNew.Location = new System.Drawing.Point(148, 55);
            this.txt_PasswordNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PasswordNew.Name = "txt_PasswordNew";
            this.txt_PasswordNew.PasswordChar = '*';
            this.txt_PasswordNew.Size = new System.Drawing.Size(236, 43);
            this.txt_PasswordNew.TabIndex = 50;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel7.Location = new System.Drawing.Point(12, 68);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(131, 25);
            this.gunaLabel7.TabIndex = 49;
            this.gunaLabel7.Text = "Mật Khẩu Mới";
            // 
            // txt_PasswordOld
            // 
            this.txt_PasswordOld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_PasswordOld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PasswordOld.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordOld.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_PasswordOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordOld.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PasswordOld.LineSize = 2;
            this.txt_PasswordOld.Location = new System.Drawing.Point(148, 5);
            this.txt_PasswordOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PasswordOld.Name = "txt_PasswordOld";
            this.txt_PasswordOld.PasswordChar = '*';
            this.txt_PasswordOld.Size = new System.Drawing.Size(236, 43);
            this.txt_PasswordOld.TabIndex = 48;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel6.Location = new System.Drawing.Point(12, 17);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(121, 25);
            this.gunaLabel6.TabIndex = 47;
            this.gunaLabel6.Text = "Mật Khẩu Cũ";
            // 
            // txt_NameBranch
            // 
            this.txt_NameBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_NameBranch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameBranch.Enabled = false;
            this.txt_NameBranch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_NameBranch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_NameBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_NameBranch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_NameBranch.LineSize = 2;
            this.txt_NameBranch.Location = new System.Drawing.Point(675, 155);
            this.txt_NameBranch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NameBranch.Name = "txt_NameBranch";
            this.txt_NameBranch.PasswordChar = '\0';
            this.txt_NameBranch.Size = new System.Drawing.Size(315, 43);
            this.txt_NameBranch.TabIndex = 48;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel5.Location = new System.Drawing.Point(600, 127);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(136, 25);
            this.gunaLabel5.TabIndex = 47;
            this.gunaLabel5.Text = "Tên Chi Nhánh";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhoneNumber.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.LineSize = 2;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(675, 50);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PasswordChar = '\0';
            this.txt_PhoneNumber.Size = new System.Drawing.Size(315, 43);
            this.txt_PhoneNumber.TabIndex = 46;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel4.Location = new System.Drawing.Point(600, 22);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel4.TabIndex = 45;
            this.gunaLabel4.Text = "Số Điện Thoại";
            // 
            // txt_Dob
            // 
            this.txt_Dob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Dob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Dob.Enabled = false;
            this.txt_Dob.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Dob.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Dob.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Dob.LineSize = 2;
            this.txt_Dob.Location = new System.Drawing.Point(100, 262);
            this.txt_Dob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Dob.Name = "txt_Dob";
            this.txt_Dob.PasswordChar = '\0';
            this.txt_Dob.Size = new System.Drawing.Size(315, 43);
            this.txt_Dob.TabIndex = 42;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(63, 234);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel2.TabIndex = 41;
            this.gunaLabel2.Text = "Ngày Sinh";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.LineSize = 2;
            this.txt_Name.Location = new System.Drawing.Point(100, 155);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(315, 43);
            this.txt_Name.TabIndex = 40;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(63, 127);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(70, 25);
            this.gunaLabel1.TabIndex = 39;
            this.gunaLabel1.Text = "Họ Tên";
            // 
            // txt_Code
            // 
            this.txt_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Code.Enabled = false;
            this.txt_Code.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.LineSize = 2;
            this.txt_Code.Location = new System.Drawing.Point(100, 50);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.Size = new System.Drawing.Size(315, 43);
            this.txt_Code.TabIndex = 38;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(63, 22);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(133, 25);
            this.lbl_user_name.TabIndex = 37;
            this.lbl_user_name.Text = "Mã Nhân Viên";
            // 
            // InforStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.btn_Back);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InforStaff";
            this.Size = new System.Drawing.Size(1179, 645);
            this.Load += new System.EventHandler(this.InforStaff_Load);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.pnl_ChangePassword.ResumeLayout(false);
            this.pnl_ChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaCheckBox cb_ChangePassword;
        private Guna.UI.WinForms.GunaPanel pnl_ChangePassword;
        private Guna.UI.WinForms.GunaLineTextBox txt_PasswordConfim;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLineTextBox txt_PasswordNew;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLineTextBox txt_PasswordOld;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLineTextBox txt_NameBranch;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLineTextBox txt_PhoneNumber;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox txt_Dob;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_Code;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaButton btn_save;
        private Guna.UI.WinForms.GunaLineTextBox txt_DaBan;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
    }
}
