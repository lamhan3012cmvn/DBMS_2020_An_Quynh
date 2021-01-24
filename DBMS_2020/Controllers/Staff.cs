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
        //public bool payTheBill(oderTam order,string total,ref string err)
        //{
            
        //    bool result_CTHD = true;
        //    order.Dishes().ForEach(d => {
        //        //ThemChiTietHoaDon_proc @maHD varchar(10),@maMon varchar(10), @soLuong int, @gia float
        //        string strSQL_CTHD = $"exec ThemChiTietHoaDon_proc{MaHoaDon},{d.CodeDish},{d.ToalDish},{float.Parse(d.PriceDish)}";
        //       // result_CTHD = result_CTHD && db.MyExecuteNonQuery(strSQL_CTHD, CommandType.Text, ref err2);    
        //    });
        //    return result_HD && result_CTHD;
        //}

        public string createCodeBill(ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            string sql = $"select dbo.autoID_func()";
            string result = (string)db.MyExecuteNonQueryValue(sql, CommandType.Text, ref err);
            return result;
        }
    }
}
