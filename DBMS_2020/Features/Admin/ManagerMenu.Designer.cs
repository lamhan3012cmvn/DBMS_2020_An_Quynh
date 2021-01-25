namespace DBMS_2020.Features.Admin
{
    partial class ManagerMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_control = new Guna.UI.WinForms.GunaPanel();
            this.pnl_CRUD = new Guna.UI.WinForms.GunaPanel();
            this.picb_img = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btn_Del = new Guna.UI.WinForms.GunaButton();
            this.btn_Update = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.txt_Price = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SearchName = new Guna.UI.WinForms.GunaLabel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.dgv_Menu = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_control.SuspendLayout();
            this.pnl_CRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_img)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_control.Controls.Add(this.pnl_CRUD);
            this.pnl_control.Controls.Add(this.pnl_Search);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_control.Location = new System.Drawing.Point(599, 0);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(285, 524);
            this.pnl_control.TabIndex = 3;
            // 
            // pnl_CRUD
            // 
            this.pnl_CRUD.Controls.Add(this.picb_img);
            this.pnl_CRUD.Controls.Add(this.btn_Del);
            this.pnl_CRUD.Controls.Add(this.btn_Update);
            this.pnl_CRUD.Controls.Add(this.btn_Add);
            this.pnl_CRUD.Controls.Add(this.txt_Price);
            this.pnl_CRUD.Controls.Add(this.gunaLabel2);
            this.pnl_CRUD.Controls.Add(this.txt_Name);
            this.pnl_CRUD.Controls.Add(this.gunaLabel1);
            this.pnl_CRUD.Controls.Add(this.txt_Code);
            this.pnl_CRUD.Controls.Add(this.lbl_user_name);
            this.pnl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CRUD.Location = new System.Drawing.Point(0, 95);
            this.pnl_CRUD.Name = "pnl_CRUD";
            this.pnl_CRUD.Size = new System.Drawing.Size(285, 429);
            this.pnl_CRUD.TabIndex = 14;
            // 
            // picb_img
            // 
            this.picb_img.BaseColor = System.Drawing.Color.White;
            this.picb_img.Image = global::DBMS_2020.Properties.Resources.add;
            this.picb_img.Location = new System.Drawing.Point(6, 225);
            this.picb_img.Name = "picb_img";
            this.picb_img.Size = new System.Drawing.Size(147, 157);
            this.picb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_img.TabIndex = 22;
            this.picb_img.TabStop = false;
            this.picb_img.UseTransfarantBackground = false;
            this.picb_img.Click += new System.EventHandler(this.picb_img_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.AnimationHoverSpeed = 0.07F;
            this.btn_Del.AnimationSpeed = 0.03F;
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.BorderColor = System.Drawing.Color.Black;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Del.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Image = global::DBMS_2020.Properties.Resources.delete;
            this.btn_Del.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Del.Location = new System.Drawing.Point(169, 339);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverImage = null;
            this.btn_Del.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Del.Radius = 20;
            this.btn_Del.Size = new System.Drawing.Size(113, 42);
            this.btn_Del.TabIndex = 21;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.AnimationHoverSpeed = 0.07F;
            this.btn_Update.AnimationSpeed = 0.03F;
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.BorderColor = System.Drawing.Color.Black;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Image = global::DBMS_2020.Properties.Resources.updated;
            this.btn_Update.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Update.Location = new System.Drawing.Point(169, 281);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Update.OnHoverImage = null;
            this.btn_Update.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Update.Radius = 20;
            this.btn_Update.Size = new System.Drawing.Size(113, 42);
            this.btn_Update.TabIndex = 20;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::DBMS_2020.Properties.Resources.add;
            this.btn_Add.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Add.Location = new System.Drawing.Point(169, 225);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Add.Radius = 20;
            this.btn_Add.Size = new System.Drawing.Size(113, 42);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Animated = true;
            this.txt_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Price.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Price.LineSize = 2;
            this.txt_Price.Location = new System.Drawing.Point(19, 170);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.Size = new System.Drawing.Size(226, 34);
            this.txt_Price.TabIndex = 18;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(15, 146);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(31, 20);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Giá";
            // 
            // txt_Name
            // 
            this.txt_Name.Animated = true;
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.LineSize = 2;
            this.txt_Name.Location = new System.Drawing.Point(19, 107);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(226, 34);
            this.txt_Name.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(15, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Tên Món";
            // 
            // txt_Code
            // 
            this.txt_Code.Animated = true;
            this.txt_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Code.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Code.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.LineSize = 2;
            this.txt_Code.Location = new System.Drawing.Point(19, 40);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.Size = new System.Drawing.Size(226, 34);
            this.txt_Code.TabIndex = 14;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(16, 16);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(64, 20);
            this.lbl_user_name.TabIndex = 13;
            this.lbl_user_name.Text = "Mã Món";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.gunaLineTextBox1);
            this.pnl_Search.Controls.Add(this.txt_SearchName);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(285, 95);
            this.pnl_Search.TabIndex = 13;
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.Animated = true;
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLineTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLineTextBox1.LineSize = 2;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(112, 39);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '*';
            this.gunaLineTextBox1.Size = new System.Drawing.Size(117, 42);
            this.gunaLineTextBox1.TabIndex = 22;
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.AutoSize = true;
            this.txt_SearchName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchName.Location = new System.Drawing.Point(38, 39);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(72, 20);
            this.txt_SearchName.TabIndex = 21;
            this.txt_SearchName.Text = "Tìm Kiếm";
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
            this.btn_Back.Location = new System.Drawing.Point(14, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_Back.Radius = 20;
            this.btn_Back.Size = new System.Drawing.Size(110, 41);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_data.Controls.Add(this.btn_Back);
            this.pnl_data.Controls.Add(this.dgv_Menu);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(599, 524);
            this.pnl_data.TabIndex = 2;
            // 
            // dgv_Menu
            // 
            this.dgv_Menu.AllowUserToAddRows = false;
            this.dgv_Menu.AllowUserToDeleteRows = false;
            this.dgv_Menu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Menu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Menu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Menu.ColumnHeadersHeight = 50;
            this.dgv_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.cIsSell});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Menu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Menu.EnableHeadersVisualStyles = false;
            this.dgv_Menu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_Menu.Location = new System.Drawing.Point(0, 62);
            this.dgv_Menu.Name = "dgv_Menu";
            this.dgv_Menu.RowHeadersVisible = false;
            this.dgv_Menu.RowHeadersWidth = 51;
            this.dgv_Menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Menu.Size = new System.Drawing.Size(599, 462);
            this.dgv_Menu.TabIndex = 1;
            this.dgv_Menu.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Menu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_Menu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Menu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_Menu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_Menu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_Menu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Menu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Menu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Menu.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_Menu.ThemeStyle.ReadOnly = false;
            this.dgv_Menu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Menu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Menu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_Menu.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_Menu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_Menu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_Menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Menu_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Món";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Món";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Tiền";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // cIsSell
            // 
            this.cIsSell.HeaderText = "Đã bán";
            this.cIsSell.MinimumWidth = 6;
            this.cIsSell.Name = "cIsSell";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_control);
            this.Controls.Add(this.pnl_data);
            this.Name = "ManagerMenu";
            this.Size = new System.Drawing.Size(884, 524);
            this.pnl_control.ResumeLayout(false);
            this.pnl_CRUD.ResumeLayout(false);
            this.pnl_CRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_img)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_control;
        private Guna.UI.WinForms.GunaPanel pnl_CRUD;
        private Guna.UI.WinForms.GunaCirclePictureBox picb_img;
        private Guna.UI.WinForms.GunaButton btn_Del;
        private Guna.UI.WinForms.GunaButton btn_Update;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaLineTextBox txt_Price;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_Code;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLabel txt_SearchName;
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private Guna.UI.WinForms.GunaDataGridView dgv_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIsSell;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
