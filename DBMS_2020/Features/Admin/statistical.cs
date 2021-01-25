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

        private void btn_Branch_Click(object sender, EventArgs e)
        {
            this.lbl_Name.Text = "Top 1 Chi Nhánh";
            this.dgv_data.Columns.Clear();
            DataGridViewCell dataGridViewCell = new DataGridViewTextBoxCell();
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cCode",
                HeaderText = "Mã Chi Nhánh",
                CellTemplate= dataGridViewCell

            }) ;

            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cName",
                HeaderText = "Tên Chi Nhánh",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cAddress",
                HeaderText = "Địa Chỉ",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cRevenue",
                HeaderText = "Doanh Thu",
                CellTemplate = dataGridViewCell
            });
            DataSet DT = this.statistical.loadTopBranch();
            DataTable data = DT.Tables[0];
            //this.Rows.Clear();
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
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cCode",
                HeaderText = "Số Điện Thoại",
                CellTemplate = dataGridViewCell
            }) ;

            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cName",
                HeaderText = "Tên Khách Hàng",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cAddress",
                HeaderText = "Địa Chỉ",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cDaMua",
                HeaderText = "Đã Mua",
                CellTemplate = dataGridViewCell
            });
            DataSet DT = this.statistical.loadTopCustomer();
            DataTable data = DT.Tables[0];
            //this.Rows.Clear();
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
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cCode",
                HeaderText = "Mã Món",
                CellTemplate=dataGridViewCell
            });

            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cName",
                HeaderText = "Tên Món",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cAddress",
                HeaderText = "Giá Tiền",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cDaBan",
                HeaderText = "Đã Bán",
                CellTemplate = dataGridViewCell
            });
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
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name="code",HeaderText="Mã Nhân Viên",
                CellTemplate = dataGridViewCell
            });

            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cName",
                HeaderText = "Tên Nhân Viên",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cPhone",
                HeaderText = "Số Điện Thoại",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cDate",
                HeaderText = "Ngày Sinh",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cNameBranch",
                HeaderText = "Tên Chi Nhánh",
                CellTemplate = dataGridViewCell
            });
            this.dgv_data.Columns.Add(new DataGridViewColumn()
            {
                Name = "cTotal",
                HeaderText = "Số Lượng đã bán",
                CellTemplate = dataGridViewCell
            });
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
    }
}
