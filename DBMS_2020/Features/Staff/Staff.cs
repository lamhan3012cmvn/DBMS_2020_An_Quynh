using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020.Class;

namespace DBMS_2020.Features.Staff
{
    public partial class Staff : UserControl
    {
        private InforStaff inforStaff;
        private Sell sell;
        private string codeStaff;
        private string branch;
        private string codeBranch;
        private DBMS_2020.Controllers.Admin.Staff staff;
        public Staff(string codeNV)
        {
            InitializeComponent();
            staff = new Controllers.Admin.Staff();
            //loadInforStaff();
            //loadSell();
            DataTable DT = this.staff.branch_Staff(codeNV).Tables[0];
            this.branch= (string)DT.Rows[0][0];
            this.codeBranch = (string)DT.Rows[0][1];
            this.lbl_Branch.Text += branch;
            this.codeStaff = codeNV;
        }
        private void loadInforStaff()
        {

            this.lbl_NamePage.Text = "Thông tin user";
            this.inforStaff = new InforStaff(codeStaff);
            MethodHelps.addControl(this.pnl_load, this.inforStaff); ;
        }
        private void loadSell()
        {
            this.lbl_NamePage.Text = "Bán hàng";
            this.sell = new Sell(codeStaff,codeBranch);
            MethodHelps.addControl(this.pnl_load, this.sell);
        }
        private void btn_inforStaff_Click(object sender, EventArgs e)
        {
            loadInforStaff();
            if (!(this.sell is null)) this.sell.Dispose();
        }
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            loadSell();
            if (!(this.inforStaff is null)) this.inforStaff.Dispose();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }
    }
}
