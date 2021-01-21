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
        DataTable DT;
        private Controllers.Admin Customer;
        public ManagerCustomer()
        {
            InitializeComponent();
            this.Customer = new Controllers.Admin();
            
            loadDataGridiew();
        }
        public void loadDataGridiew()
        {
            var data = this.Customer.loadViewManagerCustomer();
            DT = data.Tables[0];
            this.dgv_customer.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_customer.Rows.Add(item[0], item[1], item[2], item[4]);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;    
            this.txt_PhoneNumber.Text = this.dgv_customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Address.Text = this.dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txt_bought.Text = this.dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
