using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_2020.Model;

namespace DBMS_2020.Controllers
{
    public class Staff
    {
        private string tk;
        private string mk;
        private string codeStaff;
        public Staff(string codeStaff)
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
            this.codeStaff = codeStaff;
        }
        public object viewInforStaff()
        {
            Database db = new Database(this.tk, this.mk);
            string strSql = "select * from pickMon_func ('" + this.codeStaff + "')";
            var result = db.ExecuteQueryDataSet(strSql, System.Data.CommandType.Text);
            return result;
        }
        public DataSet loadViewManagerMenu()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from Menu", CommandType.Text);
            return result;
        }

    }
}
