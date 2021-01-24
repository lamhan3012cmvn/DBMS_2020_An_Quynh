using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_2020.Features;
using DBMS_2020.Class;
namespace DBMS_2020.Features
{
    public partial class Index : UserControl
    {
        public Index()
        {
            InitializeComponent();
            UILogin();
            //UIRegistration();
            //UIAdmin();
            //UIStaff();

        }
        public void UILogin()
        {
            Authentication.Login login = new Authentication.Login();
            MethodHelps.addControl(this.pnl_load_ui, login);
        }
        public void UIRegistration()
        {
            Authentication.Registration register = new Authentication.Registration();
            MethodHelps.addControl(this.pnl_load_ui, register);
        }
        public void UIAdmin()
        {
            Admin.Admin admin = new Admin.Admin();
            MethodHelps.addControl(this.pnl_load_ui, admin);
        }
        public void UIStaff()
        {
            Staff.Staff staff = new Staff.Staff("NV01");
            MethodHelps.addControl(this.pnl_load_ui,staff);
        }
    }
}
