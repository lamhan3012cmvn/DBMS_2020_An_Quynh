
namespace DBMS_2020.Features.Admin
{
    partial class ManagerBranch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.dgv_branch = new Guna.UI.WinForms.GunaDataGridView();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_control = new Guna.UI.WinForms.GunaPanel();
            this.pnl_CRUD = new Guna.UI.WinForms.GunaPanel();
            this.btn_Update = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.txt_Address = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Code = new Guna.UI.WinForms.GunaLineTextBox();
            this.lbl_user_name = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.txt_SearchName = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblNull = new Guna.UI.WinForms.GunaLabel();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branch)).BeginInit();
            this.pnl_control.SuspendLayout();
            this.pnl_CRUD.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.btn_Back);
            this.pnl_data.Controls.Add(this.dgv_branch);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(793, 645);
            this.pnl_data.TabIndex = 0;
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
            this.btn_Back.Location = new System.Drawing.Point(16, 14);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.btn_Back.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.btn_Back.Radius = 20;
            this.btn_Back.Size = new System.Drawing.Size(152, 50);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Trở lại";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dgv_branch
            // 
            this.dgv_branch.AllowUserToAddRows = false;
            this.dgv_branch.AllowUserToDeleteRows = false;
            this.dgv_branch.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_branch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_branch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_branch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_branch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_branch.ColumnHeadersHeight = 50;
            this.dgv_branch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.cName,
            this.cAdress,
            this.cRevenue});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_branch.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_branch.EnableHeadersVisualStyles = false;
            this.dgv_branch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_branch.Location = new System.Drawing.Point(0, 71);
            this.dgv_branch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_branch.Name = "dgv_branch";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_branch.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_branch.RowHeadersVisible = false;
            this.dgv_branch.RowHeadersWidth = 50;
            this.dgv_branch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_branch.Size = new System.Drawing.Size(793, 574);
            this.dgv_branch.TabIndex = 0;
            this.dgv_branch.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_branch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_branch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_branch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_branch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_branch.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_branch.ThemeStyle.ReadOnly = false;
            this.dgv_branch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_branch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_branch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.dgv_branch.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_branch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.dgv_branch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_branch_CellContentClick);
            // 
            // cCode
            // 
            this.cCode.HeaderText = "Mã Chi Nhánh";
            this.cCode.MinimumWidth = 6;
            this.cCode.Name = "cCode";
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên Chi Nhánh";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            // 
            // cAdress
            // 
            this.cAdress.HeaderText = "Dịa Chỉ";
            this.cAdress.MinimumWidth = 6;
            this.cAdress.Name = "cAdress";
            // 
            // cRevenue
            // 
            this.cRevenue.HeaderText = "Doanh Thu";
            this.cRevenue.MinimumWidth = 6;
            this.cRevenue.Name = "cRevenue";
            // 
            // pnl_control
            // 
            this.pnl_control.Controls.Add(this.pnl_CRUD);
            this.pnl_control.Controls.Add(this.pnl_Search);
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_control.Location = new System.Drawing.Point(793, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(386, 645);
            this.pnl_control.TabIndex = 1;
            // 
            // pnl_CRUD
            // 
            this.pnl_CRUD.Controls.Add(this.btn_Update);
            this.pnl_CRUD.Controls.Add(this.btn_Add);
            this.pnl_CRUD.Controls.Add(this.txt_Address);
            this.pnl_CRUD.Controls.Add(this.gunaLabel2);
            this.pnl_CRUD.Controls.Add(this.txt_Name);
            this.pnl_CRUD.Controls.Add(this.gunaLabel1);
            this.pnl_CRUD.Controls.Add(this.txt_Code);
            this.pnl_CRUD.Controls.Add(this.lbl_user_name);
            this.pnl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_CRUD.Location = new System.Drawing.Point(0, 101);
            this.pnl_CRUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_CRUD.Name = "pnl_CRUD";
            this.pnl_CRUD.Size = new System.Drawing.Size(386, 544);
            this.pnl_CRUD.TabIndex = 14;
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
            this.btn_Update.Location = new System.Drawing.Point(211, 298);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Add.Location = new System.Drawing.Point(28, 298);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Address.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Address.LineSize = 2;
            this.txt_Address.Location = new System.Drawing.Point(60, 218);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.PasswordChar = '\0';
            this.txt_Address.Size = new System.Drawing.Size(301, 43);
            this.txt_Address.TabIndex = 18;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 190);
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
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Name.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.txt_Name.LineSize = 2;
            this.txt_Name.Location = new System.Drawing.Point(60, 137);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Size = new System.Drawing.Size(301, 43);
            this.txt_Name.TabIndex = 16;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.gunaLabel1.Location = new System.Drawing.Point(13, 108);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(136, 25);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Tên Chi Nhánh";
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
            this.txt_Code.Location = new System.Drawing.Point(61, 53);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.PasswordChar = '\0';
            this.txt_Code.Size = new System.Drawing.Size(301, 43);
            this.txt_Code.TabIndex = 14;
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lbl_user_name.Location = new System.Drawing.Point(21, 25);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(134, 25);
            this.lbl_user_name.TabIndex = 13;
            this.lbl_user_name.Text = "Mã Chi Nhánh";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.txt_SearchName);
            this.pnl_Search.Controls.Add(this.lblNull);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 0);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(386, 101);
            this.pnl_Search.TabIndex = 13;
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
            this.txt_SearchName.Location = new System.Drawing.Point(177, 48);
            this.txt_SearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.PasswordChar = '\0';
            this.txt_SearchName.Size = new System.Drawing.Size(184, 43);
            this.txt_SearchName.TabIndex = 22;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.lblNull.Location = new System.Drawing.Point(56, 60);
            this.lblNull.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(90, 25);
            this.lblNull.TabIndex = 21;
            this.lblNull.Text = "Tìm Kiếm";
            // 
            // ManagerBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.pnl_control);
            this.Controls.Add(this.pnl_data);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerBranch";
            this.Size = new System.Drawing.Size(1179, 645);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branch)).EndInit();
            this.pnl_control.ResumeLayout(false);
            this.pnl_CRUD.ResumeLayout(false);
            this.pnl_CRUD.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private Guna.UI.WinForms.GunaDataGridView dgv_branch;
        private Guna.UI.WinForms.GunaPanel pnl_control;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRevenue;
        private Guna.UI.WinForms.GunaPanel pnl_CRUD;
        private Guna.UI.WinForms.GunaLineTextBox txt_Address;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txt_Code;
        private Guna.UI.WinForms.GunaLabel lbl_user_name;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaLineTextBox txt_SearchName;
        private Guna.UI.WinForms.GunaLabel lblNull;
        private Guna.UI.WinForms.GunaButton btn_Update;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_Back;
    }
}
