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
        public Admin()
        {
            InitializeComponent();
            //loadManagerBranch();
            //loadManagerCustomer();
            //loadManagerMenu();
            //loadManagerStaff();
        }
        private void loadManagerBranch()
        {
            ManagerBranch branch = new ManagerBranch();
            MethodHelps.addControl(this.pnl_Admin, branch);
        }
        private void loadManagerCustomer()
        {
            ManagerCustomer customer = new ManagerCustomer();
            MethodHelps.addControl(this.pnl_Admin, customer);
        }
        private void loadManagerMenu()
        {
            ManagerMenu menu = new ManagerMenu();
            MethodHelps.addControl(this.pnl_Admin, menu);
        }
        private void loadManagerStaff()
        {
            ManagerStaff staff = new ManagerStaff();
            MethodHelps.addControl(this.pnl_Admin, staff);
        }

    }
}
