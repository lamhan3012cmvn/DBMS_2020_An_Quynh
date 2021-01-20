using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_2020.Model;

namespace DBMS_2020.Controllers
{
    public class Admin
    {
        private string tk;
        private string mk;
        
        public Admin()
        {
            this.tk = "sa";
            this.mk = "quýnhql2017";
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
        public DataSet loadViewManagerCustomer()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from KhachHang", CommandType.Text);
            return result;
        }
        
        public DataSet loadViewManagerStaff()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from NhanVien", CommandType.Text);
            return result;
        }

        public DataSet loadViewManagerBranch()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from ChiNhanh", CommandType.Text);
            return result;
        }

    }
}
