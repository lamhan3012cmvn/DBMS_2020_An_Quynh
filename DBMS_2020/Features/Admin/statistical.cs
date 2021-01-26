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
    public partial class Statistical : UserControl
    {
        private Controllers.Admin.Statistical statistical;
        public Statistical()
        {
            InitializeComponent();
            this.statistical = new Controllers.Admin.Statistical();
        }
        private DataGridViewColumn createCell(string name,string header, DataGridViewCell type,bool readOnly)
        {
            DataGridViewColumn col=new DataGridViewColumn()
            {
                Name = name,
                HeaderText = header,
                CellTemplate = type,
                ReadOnly = readOnly

            };
            return col;
        }
        private void btn_Branch_Click(object sender, EventArgs e)
        {
            this.lbl_Name.Text = "Top 1 Chi Nhánh";
            this.dgv_data.Columns.Clear();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            this.dgv_data.Columns.Add(createCell("cCode", "Mã Chi Nhánh", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cName", "Tên Chi Nhánh", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cAddress", "Địa Chỉ", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cRevenue", "Doanh Thu", dataGridViewCell, true));
            DataSet DT = this.statistical.loadTopBranch();
            DataTable data = DT.Tables[0];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                this.dgv_data.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            this.lbl_Name.Text = "Top 3 Khách Hàng";
            this.dgv_data.Columns.Clear();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            this.dgv_data.Columns.Add(createCell("cCode", "Số Điện Thoại", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cName", "Tên Khách Hàng", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cAddress", "Địa Chỉ", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cDaMua", "Đã Mua", dataGridViewCell, true));
            DataSet DT = this.statistical.loadTopCustomer();
            DataTable data = DT.Tables[0];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                this.dgv_data.Rows.Add(item[0], item[1], item[2], item[3]);
            }

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.lbl_Name.Text = "Top 3 Menu Bán Chạy";
            this.dgv_data.Columns.Clear();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            this.dgv_data.Columns.Add(createCell("cCode", "Mã Món", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cName", "Tên Món", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cPrice", "Giá Tiền", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cDaBan", "Đã Bán", dataGridViewCell, true));
            DataSet DT = this.statistical.loadTopMenu();
            DataTable data = DT.Tables[0];
            //this.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                this.dgv_data.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            this.lbl_Name.Text = "Top 3 Nhân Viên";
            this.dgv_data.Columns.Clear();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            this.dgv_data.Columns.Add(createCell("cCode", "Mã Nhân Viên", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cName", "Tên Nhân Viên", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cPhone", "Số Điện Thoại", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cDate", "Ngày Sinh", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cNameBranch", "Tên Chi Nhánh", dataGridViewCell, true));
            this.dgv_data.Columns.Add(createCell("cTotal", "Số Lượng đã bán", dataGridViewCell, true));
            DataSet DT = this.statistical.loadTopStaff();
            DataTable data = DT.Tables[0];
            //this.Rows.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var item = data.Rows[i];
                var DoB = item[3].ToString().Split(' ')[0];
                this.dgv_data.Rows.Add(item[0], item[1], item[2], DoB, item[4], item[6]);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
