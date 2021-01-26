using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020;

namespace DBMS_2020.Features.Admin
{
    
    public partial class ManagerStaff : UserControl
    {
        private string err;
        DataTable DT;
        private Controllers.Admin.Staff staff;
        public ManagerStaff()
        {
            InitializeComponent();
            this.staff = new Controllers.Admin.Staff();
            loadDataGridiew();
        }
        private void loadDataGridiew()
        {
            var data = this.staff.loadViewManagerStaff();
            DT = data.Tables[0];
            this.dgv_staff.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                var DoB = item[3].ToString().Split(' ')[0];
                
                dgv_staff.Rows.Add(item[0], item[1],  item[2], DoB, item[4],item[5]);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.staff.updateStaff(MaNV:this.txt_Code.Text,TenNV:this.txt_Name.Text,SDT:this.txt_Phone.Text,ngaySinh:DateTime.Now.ToString(),MaChiNhanh:this.txt_BranchCode.Text,err:ref err);
            if (err == null)
            {
                try
                {
                    loadDataGridiew();
                    MessageBox.Show("Update nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Del_Click(object sender, EventArgs e)
        {

            this.staff.deleteStaff(MaNV:this.txt_Code.Text,err:ref err);
           
            if (err == null)
            {
                try
                {
                    loadDataGridiew();
                    MessageBox.Show("Delete nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.staff.addStaff(MaNV:this.txt_Code.Text,TenNV:this.txt_Name.Text,SDT:this.txt_Phone.Text,ngaySinh:DateTime.Now.ToString(),MaChiNhanh:this.txt_BranchCode.Text,MatKhau:"1234",SoLuongBan:0,err:ref this.err);
            if (err == null)
            {
                try
                {
                    loadDataGridiew();
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_Code.Text = this.dgv_staff.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_staff.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Phone.Text = this.dgv_staff.Rows[e.RowIndex].Cells[2].Value.ToString();
           // this.date_birthDay.Value = new DateTime(this.dgv_staff.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.txt_BranchCode.Text = this.dgv_staff.Rows[e.RowIndex].Cells[4].Value.ToString();
           

        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            var data =this.staff.searchStaff(this.txt_SearchName.Text);
            DT = data.Tables[0];
            this.dgv_staff.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                var DoB = item[3].ToString().Split(' ')[0];
                dgv_staff.Rows.Add(item[0], item[1], item[2], DoB, item[4], item[6]);
            }
        }

    }
}

