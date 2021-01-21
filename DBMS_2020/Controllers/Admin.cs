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

        public bool addStaff (string MaNV, string TenNV, string SDT, string ngaySinh, string MaChiNhanh, string MatKhau, int SoLuongBan, string tk, string mk , ref string err )
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute DangKiNV_Proc '" + MaNV + "',N'" + TenNV + "','" + SDT + "','" + MaChiNhanh + "','" + MatKhau + "'," + SoLuongBan, CommandType.Text, ref err);
            return result;
        }

        public bool updateStaff(string MaNV, string TenNV, string SDT, string ngaySinh, string MaChiNhanh, string MatKhau, int SoLuongBan, string tk, string mk, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaNV_proc '" + MaNV + "',N'" + TenNV + "','" + SDT + "','" + MaChiNhanh + "','" + MatKhau + "'," + SoLuongBan, CommandType.Text, ref err);
            return result;
        }

        public bool deleteStaff (string MaNV, ref string err, string tk, string mk)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaNV_proc '"+ MaNV + "'", CommandType.Text, ref err);
            return result;
        }
         
        public bool AddMenu (string MaMon, string TenMon, float GiaTien, string AnhMinhHoa, int DaBan, string tk, string mk, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themMon_proc '" + MaMon + "',N'" + TenMon + "'," + GiaTien + "','" + AnhMinhHoa + "'," + DaBan, CommandType.Text, ref err);
            return result;
        }

    }
}
