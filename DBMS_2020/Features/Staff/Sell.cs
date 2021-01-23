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
using System.IO;

namespace DBMS_2020.Features.Staff
{
    public partial class Sell : UserControl
    {
        private Controllers.Admin Menu;
        DataTable DT;

        public Sell()
        {
            InitializeComponent();
            this.Menu = new Controllers.Admin();
            loadDataGridView();
            
        }
        public void loadDataGridView()
        {

        }
        private void dgv_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_Name.Text = this.dgv_menu.Rows[e.RowIndex].Cells[0].ToString();
            this.number_Quantity.Value = 1;
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
