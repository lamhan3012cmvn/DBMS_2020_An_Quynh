using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020;

namespace DBMS_2020.Features.Admin
{
    public partial class ManagerBranch : UserControl
    {
        private string err;
        DataTable DT;
        private Controllers.Admin.Branch branch;
        private bool flag;
        public ManagerBranch()
        {
            InitializeComponent();
            this.branch = new Controllers.Admin.Branch();
            loadDataGridiew();

            flag = false;
            enabled();
        }

        private void enabled()
        {
            this.txt_Name.Enabled = !flag;
            this.txt_Code.Enabled = !flag;
            this.txt_Address.Enabled = !flag;
            this.btn_Update.Enabled = flag;
        }
        private void loadDataGridiew()
        {
            var data = this.branch.loadViewManagerBranch();
            DT = data.Tables[0];
            this.dgv_branch.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_branch.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }

        private void resetTxt()
        {
            this.txt_Code.Text = "";
            this.txt_Name.Text = "";
            this.txt_Address.Text = "";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                this.enabled();

                resetTxt();
                return;
            }
            DataSet check = this.branch.pickBranch(this.txt_Code.Text);
            if (check.Tables[0].Rows.Count == 0)
            {
                this.branch.addBranch(MaChiNhanh: this.txt_Code.Text, TenChiNhanh: this.txt_Name.Text, DiaChi: this.txt_Address.Text, DoanhThu: 0, ref err);
                if (err == null)
                {
                    MessageBox.Show("Thêm Chi Nhánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        loadDataGridiew();
                    }
                    catch
                    {
                        MessageBox.Show("Bạn Không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    err = null;
                }
            }
            else
            {
                MessageBox.Show("Chi Nhánh đã tồn tại trong menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_branch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.flag = true;
            this.enabled();
            if (e.RowIndex < 0)
                return;
            this.txt_Code.Enabled = false;
            this.txt_Code.Text = this.dgv_branch.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_branch.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Address.Text = this.dgv_branch.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataSet check = this.branch.pickBranch(this.txt_Code.Text);
            if (check.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm chi nhánh để update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.branch.updateBranch(MaChiNhanh: this.txt_Code.Text, TenChiNhanh: this.txt_Name.Text, DiaChi: this.txt_Address.Text, ref err);
                if (err == null)
                {
                    MessageBox.Show("Update chi nhánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        loadDataGridiew();
                    }
                    catch
                    {
                        MessageBox.Show("Bạn Không có quyền truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    err = null;
                }
            }
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            var data = this.branch.searchBrach(this.txt_SearchName.Text);
            DT = data.Tables[0];
            this.dgv_branch.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_branch.Rows.Add(item[0], item[1], item[2], item[3]);
            }
            // Qua day load len view

        }

        private void dgv_branch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.flag = true;
            this.enabled();
            if (e.RowIndex < 0)
                return;
            this.txt_Code.Enabled = false;
            this.txt_Code.Text = this.dgv_branch.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_branch.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Address.Text = this.dgv_branch.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

