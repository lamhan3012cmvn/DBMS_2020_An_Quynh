using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_2020.Features.Authentication
{
    public partial class Login : UserControl
    {
        private DBMS_2020.Controllers.Authentication auth;
        private DBMS_2020.Features.Staff.Staff staffView;
        private DBMS_2020.Features.Admin.Admin admin;

        public Login()
        {
            InitializeComponent();
            this.auth = new Controllers.Authentication();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int status = this.rd_Manager.Checked ? 1 : 2;
            var result=this.auth.login(this.txt_user_name.Text, this.txt_password.Text, status).Tables[0].Rows[0][0];
            if ((int)result == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(status==1)
                {
                    this.admin = new Admin.Admin();
                    DBMS_2020.Class.MethodHelps.addControl(this, this.admin);
                }    
                else if(status==2)
                {
                    this.staffView = new Staff.Staff(this.txt_user_name.Text);
                    DBMS_2020.Class.MethodHelps.addControl(this, this.staffView);
                    
                }    
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
