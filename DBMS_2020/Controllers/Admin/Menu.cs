using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_2020.Model;

namespace DBMS_2020.Controllers.Admin
{
    public class Menu
    {
        private string tk;
        private string mk;

        public Menu()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
        }
        public DataSet loadViewManagerMenu()
        {
            //B1 Keets noi database
            Database db = new Database(this.tk, this.mk);
            //B2 Goi 1 trong 2 cau nay tuy theo nhu cau ma truong hop nay goi cau duoi cau t danh ****
            //db.MyExecuteNonQuery();
            var result = db.ExecuteQueryDataSet("Select * from Menu", CommandType.Text);
            //B3 Dispose database t chuaw viet ham huy
            return result;
        }
        public DataSet pickItem(string MaMon)
        {
            Database db = new Database(tk, mk);
            var result = db.ExecuteQueryDataSet("select * from pickMon_func ('" + MaMon + "')", CommandType.Text);
            return result;
        }


        public bool addMenu(string MaMon, string TenMon, float GiaTien, string AnhMinhHoa, int DaBan, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themMon_proc '" + MaMon + "',N'" + TenMon + "','" + GiaTien + "','" + AnhMinhHoa + "','" + DaBan + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateMenu(string MaMon, string TenMon, float GiaTien, string AnhMinhHoa, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaMon_proc '" + MaMon + "',N'" + TenMon + "','" + GiaTien + "','" + AnhMinhHoa + "'", CommandType.Text, ref err);
            return result;
        }
        public bool deleteMenu(string MaMon,string err)
        {
            Database db = new Database(this.tk, this.mk);
            var reuslt = db.MyExecuteNonQuery($"execute xoaMon_proc '{MaMon}'", CommandType.Text, ref err);
            return reuslt;
        }

        public DataSet top3Menu()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from top3MonAn_func", CommandType.Text);
            return result;
        }
        public bool deleteMenu(string code, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaMon_proc '" + code + "'", CommandType.Text,ref err);
            return result;
        }
    }
}
