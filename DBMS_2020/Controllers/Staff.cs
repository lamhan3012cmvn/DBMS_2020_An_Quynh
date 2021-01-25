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
      
        public Staff()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
        }
        public object viewInforStaff(string codeStaff)
        {
            Database db = new Database(this.tk, this.mk);
            string strSql = "select * from pickMon_func ('" + codeStaff + "')";
            var result = db.ExecuteQueryDataSet(strSql, System.Data.CommandType.Text);
            return result;
        }
        public DataSet loadViewManagerMenu()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from Menu", CommandType.Text);
            return result;
        }

        public bool addBill(string codeBill,string phoneNumber,string codeBranch,string codeStaff,string total,ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            string strSQL_HoaDon = $@"exec ThemHoaDon_proc '{codeBill}','{phoneNumber}','{codeStaff}','{codeBranch}','{float.Parse(total)}','{DateTime.Now}'";
            bool result_HD = db.MyExecuteNonQuery(strSQL_HoaDon, CommandType.Text, ref err);
            return result_HD;
        }
        public bool addCTHD(string codeBill,string codeDish,string total,float priceDish,ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            string strSQL_CTHD = $"exec ThemChiTietHoaDon_proc'{codeBill}','{codeDish}','{int.Parse(total)}','{priceDish}'";
            bool reuslt = db.MyExecuteNonQuery(strSQL_CTHD, CommandType.Text, ref err);
            return reuslt;

        }
        public bool addCustomer(string code,string name,string address,ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            string strSQL = $"exec themKH_proc '{code}',N'{name}',N'{address}','{0}'";
            bool result = db.MyExecuteNonQuery(strSQL, CommandType.Text, ref err);
            return result;
        }
        public DataSet searchCustomer(string name)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from timkiemKH_func (N'" + name + "')", CommandType.Text);
        }
        public string createCodeBill(ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            string sql = $"select dbo.autoID_func()";
            string result = (string)db.MyExecuteNonQueryValue(sql, CommandType.Text, ref err);
            return result;
        }
    }
}
