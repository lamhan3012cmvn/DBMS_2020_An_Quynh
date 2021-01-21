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
        DataTable DT;
        private Controllers.Admin staff;
        public ManagerStaff()
        {
            InitializeComponent();
            this.staff = new Controllers.Admin();
            //loadDataGridiew();
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
                dgv_staff.Rows.Add(item[0], item[1],  item[2], DoB, item[4],item[6]);
            }
            // Qua day load len view
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
