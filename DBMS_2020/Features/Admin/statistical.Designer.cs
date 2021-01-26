namespace DBMS_2020.Features.Admin
{
    partial class Statistical
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
            this.pnl_back = new Guna.UI.WinForms.GunaPanel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.pnl_btn = new Guna.UI.WinForms.GunaPanel();
            this.btn_Staff = new Guna.UI.WinForms.GunaButton();
            this.btn_Menu = new Guna.UI.WinForms.GunaButton();
            this.btn_Customer = new Guna.UI.WinForms.GunaButton();
            this.btn_Branch = new Guna.UI.WinForms.GunaButton();
            this.pnl_Data = new Guna.UI.WinForms.GunaPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_data = new Guna.UI.WinForms.GunaDataGridView();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_back.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.pnl_Data.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_back
            // 
            this.pnl_back.Controls.Add(this.btn_Back);
            this.pnl_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_back.Location = new System.Drawing.Point(0, 0);
            this.pnl_back.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_back.Name = "pnl_back";
            this.pnl_back.Size = new System.Drawing.Size(1179, 70);
            this.pnl_back.TabIndex = 0;
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
            this.btn_Back.Location = new System.Drawing.Point(4, 11);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Back.Radius = 20;
            this.btn_Back.Size = new System.Drawing.Size(155, 52);
            this.btn_Back.TabIndex = 24;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_btn
            // 
            this.pnl_btn.Controls.Add(this.btn_Staff);
            this.pnl_btn.Controls.Add(this.btn_Menu);
            this.pnl_btn.Controls.Add(this.btn_Customer);
            this.pnl_btn.Controls.Add(this.btn_Branch);
            this.pnl_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_btn.Location = new System.Drawing.Point(0, 70);
            this.pnl_btn.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(421, 575);
            this.pnl_btn.TabIndex = 2;
            // 
            // btn_Staff
            // 
            this.btn_Staff.AnimationHoverSpeed = 0.07F;
            this.btn_Staff.AnimationSpeed = 0.03F;
            this.btn_Staff.BackColor = System.Drawing.Color.Transparent;
            this.btn_Staff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Staff.BorderColor = System.Drawing.Color.Black;
            this.btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Staff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Staff.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Staff.ForeColor = System.Drawing.Color.White;
            this.btn_Staff.Image = global::DBMS_2020.Properties.Resources.staffs;
            this.btn_Staff.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Staff.Location = new System.Drawing.Point(56, 420);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Staff.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Staff.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Staff.OnHoverImage = null;
            this.btn_Staff.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Staff.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Staff.Radius = 20;
            this.btn_Staff.Size = new System.Drawing.Size(325, 52);
            this.btn_Staff.TabIndex = 45;
            this.btn_Staff.Text = "Top Nhân Viên";
            this.btn_Staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.AnimationHoverSpeed = 0.07F;
            this.btn_Menu.AnimationSpeed = 0.03F;
            this.btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Menu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Menu.BorderColor = System.Drawing.Color.Black;
            this.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Menu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Menu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Image = global::DBMS_2020.Properties.Resources.menu;
            this.btn_Menu.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Menu.Location = new System.Drawing.Point(47, 330);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Menu.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Menu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Menu.OnHoverImage = null;
            this.btn_Menu.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Menu.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Menu.Radius = 20;
            this.btn_Menu.Size = new System.Drawing.Size(325, 52);
            this.btn_Menu.TabIndex = 44;
            this.btn_Menu.Text = "Top Menu";
            this.btn_Menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.AnimationHoverSpeed = 0.07F;
            this.btn_Customer.AnimationSpeed = 0.03F;
            this.btn_Customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Customer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Customer.BorderColor = System.Drawing.Color.Black;
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Customer.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Customer.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Image = global::DBMS_2020.Properties.Resources.customer;
            this.btn_Customer.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Customer.Location = new System.Drawing.Point(56, 238);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Customer.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Customer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Customer.OnHoverImage = null;
            this.btn_Customer.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Customer.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Customer.Radius = 20;
            this.btn_Customer.Size = new System.Drawing.Size(325, 52);
            this.btn_Customer.TabIndex = 43;
            this.btn_Customer.Text = "Top Khách Hàng";
            this.btn_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Branch
            // 
            this.btn_Branch.AnimationHoverSpeed = 0.07F;
            this.btn_Branch.AnimationSpeed = 0.03F;
            this.btn_Branch.BackColor = System.Drawing.Color.Transparent;
            this.btn_Branch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Branch.BorderColor = System.Drawing.Color.Black;
            this.btn_Branch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Branch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Branch.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Branch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_Branch.ForeColor = System.Drawing.Color.White;
            this.btn_Branch.Image = global::DBMS_2020.Properties.Resources.branch;
            this.btn_Branch.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Branch.Location = new System.Drawing.Point(56, 153);
            this.btn_Branch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Branch.Name = "btn_Branch";
            this.btn_Branch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Branch.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Branch.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Branch.OnHoverImage = null;
            this.btn_Branch.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Branch.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Branch.Radius = 20;
            this.btn_Branch.Size = new System.Drawing.Size(325, 52);
            this.btn_Branch.TabIndex = 42;
            this.btn_Branch.Text = "Top Chi Nhánh";
            this.btn_Branch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Branch.Click += new System.EventHandler(this.btn_Branch_Click);
            // 
            // pnl_Data
            // 
            this.pnl_Data.Controls.Add(this.panel2);
            this.pnl_Data.Controls.Add(this.panel1);
            this.pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Data.Location = new System.Drawing.Point(421, 70);
            this.pnl_Data.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Data.Name = "pnl_Data";
            this.pnl_Data.Size = new System.Drawing.Size(758, 575);
            this.pnl_Data.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 475);
            this.panel2.TabIndex = 1;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeight = 50;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.cName,
            this.cPhone,
            this.cDate,
            this.cBranch,
            this.cSellNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_data.Location = new System.Drawing.Point(0, 0);
            this.dgv_data.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersVisible = false;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(758, 475);
            this.dgv_data.TabIndex = 3;
            this.dgv_data.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_data.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_data.ThemeStyle.ReadOnly = false;
            this.dgv_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_data.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            // 
            // cCode
            // 
            this.cCode.HeaderText = "Mã Nhân Viên";
            this.cCode.MinimumWidth = 6;
            this.cCode.Name = "cCode";
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên Nhân Viên";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Số Điện Thoại";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Ngày Sinh";
            this.cDate.MinimumWidth = 6;
            this.cDate.Name = "cDate";
            // 
            // cBranch
            // 
            this.cBranch.HeaderText = "Mã Chi Nhánh";
            this.cBranch.MinimumWidth = 6;
            this.cBranch.Name = "cBranch";
            // 
            // cSellNumber
            // 
            this.cSellNumber.HeaderText = "Số Lượng Đã Bán";
            this.cSellNumber.MinimumWidth = 6;
            this.cSellNumber.Name = "cSellNumber";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_Name.Location = new System.Drawing.Point(4, 26);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 51);
            this.lbl_Name.TabIndex = 1;
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_Data);
            this.Controls.Add(this.pnl_btn);
            this.Controls.Add(this.pnl_back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistical";
            this.Size = new System.Drawing.Size(1179, 645);
            this.pnl_back.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.pnl_Data.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_back;
        private Guna.UI.WinForms.GunaPanel pnl_btn;
        private Guna.UI.WinForms.GunaPanel pnl_Data;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaButton btn_Staff;
        private Guna.UI.WinForms.GunaButton btn_Menu;
        private Guna.UI.WinForms.GunaButton btn_Customer;
        private Guna.UI.WinForms.GunaButton btn_Branch;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellNumber;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lbl_Name;
    }
}
