using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020.Model;
using DBMS_2020.Controllers;
namespace DBMS_2020.Features.Staff
{
    public partial class Sell : UserControl
    {
        private oderTam order;
        private string codeStaff;
        private string codeBranch;
        private string price;
        private string codeDish;
        private DataTable menu;
        private Controllers.Staff staff;
        private Controllers.Admin.Customer customer;
        private string err;
        private string phoneUser;

        public Sell(string codeStaff)
        {
            InitializeComponent();
            menu = new DBMS_2020.Controllers.Admin.Menu().loadViewManagerMenu().Tables[0];
            this.codeStaff = codeStaff;
           
            this.staff = new Controllers.Staff();
            this.customer = new Controllers.Admin.Customer();
            this.lbl_nameStaff.Text += this.codeStaff; 
            loadMenu();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadMenu()
        {
            this.dgv_menu.Rows.Clear();
            for (int i = 0; i < this.menu.Rows.Count; i++)
            {
                var item = this.menu.Rows[i];
                //txt_img.Image = Image.FromFile("../../img/" + item[3]);
                this.dgv_menu.Rows.Add(item[0], item[1], item[2], Image.FromFile("../../img/" + item[3]));
                //this.dgv_menu.Rows.Add(item[0], item[1], item[2]);
            }

        }
        public void loadListView()
        {
            this.lv_Bill.Items.Clear();
            int total = 0;
            if (this.order is null)
                return;
            this.order.Dishes().ForEach(d =>
            {
                int i = this.lv_Bill.Items.Count;
                ListViewItem viewItem = new ListViewItem(d.CodeDish);
                this.lv_Bill.Items.Add(viewItem);
                this.lv_Bill.Items[i].SubItems.Add(d.PriceDish);
                this.lv_Bill.Items[i].SubItems.Add(d.ToalDish);
                total += (int.Parse(d.PriceDish) * int.Parse(d.ToalDish));
            });
            this.lbl_Money.Text = total.ToString();
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            
                if (this.order is null)
                {
                    this.order = new oderTam(this.phoneUser, this.codeStaff, this.codeBranch);
                }
                int index = this.order.checkoutCodDish(this.codeDish);
                if (index == -1)
                {
                    this.order.addDish(this.codeDish, this.price, this.number_Quantity.Value.ToString());
                }
                else
                {
                    this.order.Dishes()[index].ToalDish = (int.Parse(this.order.Dishes()[index].ToalDish) + (int)this.number_Quantity.Value).ToString();
                }
            
            loadListView();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            //bool result = this.staff.payTheBill(this.order, this.lbl_Money.Text, ref err);
            string codeBill = this.staff.createCodeBill(ref err);
            if (err != null)
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                err = null;
            }
            else
            {
                this.staff.addBill(codeBill, this.phoneUser, this.codeBranch, this.order.CodeStaff, this.lbl_Money.Text, ref err);
                if (err == null)
                {
                    this.order.Dishes().ForEach(d =>
                    {
                        this.staff.addCTHD(codeBill, d.CodeDish, d.ToalDish, float.Parse(d.PriceDish), ref err);
                        if (err != null)
                        {
                            MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            err = null;
                        }
                    });
                    if (err == null)
                    {
                        MessageBox.Show("Thêm Hóa Đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.lv_Bill.Items.Clear();
                        this.number_Quantity.Value = 0;
                        this.lbl_Money.Text = "0.0";
                      
                        this.order = null;

                    }
                }
                else
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    err = null;
                }

            }
        }

        private void dgv_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_Name.Text = this.dgv_menu.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.number_Quantity.Value = 1;
            this.codeDish = this.dgv_menu.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.price = this.dgv_menu.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            var tempMenu = this.menu.Rows;
            this.dgv_menu.Rows.Clear();
            for (int i = 0; i < tempMenu.Count; i++)
            {
                var item = tempMenu[i];
                if (item[1].ToString().Contains(this.txt_Search.Text))
                {
                    this.dgv_menu.Rows.Add(item[0], item[1], item[2]);
                }
            }
        }

        private void btn_SearchKH_Click(object sender, EventArgs e)
        {
            var customer = this.staff.searchCustomer(this.txt_PhoneCustomer.Text);
            if (customer.Tables[0].Rows.Count == 0)
            {
                this.phoneUser = null;
                this.lbl_phone.Text = "";
                MessageBox.Show("Chưa có khác hàng");
                //Không có Q về tạo form
            }
            else
            {
                this.phoneUser = this.txt_PhoneCustomer.Text;
                this.lbl_phone.Text = customer.Tables[0].Rows[0][1].ToString();
            }

        }
    }
}
