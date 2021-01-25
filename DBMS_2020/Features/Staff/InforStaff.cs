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
        private string codeStaff;
        private string branch;
        private Controllers.Staff staff;
        DataTable DT;
        public InforStaff(string codeNV)
        {
            InitializeComponent();
            this.staff = new Controllers.Staff();
            this.codeStaff = codeNV;
            this.branch = (string)this.staff.branch_Staff(codeNV).Tables[0].Rows[0][0];
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

        private void InforStaff_Load(object sender, EventArgs e)
        {
            var data = (DataSet)this.staff.viewInforStaff(codeStaff);
            DT = data.Tables[0];
            this.txt_Code.Text = DT.Rows[0][0].ToString();
            this.txt_Name.Text = DT.Rows[0][1].ToString();
            this.txt_PhoneNumber.Text = DT.Rows[0][2].ToString();
            this.txt_Dob.Text = DT.Rows[0][3].ToString();
            this.txt_DaBan.Text = DT.Rows[0][6].ToString();
            this.txt_NameBranch.Text = this.branch;
        }
    }
}
