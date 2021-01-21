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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InforStaff));
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.txt_NameBranch = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PhoneNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Email = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Address = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_ChangePassword = new Guna.UI.WinForms.GunaPanel();
            this.cb_ChangePassword = new Guna.UI.WinForms.GunaCheckBox();
            this.txt_PasswordOld = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PasswordNew = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PasswordConfim = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btn_save = new Guna.UI.WinForms.GunaButton();
            this.txt_DaBan = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
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
            this.btn_Back.Image = null;
            this.btn_Back.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Back.Size = new System.Drawing.Size(106, 31);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pnl_Control.Controls.Add(this.txt_Email);
            this.pnl_Control.Controls.Add(this.gunaLabel3);
            this.pnl_Control.Controls.Add(this.txt_Address);
            this.pnl_Control.Controls.Add(this.gunaLabel2);
            this.pnl_Control.Controls.Add(this.txt_Name);
            this.pnl_Control.Controls.Add(this.gunaLabel1);
            this.pnl_Control.Controls.Add(this.txt_Code);
            this.pnl_Control.Controls.Add(this.lbl_user_name);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Control.Location = new System.Drawing.Point(0, 66);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(884, 458);
            this.pnl_Control.TabIndex = 25;
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
            this.txt_NameBranch.Location = new System.Drawing.Point(506, 140);
            this.txt_NameBranch.Name = "txt_NameBranch";
            this.txt_NameBranch.PasswordChar = '\0';
            this.txt_NameBranch.Size = new System.Drawing.Size(236, 35);
            this.txt_NameBranch.TabIndex = 48;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel5.Location = new System.Drawing.Point(450, 112);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(104, 20);
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
            this.txt_PhoneNumber.Location = new System.Drawing.Point(506, 55);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PasswordChar = '\0';
            this.txt_PhoneNumber.Size = new System.Drawing.Size(236, 35);
            this.txt_PhoneNumber.TabIndex = 46;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel4.Location = new System.Drawing.Point(450, 27);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(102, 20);
            this.gunaLabel4.TabIndex = 45;
            this.gunaLabel4.Text = "Số Điện Thoại";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Email.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Email.LineSize = 2;
            this.txt_Email.Location = new System.Drawing.Point(103, 308);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.Size = new System.Drawing.Size(236, 35);
            this.txt_Email.TabIndex = 44;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel3.Location = new System.Drawing.Point(47, 280);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(46, 20);
            this.gunaLabel3.TabIndex = 43;
            this.gunaLabel3.Text = "Email";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.LineSize = 2;
            this.txt_Address.Location = new System.Drawing.Point(103, 227);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.Size = new System.Drawing.Size(236, 35);
            this.txt_Address.TabIndex = 42;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(47, 199);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel2.TabIndex = 41;
            this.gunaLabel2.Text = "Địa Chỉ";
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
            this.txt_Name.Location = new System.Drawing.Point(103, 140);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(236, 35);
            this.txt_Name.TabIndex = 40;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(47, 112);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(56, 20);
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
            this.txt_Code.Location = new System.Drawing.Point(103, 55);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.Size = new System.Drawing.Size(236, 35);
            this.txt_Code.TabIndex = 38;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(47, 27);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(102, 20);
            this.lbl_user_name.TabIndex = 37;
            this.lbl_user_name.Text = "Mã Nhân Viên";
            // 
            // pnl_ChangePassword
            // 
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordConfim);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel8);
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordNew);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel7);
            this.pnl_ChangePassword.Controls.Add(this.txt_PasswordOld);
            this.pnl_ChangePassword.Controls.Add(this.gunaLabel6);
            this.pnl_ChangePassword.Location = new System.Drawing.Point(454, 223);
            this.pnl_ChangePassword.Name = "pnl_ChangePassword";
            this.pnl_ChangePassword.Size = new System.Drawing.Size(341, 136);
            this.pnl_ChangePassword.TabIndex = 49;
            this.pnl_ChangePassword.Visible = false;
            // 
            // cb_ChangePassword
            // 
            this.cb_ChangePassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.cb_ChangePassword.CheckedOffColor = System.Drawing.Color.Black;
            this.cb_ChangePassword.CheckedOnColor = System.Drawing.Color.White;
            this.cb_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.cb_ChangePassword.Location = new System.Drawing.Point(475, 199);
            this.cb_ChangePassword.Name = "cb_ChangePassword";
            this.cb_ChangePassword.Size = new System.Drawing.Size(96, 20);
            this.cb_ChangePassword.TabIndex = 50;
            this.cb_ChangePassword.Text = "Đổi mật khẩu";
            this.cb_ChangePassword.CheckedChanged += new System.EventHandler(this.cb_ChangePassword_CheckedChanged);
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
            this.txt_PasswordOld.Location = new System.Drawing.Point(111, 4);
            this.txt_PasswordOld.Name = "txt_PasswordOld";
            this.txt_PasswordOld.PasswordChar = '\0';
            this.txt_PasswordOld.Size = new System.Drawing.Size(177, 35);
            this.txt_PasswordOld.TabIndex = 48;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel6.Location = new System.Drawing.Point(9, 14);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(93, 20);
            this.gunaLabel6.TabIndex = 47;
            this.gunaLabel6.Text = "Mật Khẩu Cũ";
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
            this.txt_PasswordNew.Location = new System.Drawing.Point(111, 45);
            this.txt_PasswordNew.Name = "txt_PasswordNew";
            this.txt_PasswordNew.PasswordChar = '\0';
            this.txt_PasswordNew.Size = new System.Drawing.Size(177, 35);
            this.txt_PasswordNew.TabIndex = 50;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel7.Location = new System.Drawing.Point(9, 55);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(102, 20);
            this.gunaLabel7.TabIndex = 49;
            this.gunaLabel7.Text = "Mật Khẩu Mới";
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
            this.txt_PasswordConfim.Location = new System.Drawing.Point(111, 85);
            this.txt_PasswordConfim.Name = "txt_PasswordConfim";
            this.txt_PasswordConfim.PasswordChar = '\0';
            this.txt_PasswordConfim.Size = new System.Drawing.Size(177, 35);
            this.txt_PasswordConfim.TabIndex = 52;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel8.Location = new System.Drawing.Point(9, 96);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(98, 20);
            this.gunaLabel8.TabIndex = 51;
            this.gunaLabel8.Text = "Xác Nhận MK";
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
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_save.Location = new System.Drawing.Point(668, 388);
            this.btn_save.Name = "btn_save";
            this.btn_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_save.OnHoverImage = null;
            this.btn_save.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_save.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_save.Radius = 20;
            this.btn_save.Size = new System.Drawing.Size(160, 42);
            this.btn_save.TabIndex = 51;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_DaBan
            // 
            this.txt_DaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_DaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DaBan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_DaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_DaBan.LineSize = 2;
            this.txt_DaBan.Location = new System.Drawing.Point(103, 388);
            this.txt_DaBan.Name = "txt_DaBan";
            this.txt_DaBan.PasswordChar = '\0';
            this.txt_DaBan.Size = new System.Drawing.Size(236, 35);
            this.txt_DaBan.TabIndex = 53;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel9.Location = new System.Drawing.Point(47, 360);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel9.TabIndex = 52;
            this.gunaLabel9.Text = "Đã Bán";
            // 
            // InforStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.btn_Back);
            this.Name = "InforStaff";
            this.Size = new System.Drawing.Size(884, 524);
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
        private Guna.UI.WinForms.GunaLineTextBox txt_Email;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox txt_Address;
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
