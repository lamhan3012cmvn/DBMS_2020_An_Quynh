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
        public Admin()
        {
            InitializeComponent();
        }
        private void loadManagerBranch()
        {
            this.branch= new ManagerBranch();
            MethodHelps.addControl(this.pnl_Admin, branch);
        }
        private void loadManagerCustomer()
        {
            this.customer = new ManagerCustomer();
            MethodHelps.addControl(this.pnl_Admin, customer);
        }
        private void loadManagerMenu()
        {
            this.menu = new ManagerMenu();
            MethodHelps.addControl(this.pnl_Admin, menu);
        }
        private void loadManagerStaff()
        {
            this.staff = new ManagerStaff();
            MethodHelps.addControl(this.pnl_Admin, staff);
        }

        private void lbl_Staff_Click(object sender, EventArgs e)
        {
            //resetPnl();
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

        private void lbl_bracnh_Click(object sender, EventArgs e)
        {
            //resetPnl();
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

        private void lbl_Customer_Click(object sender, EventArgs e)
        {
            //resetPnl();
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

        private void lbl_Menu_Click(object sender, EventArgs e)
        {
            //resetPnl();
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
        private void resetPnl()
        {
            if(!(this.staff is null))
            {
                this.staff.Dispose();
            }
            if (!(this.customer is null))
            {
                this.customer.Dispose();
            }
            if(!(this.branch is null))
            {
                this.branch.Dispose();
            }    
            if(!(this.menu  is null))
            {
                this.menu.Dispose();
            }    
        }
       
    }
}
