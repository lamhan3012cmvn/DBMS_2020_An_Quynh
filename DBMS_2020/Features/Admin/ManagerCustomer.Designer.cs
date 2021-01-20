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
            this.pnl_control = new Guna.UI.WinForms.GunaPanel();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIsPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_customer.ColumnHeadersHeight = 21;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPhone,
            this.cName,
            this.cAdress,
            this.cIsPay});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customer.Size = new System.Drawing.Size(793, 645);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_customer.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_customer.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_customer.ThemeStyle.ReadOnly = false;
            this.dgv_customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_customer.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_control
            // 
            this.pnl_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_control.Location = new System.Drawing.Point(793, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(386, 645);
            this.pnl_control.TabIndex = 3;
            // 
            // pnl_data
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_customer;
        private Guna.UI.WinForms.GunaPanel pnl_control;
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIsPay;
    }
}
