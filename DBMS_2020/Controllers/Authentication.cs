using DBMS_2020.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_2020.Controllers
{
    public class Authentication
    {
        private string tk;
        private string mk;
        public Authentication()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
        }
        public bool login(string userName, string password,int status,ref string err)
        {
            Database db = new Database(tk, mk);
            var result = db.MyExecuteNonQuery("select * from ktDangNhap_func('" + userName + "','" + password + "','" + status + "')", System.Data.CommandType.Text, ref err);
            return result;
        }
        public bool registration(string userName,string password, string confirm,bool status)
        {
            return true;
        }
    }
}
