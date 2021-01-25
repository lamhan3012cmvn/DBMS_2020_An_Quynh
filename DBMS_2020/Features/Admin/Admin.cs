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

namespace DBMS_2020.Features.Admin
{
    public partial class Admin : UserControl
    {
        private ManagerBranch branch;
        private ManagerCustomer customer;
        private ManagerMenu menu;
        private ManagerStaff staff;
        private Statistical statistical;
        public Admin()
        {
            InitializeComponent();
            statistical = new Statistical();
            MethodHelps.addControl(this.pnl_loadUI, statistical);
        }
        private void loadManagerBranch()
        {
            this.branch= new ManagerBranch();
            MethodHelps.addControl(this.pnl_loadUI, branch);
        }
        private void loadManagerCustomer()
        {
            this.customer = new ManagerCustomer();
            MethodHelps.addControl(this.pnl_loadUI, customer);
        }
        private void loadManagerMenu()
        {
            this.menu = new ManagerMenu();
            MethodHelps.addControl(this.pnl_loadUI, menu);
        }
        private void loadManagerStaff()
        {
            this.staff = new ManagerStaff();
            MethodHelps.addControl(this.pnl_loadUI, staff);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            loadManagerMenu();
            if (!(this.staff is null))
            {
                this.staff.Dispose();
            }
            if (!(this.customer is null))
            {
                this.customer.Dispose();
            }
            if (!(this.branch is null))
            {
                this.branch.Dispose();
            }
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            loadManagerCustomer();
            if (!(this.staff is null))
            {
                this.staff.Dispose();
            }
            if (!(this.branch is null))
            {
                this.branch.Dispose();
            }
            if (!(this.menu is null))
            {
                this.menu.Dispose();
            }
        }

        private void btn_Branch_Click(object sender, EventArgs e)
        {
            loadManagerBranch();
            if (!(this.staff is null))
            {
                this.staff.Dispose();
            }
            if (!(this.customer is null))
            {
                this.customer.Dispose();
            }
            if (!(this.menu is null))
            {
                this.menu.Dispose();
            }
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            loadManagerStaff();
            if (!(this.customer is null))
            {
                this.customer.Dispose();
            }
            if (!(this.branch is null))
            {
                this.branch.Dispose();
            }
            if (!(this.menu is null))
            {
                this.menu.Dispose();
            }
        }
    }
}
