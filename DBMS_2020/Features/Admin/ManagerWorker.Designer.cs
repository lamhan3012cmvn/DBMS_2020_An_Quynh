namespace DBMS_2020.Features.Admin
{
    partial class ManagerWorker
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
            this.dgv_worker = new Guna.UI.WinForms.GunaDataGridView();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameBrach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_worker)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_worker
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_worker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_worker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_worker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_worker.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_worker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_worker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_worker.ColumnHeadersHeight = 21;
            this.dgv_worker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.cName,
            this.cAdress,
            this.cEmail,
            this.cPhone,
            this.cNameBrach,
            this.cSellNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_worker.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_worker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_worker.EnableHeadersVisualStyles = false;
            this.dgv_worker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_worker.Location = new System.Drawing.Point(0, 0);
            this.dgv_worker.Name = "dgv_worker";
            this.dgv_worker.RowHeadersVisible = false;
            this.dgv_worker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_worker.Size = new System.Drawing.Size(884, 524);
            this.dgv_worker.TabIndex = 0;
            this.dgv_worker.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_worker.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_worker.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_worker.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_worker.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_worker.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_worker.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_worker.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_worker.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_worker.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_worker.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_worker.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_worker.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_worker.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_worker.ThemeStyle.ReadOnly = false;
            this.dgv_worker.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_worker.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_worker.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_worker.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_worker.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_worker.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_worker.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_worker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_branch_CellContentClick);
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dgv_worker);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(884, 524);
            this.pnl_data.TabIndex = 4;
            // 
            // cCode
            // 
            this.cCode.HeaderText = "MaNV";
            this.cCode.Name = "cCode";
            // 
            // cName
            // 
            this.cName.HeaderText = "Tên Nhân Viên";
            this.cName.Name = "cName";
            // 
            // cAdress
            // 
            this.cAdress.HeaderText = "Địa Chỉ";
            this.cAdress.Name = "cAdress";
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "SĐT";
            this.cPhone.Name = "cPhone";
            // 
            // cNameBrach
            // 
            this.cNameBrach.HeaderText = "Tên Chi Nhánh";
            this.cNameBrach.Name = "cNameBrach";
            // 
            // cSellNumber
            // 
            this.cSellNumber.HeaderText = "Số Lượng Bán";
            this.cSellNumber.Name = "cSellNumber";
            // 
            // ManagerWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_data);
            this.Name = "ManagerWorker";
            this.Size = new System.Drawing.Size(884, 524);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_worker)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_worker;
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameBrach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellNumber;
    }
}
