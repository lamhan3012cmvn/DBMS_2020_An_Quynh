
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
            this.dgv_staff = new Guna.UI.WinForms.GunaDataGridView();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSellNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.pnl_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_staff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_staff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_staff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_staff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_staff.ColumnHeadersHeight = 21;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.cName,
            this.cPhone,
            this.cDate,
            this.cBranch,
            this.cSellNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_staff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_staff.EnableHeadersVisualStyles = false;
            this.dgv_staff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_staff.Location = new System.Drawing.Point(0, 0);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.RowHeadersWidth = 51;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.Size = new System.Drawing.Size(906, 487);
            this.dgv_staff.TabIndex = 0;
            this.dgv_staff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_staff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_staff.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_staff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_staff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_staff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_staff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_staff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_staff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_staff.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_staff.ThemeStyle.ReadOnly = false;
            this.dgv_staff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_staff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_staff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_staff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_staff.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_staff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_staff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dgv_staff);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(906, 487);
            this.pnl_data.TabIndex = 2;
            // 
            // ManagerStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_data);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerStaff";
            this.Size = new System.Drawing.Size(906, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_staff;
        private Guna.UI.WinForms.GunaLinePanel pnl_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSellNumber;
    }
}
