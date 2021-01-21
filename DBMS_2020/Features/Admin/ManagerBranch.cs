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
    public partial class ManagerBranch : UserControl
    {
        DataTable DT;
        private Controllers.Admin branch;
        public ManagerBranch()
        {
            InitializeComponent();
            this.branch = new Controllers.Admin();
            //loadDataGridiew();
        }

        private void loadDataGridiew()
        {
            var data = this.branch.loadViewManagerBranch();
            DT = data.Tables[0];
            this.dgv_branch.Rows.Clear();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                var item = DT.Rows[i];
                dgv_branch.Rows.Add(item[0], item[1], item[2], item[3]);
            }
            // Qua day load len view
        }

        private void txt_SearchName_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void dgv_branch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
