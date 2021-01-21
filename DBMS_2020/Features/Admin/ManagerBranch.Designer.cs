
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_data = new Guna.UI.WinForms.GunaLinePanel();
            this.dgv_branch = new Guna.UI.WinForms.GunaDataGridView();
            this.pnl_control = new Guna.UI.WinForms.GunaPanel();
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.dgv_branch);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_data.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(194)))), ((int)(((byte)(189)))));
            this.pnl_data.LineRight = 2;
            this.pnl_data.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.pnl_data.Location = new System.Drawing.Point(0, 0);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(793, 645);
            this.pnl_data.TabIndex = 0;
            // 
            // dgv_branch
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_branch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_branch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_branch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_branch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_branch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_branch.ColumnHeadersHeight = 21;
            this.dgv_branch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.cName,
            this.cAdress,
            this.cRevenue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_branch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_branch.EnableHeadersVisualStyles = false;
            this.dgv_branch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branch.Location = new System.Drawing.Point(0, 0);
            this.dgv_branch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_branch.Name = "dgv_branch";
            this.dgv_branch.RowHeadersVisible = false;
            this.dgv_branch.RowHeadersWidth = 51;
            this.dgv_branch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_branch.Size = new System.Drawing.Size(793, 645);
            this.dgv_branch.TabIndex = 0;
            this.dgv_branch.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_branch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_branch.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.dgv_branch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_branch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_branch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_branch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_branch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_branch.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_branch.ThemeStyle.ReadOnly = false;
            this.dgv_branch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_branch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_branch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_branch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_branch.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_branch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_branch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_control
            // 
            this.pnl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_control.Location = new System.Drawing.Point(793, 0);
            this.pnl_control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_control.Name = "pnl_control";
            this.pnl_control.Size = new System.Drawing.Size(386, 645);
            this.pnl_control.TabIndex = 1;
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
    }
}
