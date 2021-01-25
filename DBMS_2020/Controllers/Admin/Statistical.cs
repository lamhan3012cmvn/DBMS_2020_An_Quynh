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
    public class Statistical
    {
        private string tk;
        private string mk;

        public Statistical()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
        }
        public DataSet loadTopBranch()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from topChiNhanh_func()", CommandType.Text);
            return result;
        }
        public DataSet loadTopCustomer()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from top3KhachHang_func()", CommandType.Text);
            return result;
        }
        public DataSet loadTopStaff()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from topNhanVien_func()", CommandType.Text);
            return result;

        }
        public DataSet loadTopMenu()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from top3MonAn_func()", CommandType.Text);
            return result;
        }
    }
}
