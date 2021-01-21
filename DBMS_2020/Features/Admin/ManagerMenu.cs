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
    
    public partial class ManagerMenu : UserControl
    {
        string err;
        DataTable DT;
        private Controllers.Admin Menu;
        public ManagerMenu()
        {
            InitializeComponent();
            this.Menu = new Controllers.Admin();
            loadDataGridiew();
        }
        public void loadDataGridiew()
        {
            var data = this.Menu.loadViewManagerMenu();
            DT = data.Tables[0];
            this.dgv_Menu.Rows.Clear();
            for(int i =0;i<DT.Rows.Count;i++)
            {
                var item = DT.Rows[i];
                dgv_Menu.Rows.Add(item[0], item[1], item[2],item[4]);
            }    
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataSet check = Menu.pick1Item(this.txt_Code.Text);
            if(check.Tables[0].Rows.Count == 0)
            {
                Menu.addMenu(MaMon: this.txt_Code.Text, TenMon: this.txt_Name.Text, GiaTien: float.Parse(this.txt_Price.Text), AnhMinhHoa: "abc", DaBan: 0, ref err);
                if(err == null)
                {
                    MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Đã có món trong menu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_Code.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txt_Name.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txt_Price.Text = this.dgv_Menu.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.picb_img.Image = Image.FromFile("../../img/" + DT.Rows[e.RowIndex][3]);
            this.txt_Code.Enabled = false;
        }
    }
}
