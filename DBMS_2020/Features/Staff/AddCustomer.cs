using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_2020.Features.Staff
{
    public partial class AddCustomer : Form
    {
        private DBMS_2020.Controllers.Staff staff;
        private string err;
        public AddCustomer(DBMS_2020.Controllers.Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.staff.addCustomer(this.txt_Code.Text, this.txt_Name.Text, this.txt_Address.Text, ref err);
            if (err == null)
            {
                MessageBox.Show("Thêm Khách Hàng Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Hide();
                //this.Close();
            }
            else
            {
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                err = null;
            }
            
        }
    }
}
