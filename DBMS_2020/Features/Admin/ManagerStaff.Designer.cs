
namespace DBMS_2020.Features.Admin
{
    partial class ManagerStaff
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
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.dgv_staff = new Guna.UI.WinForms.GunaDataGridView();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnl_CRUD = new Guna.UI.WinForms.GunaPanel();
            this.date_birthDay = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_BranchCode = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Del = new Guna.UI.WinForms.GunaButton();
            this.btn_Update = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.txt_Phone = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.txt_SearchName = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_null = new Guna.UI.WinForms.GunaLabel();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.pnl_CRUD.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dgv_staff);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 272);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(1179, 373);
            this.pnl_data.TabIndex = 2;
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_staff.ColumnHeadersHeight = 50;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_staff.EnableHeadersVisualStyles = false;
            this.dgv_staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_staff.Location = new System.Drawing.Point(0, 0);
            this.dgv_staff.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.Size = new System.Drawing.Size(1179, 373);
            this.dgv_staff.TabIndex = 2;
            this.dgv_staff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_staff.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_staff.ThemeStyle.ReadOnly = false;
            this.dgv_staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_staff.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellContentClick);
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
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.gunaPanel1.Controls.Add(this.pnl_CRUD);
            this.gunaPanel1.Controls.Add(this.pnl_Search);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1179, 272);
            this.gunaPanel1.TabIndex = 3;
            // 
            // pnl_CRUD
            // 
            this.pnl_CRUD.Controls.Add(this.date_birthDay);
            this.pnl_CRUD.Controls.Add(this.txt_BranchCode);
            this.pnl_CRUD.Controls.Add(this.gunaLabel4);
            this.pnl_CRUD.Controls.Add(this.gunaLabel3);
            this.pnl_CRUD.Controls.Add(this.btn_Del);
            this.pnl_CRUD.Controls.Add(this.btn_Update);
            this.pnl_CRUD.Controls.Add(this.btn_Add);
            this.pnl_CRUD.Controls.Add(this.txt_Phone);
            this.pnl_CRUD.Controls.Add(this.gunaLabel2);
            this.pnl_CRUD.Controls.Add(this.txt_Name);
            this.pnl_CRUD.Controls.Add(this.gunaLabel1);
            this.pnl_CRUD.Controls.Add(this.txt_Code);
            this.pnl_CRUD.Controls.Add(this.lbl_user_name);
            this.pnl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CRUD.Location = new System.Drawing.Point(0, 70);
            this.pnl_CRUD.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_CRUD.Name = "pnl_CRUD";
            this.pnl_CRUD.Size = new System.Drawing.Size(1179, 202);
            this.pnl_CRUD.TabIndex = 15;
            // 
            // date_birthDay
            // 
            this.date_birthDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.date_birthDay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.date_birthDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.date_birthDay.BorderSize = 0;
            this.date_birthDay.CustomFormat = null;
            this.date_birthDay.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_birthDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.date_birthDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_birthDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.date_birthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_birthDay.Location = new System.Drawing.Point(833, 53);
            this.date_birthDay.Margin = new System.Windows.Forms.Padding(4);
            this.date_birthDay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_birthDay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_birthDay.Name = "date_birthDay";
            this.date_birthDay.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.date_birthDay.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.date_birthDay.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.date_birthDay.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.date_birthDay.OnPressedDepth = 20;
            this.date_birthDay.Size = new System.Drawing.Size(161, 37);
            this.date_birthDay.TabIndex = 28;
            this.date_birthDay.Text = "1/22/2021";
            this.date_birthDay.Value = new System.DateTime(2021, 1, 22, 14, 12, 44, 474);
            // 
            // txt_BranchCode
            // 
            this.txt_BranchCode.Animated = true;
            this.txt_BranchCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_BranchCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_BranchCode.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_BranchCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BranchCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_BranchCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_BranchCode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_BranchCode.LineSize = 2;
            this.txt_BranchCode.Location = new System.Drawing.Point(27, 139);
            this.txt_BranchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BranchCode.Name = "txt_BranchCode";
            this.txt_BranchCode.PasswordChar = '\0';
            this.txt_BranchCode.Size = new System.Drawing.Size(157, 43);
            this.txt_BranchCode.TabIndex = 27;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel4.Location = new System.Drawing.Point(21, 111);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(128, 25);
            this.gunaLabel4.TabIndex = 26;
            this.gunaLabel4.Text = "Mã chi nhánh";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel3.Location = new System.Drawing.Point(828, 25);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 25);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "Ngày sinh";
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
            this.btn_Del.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.White;
            this.btn_Del.Image = global::DBMS_2020.Properties.Resources.delete;
            this.btn_Del.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Del.Location = new System.Drawing.Point(839, 124);
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
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Image = global::DBMS_2020.Properties.Resources.updated;
            this.btn_Update.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Update.Location = new System.Drawing.Point(1003, 124);
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
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = global::DBMS_2020.Properties.Resources.add;
            this.btn_Add.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Add.Location = new System.Drawing.Point(1003, 38);
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
            // txt_Phone
            // 
            this.txt_Phone.Animated = true;
            this.txt_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Phone.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Phone.LineSize = 2;
            this.txt_Phone.Location = new System.Drawing.Point(632, 53);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.Size = new System.Drawing.Size(163, 43);
            this.txt_Phone.TabIndex = 18;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(627, 25);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 25);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Số điện thoại";
            // 
            // txt_Name
            // 
            this.txt_Name.Animated = true;
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.LineSize = 2;
            this.txt_Name.Location = new System.Drawing.Point(237, 53);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(351, 43);
            this.txt_Name.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(232, 25);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(135, 25);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Tên Nhân Viên";
            // 
            // txt_Code
            // 
            this.txt_Code.Animated = true;
            this.txt_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Code.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Code.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Code.LineSize = 2;
            this.txt_Code.Location = new System.Drawing.Point(27, 53);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.Size = new System.Drawing.Size(163, 43);
            this.txt_Code.TabIndex = 14;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(21, 25);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(133, 25);
            this.lbl_user_name.TabIndex = 13;
            this.lbl_user_name.Text = "Mã Nhân Viên";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.btn_Back);
            this.pnl_Search.Controls.Add(this.txt_SearchName);
            this.pnl_Search.Controls.Add(this.txt_null);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1179, 70);
            this.pnl_Search.TabIndex = 14;
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
            this.btn_Back.Location = new System.Drawing.Point(13, 10);
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
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.Animated = true;
            this.txt_SearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.txt_SearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_SearchName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_SearchName.LineSize = 2;
            this.txt_SearchName.Location = new System.Drawing.Point(911, 14);
            this.txt_SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.PasswordChar = '\0';
            this.txt_SearchName.Size = new System.Drawing.Size(229, 44);
            this.txt_SearchName.TabIndex = 22;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // txt_null
            // 
            this.txt_null.AutoSize = true;
            this.txt_null.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_null.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_null.Location = new System.Drawing.Point(807, 33);
            this.txt_null.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_null.Name = "txt_null";
            this.txt_null.Size = new System.Drawing.Size(90, 25);
            this.txt_null.TabIndex = 21;
            this.txt_null.Text = "Tìm Kiếm";
            // 
            // ManagerStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.pnl_data);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerStaff";
            this.Size = new System.Drawing.Size(1179, 645);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.pnl_CRUD.ResumeLayout(false);
            this.pnl_CRUD.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLineTextBox txt_SearchName;
        private Guna.UI.WinForms.GunaLabel txt_null;
        private Guna.UI.WinForms.GunaPanel pnl_CRUD;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btn_Del;
        private Guna.UI.WinForms.GunaButton btn_Update;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaLineTextBox txt_Phone;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_Code;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaLineTextBox txt_BranchCode;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker date_birthDay;
        private Guna.UI.WinForms.GunaDataGridView dgv_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellNumber;
    }
}
