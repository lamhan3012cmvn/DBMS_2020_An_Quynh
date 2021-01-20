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
            loadManagerBrach();
        }
        private void loadManagerBrach()
        {
            ManagerBrach brach = new ManagerBrach();
            MethodHelps.addControl(this.pnl_Admin, brach);
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

    }
}
