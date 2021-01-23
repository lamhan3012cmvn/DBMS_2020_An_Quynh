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
namespace DBMS_2020.Features.Staff
{
    public partial class Sell : UserControl
    {
        private oderTam order;
        private string codeStaff;
        private string codeBranch;
        private string price;
        private string codeDish;
        public Sell()
        {
            InitializeComponent();
            this.order = new oderTam("123", "123", "123");
            this.order.addDish("123", "123", "1234");
            this.order.addDish("123", "123", "1234");
            this.order.addDish("123", "123", "1234");
            this.order.addDish("123", "123", "1234");
            this.order.addDish("1235", "123", "1234");
            this.order.addDish("1234", "123", "1234");
            loadListView();
        }

        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_Name.Text = this.dgv_menu.Rows[e.RowIndex].Cells[0].ToString();
            this.number_Quantity.Value = 1;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void loadMenu()
        {
            this.dgv_menu.Rows.Clear();

        }
        public void loadListView()
        {
            this.lv_Bill.Items.Clear();
            if (this.order is null)
                return;
            this.order.Dishes().ForEach(d =>
            {
                int i = this.lv_Bill.Items.Count; 
                ListViewItem viewItem = new ListViewItem(d.CodeDish);
                this.lv_Bill.Items.Add(viewItem);
                this.lv_Bill.Items[i].SubItems.Add(d.PriceDish);
                this.lv_Bill.Items[i].SubItems.Add(d.ToalDish);
            });
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            if(this.order is null)
            {
                this.order = new oderTam("", this.codeStaff, this.codeBranch);
                //this.order.addDish(this.codeDish, this.price, this.number_Quantity.Value.ToString());
                //return;
            }
            this.order.addDish(this.codeDish, this.price, this.number_Quantity.Value.ToString());
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            this.order = null;
        }
    }
}
