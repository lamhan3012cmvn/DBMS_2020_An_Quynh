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
        DataTable DT;
        private Controllers.Admin Menu;
        public ManagerMenu()
        {
            InitializeComponent();
            this.Menu = new Controllers.Admin();
            //loadDataGridiew();
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

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
