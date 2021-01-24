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
    public partial class ManagerCustomer : UserControl
    {
        private string err;
        DataTable DT;
        private Controllers.Admin.Customer Customer;
        public ManagerCustomer()
        {
            InitializeComponent();
            this.Customer = new Controllers.Admin.Customer();
            
            //loadDataGridiew();
        }
        public void loadDataGridiew()
        {
            var data = this.Customer.loadViewManagerCustomer();
            DT = data.Tables[0];
            this.dgv_customer.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_customer.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataSet check =this.Customer.pickCustomer(this.txt_PhoneNumber.Text);
            if (check.Tables[0].Rows.Count == 0)
            {
                this.Customer.addCustomer(SDT: this.txt_PhoneNumber.Text, TenKH: this.txt_Name.Text, DiaChi: this.txt_Address.Text, DaMua: 0, ref err);
                if (err == null)
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Khách hàng đã tồn tại trong menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataSet check = this.Customer.pickCustomer(this.txt_PhoneNumber.Text);
            if (check.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng để update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Customer.updateCustomer(SDT:this.txt_PhoneNumber.Text, TenKH:this.txt_Name.Text, DiaChi:this.txt_Address.Text, ref err);
                if (err == null)
                {
                    MessageBox.Show("Update khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_PhoneNumber.Enabled = false;
            if (e.RowIndex < 0)
                return;    
            this.txt_PhoneNumber.Text = this.dgv_customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Address.Text = this.dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txt_bought.Text = this.dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txt_SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.txt_SearchCustomer.Text);
            var data = this.Customer.searchCustomer(this.txt_SearchCustomer.Text);
            DT = data.Tables[0];
            this.dgv_customer.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_customer.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }
    }
}
