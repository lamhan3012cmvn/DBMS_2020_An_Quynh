namespace DBMS_2020.Features.Admin
{
    partial class ManagerCustomer
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
            this.dgv_customer = new Guna.UI.WinForms.GunaDataGridView();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.pnl_control = new Guna.UI.WinForms.GunaPanel();
            this.pnl_CRUD = new Guna.UI.WinForms.GunaPanel();
            this.txt_bought = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Del = new Guna.UI.WinForms.GunaButton();
            this.btn_Update = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.txt_Address = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_PhoneNumber = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.txt_SearchCustomer = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_SearchName = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.pnl_control.SuspendLayout();
            this.pnl_CRUD.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_customer.ColumnHeadersHeight = 50;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPhone,
            this.cName,
            this.cAdress,
            this.cIsPay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_customer.Location = new System.Drawing.Point(0, 71);
            this.dgv_customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customer.Size = new System.Drawing.Size(793, 574);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_customer.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_customer.ThemeStyle.ReadOnly = false;
            this.dgv_customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_customer.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "SĐT";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên Khách Hàng";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            // 
            // cAdress
            // 
            this.cAdress.HeaderText = "Dịa Chỉ";
            this.cAdress.MinimumWidth = 6;
            this.cAdress.Name = "cAdress";
            // 
            // cIsPay
            // 
            this.cIsPay.HeaderText = "Đã Mua";
            this.cIsPay.MinimumWidth = 6;
            this.cIsPay.Name = "cIsPay";
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_data.Controls.Add(this.btn_Back);
            this.pnl_data.Controls.Add(this.dgv_customer);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(793, 645);
            this.pnl_data.TabIndex = 2;
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
            this.btn_Back.Location = new System.Drawing.Point(16, 10);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Back.Radius = 20;
            this.btn_Back.Size = new System.Drawing.Size(151, 53);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_control
            // 
            this.pnl_control.Controls.Add(this.pnl_CRUD);
            this.pnl_control.Controls.Add(this.pnl_Search);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_control.Location = new System.Drawing.Point(793, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(386, 645);
            this.pnl_control.TabIndex = 3;
            // 
            // pnl_CRUD
            // 
            this.pnl_CRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_CRUD.Controls.Add(this.txt_bought);
            this.pnl_CRUD.Controls.Add(this.gunaLabel3);
            this.pnl_CRUD.Controls.Add(this.btn_Del);
            this.pnl_CRUD.Controls.Add(this.btn_Update);
            this.pnl_CRUD.Controls.Add(this.btn_Add);
            this.pnl_CRUD.Controls.Add(this.txt_Address);
            this.pnl_CRUD.Controls.Add(this.gunaLabel2);
            this.pnl_CRUD.Controls.Add(this.txt_Name);
            this.pnl_CRUD.Controls.Add(this.gunaLabel1);
            this.pnl_CRUD.Controls.Add(this.txt_PhoneNumber);
            this.pnl_CRUD.Controls.Add(this.lbl_user_name);
            this.pnl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CRUD.Location = new System.Drawing.Point(0, 101);
            this.pnl_CRUD.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_CRUD.Name = "pnl_CRUD";
            this.pnl_CRUD.Size = new System.Drawing.Size(386, 544);
            this.pnl_CRUD.TabIndex = 14;
            // 
            // txt_bought
            // 
            this.txt_bought.Animated = true;
            this.txt_bought.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_bought.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bought.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_bought.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bought.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_bought.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_bought.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_bought.LineSize = 2;
            this.txt_bought.Location = new System.Drawing.Point(25, 320);
            this.txt_bought.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bought.Name = "txt_bought";
            this.txt_bought.PasswordChar = '\0';
            this.txt_bought.Size = new System.Drawing.Size(108, 42);
            this.txt_bought.TabIndex = 23;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel3.Location = new System.Drawing.Point(20, 290);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 25);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "SL Đã Mua";
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
            this.btn_Del.Image = global::DBMS_2020.Properties.Resources.updated;
            this.btn_Del.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Del.Location = new System.Drawing.Point(20, 415);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverImage = null;
            this.btn_Del.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Del.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Del.Radius = 20;
            this.btn_Del.Size = new System.Drawing.Size(151, 52);
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
            this.btn_Update.Image = global::DBMS_2020.Properties.Resources.delete;
            this.btn_Update.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Update.Location = new System.Drawing.Point(208, 415);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Update.OnHoverImage = null;
            this.btn_Update.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Update.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Update.Radius = 20;
            this.btn_Update.Size = new System.Drawing.Size(151, 52);
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
            this.btn_Add.Location = new System.Drawing.Point(208, 341);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Add.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Add.Radius = 20;
            this.btn_Add.Size = new System.Drawing.Size(151, 52);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Animated = true;
            this.txt_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Address.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Address.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.LineSize = 2;
            this.txt_Address.Location = new System.Drawing.Point(25, 229);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.Size = new System.Drawing.Size(307, 42);
            this.txt_Address.TabIndex = 18;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(20, 199);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 25);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Địa Chỉ";
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
            this.txt_Name.Location = new System.Drawing.Point(25, 139);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(301, 44);
            this.txt_Name.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(20, 110);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(148, 25);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Tên Khách Hàng";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Animated = true;
            this.txt_PhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_PhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PhoneNumber.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_PhoneNumber.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_PhoneNumber.LineSize = 2;
            this.txt_PhoneNumber.Location = new System.Drawing.Point(25, 46);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PasswordChar = '\0';
            this.txt_PhoneNumber.Size = new System.Drawing.Size(292, 42);
            this.txt_PhoneNumber.TabIndex = 14;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(20, 16);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(129, 25);
            this.lbl_user_name.TabIndex = 13;
            this.lbl_user_name.Text = "Số Điện Thoại";
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_Search.Controls.Add(this.txt_SearchCustomer);
            this.pnl_Search.Controls.Add(this.txt_SearchName);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(386, 101);
            this.pnl_Search.TabIndex = 13;
            // 
            // txt_SearchCustomer
            // 
            this.txt_SearchCustomer.Animated = true;
            this.txt_SearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_SearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchCustomer.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchCustomer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SearchCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchCustomer.LineSize = 2;
            this.txt_SearchCustomer.Location = new System.Drawing.Point(233, 43);
            this.txt_SearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchCustomer.Name = "txt_SearchCustomer";
            this.txt_SearchCustomer.PasswordChar = '\0';
            this.txt_SearchCustomer.Size = new System.Drawing.Size(149, 42);
            this.txt_SearchCustomer.TabIndex = 22;
            this.txt_SearchCustomer.TextChanged += new System.EventHandler(this.txt_SearchCustomer_TextChanged);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.AutoSize = true;
            this.txt_SearchName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchName.Location = new System.Drawing.Point(135, 52);
            this.txt_SearchName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.Size = new System.Drawing.Size(90, 25);
            this.txt_SearchName.TabIndex = 21;
            this.txt_SearchName.Text = "Tìm Kiếm";
            // 
            // ManagerCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_control);
            this.Controls.Add(this.pnl_data);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerCustomer";
            this.Size = new System.Drawing.Size(1179, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.pnl_control.ResumeLayout(false);
            this.pnl_CRUD.ResumeLayout(false);
            this.pnl_CRUD.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_customer;
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private Guna.UI.WinForms.GunaPanel pnl_control;
        private Guna.UI.WinForms.GunaPanel pnl_CRUD;
        private Guna.UI.WinForms.GunaButton btn_Del;
        private Guna.UI.WinForms.GunaButton btn_Update;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaLineTextBox txt_Address;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_PhoneNumber;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLineTextBox txt_SearchCustomer;
        private Guna.UI.WinForms.GunaLabel txt_SearchName;
        private Guna.UI.WinForms.GunaLineTextBox txt_bought;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIsPay;
    }
}
