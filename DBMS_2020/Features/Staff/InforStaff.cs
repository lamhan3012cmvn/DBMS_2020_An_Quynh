using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_2020.Features.Staff
{
    public partial class InforStaff : UserControl
    {
        public InforStaff()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_ChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_ChangePassword.Visible = this.cb_ChangePassword.Checked;
        }
    }
}
