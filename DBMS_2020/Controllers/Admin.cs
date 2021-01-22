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

        //LOAD DATA
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

        //NHÂN VIÊN
        public bool addStaff(string MaNV, string TenNV, string SDT, string ngaySinh, string MaChiNhanh, string MatKhau, int SoLuongBan, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            //DangKiNV_Proc @tk varchar(10), @mk varchar(20),@tenNV nvarchar(50),@sdt nvarchar(50),@machinhanh nvarchar(50),@soluongban int
            var result = db.MyExecuteNonQuery("execute DangKiNV_Proc '" + MaNV + "',N'" + MatKhau + "','" + TenNV + "','" + SDT + "','" + ngaySinh + "','" + MaChiNhanh + "'," + SoLuongBan, CommandType.Text, ref err);
            return result;
        }

        public bool updateStaff(string MaNV, string TenNV, string SDT, string ngaySinh, string MaChiNhanh, string MatKhau, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaNV_proc '" + MaNV + "',N'" + TenNV + "','" + SDT + "','" + MaChiNhanh + "','" + MatKhau, CommandType.Text, ref err);
            return result;
        }

        public bool deleteStaff (string MaNV, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaNV_proc '"+ MaNV + "'", CommandType.Text, ref err);
            return result;
        }
        public DataSet searchStaff(string name)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from timkiemNV_func (N'" + name + "')", CommandType.Text);
        }

        //MENU
        public DataSet pick1Item (string MaMon)
        {
            Database db = new Database(tk, mk);
            var result =  db.ExecuteQueryDataSet("select * from pickMon_func ('" + MaMon + "')", CommandType.Text);
            return result;
        }


        public bool addMenu(string MaMon, string TenMon, float GiaTien, string AnhMinhHoa, int DaBan, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themMon_proc '" + MaMon + "',N'" + TenMon + "','" + GiaTien + "','" + AnhMinhHoa + "','" + DaBan + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateMenu (string MaMon, string TenMon, float GiaTien, string AnhMinhHoa, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaMon_proc '" + MaMon + "',N'" + TenMon + "','" + GiaTien + "','" + AnhMinhHoa+ "'", CommandType.Text, ref err);
            return result;
        }
        public bool deleteMenu(string MaMon)
        {
            return true;
        }

        public DataSet top3Menu ()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from top3MonAn_func", CommandType.Text);
            return result;
        }
        //KHÁCH HÀNG

        public DataSet pickCustomer(string code)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from pickCustomer_func ('" + code + "')", CommandType.Text);
        }
        public bool addCustomer (string SDT, string TenKH, string DiaChi, int DaMua, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themKH_proc '" + SDT + "',N'" + TenKH + "',N'" + DiaChi + "','" + DaMua + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateCustomer(string SDT, string TenKH, string DiaChi, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaKH_proc '" + SDT + "',N'" + TenKH + "',N'" + DiaChi+"'", CommandType.Text, ref err);
            return result;
        }

        public bool deleteCustomner (string SDT, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaKH_proc '" + SDT + "'", CommandType.Text, ref err);
            return result;
        }

        public DataSet searchCustomer(string name)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from timkiemKH_func (N'" + name + "')", CommandType.Text);
        }

        public DataSet top3Customer ()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from top3KhachHang_func", CommandType.Text);
            return result;
        }

        //CHI NHANH
        public bool addBranch (string MaChiNhanh, string TenChiNhanh, string DiaChi, float DoanhThu, ref string err )
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themCN_proc '" +MaChiNhanh + "',N'" + TenChiNhanh +"',N'" + DiaChi + "','" + DoanhThu + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateBranch(string MaChiNhanh, string TenChiNhanh, string DiaChi, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaCN_proc '" + MaChiNhanh + "',N'" + TenChiNhanh + "',N'" + DiaChi + "'", CommandType.Text, ref err);
            return result;
        }

        public bool deleteBranch (string MaChiNhanh, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaCN_proc '" + MaChiNhanh + "'", CommandType.Text, ref err);
            return result;
        }

        public DataSet Top1Branch ()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from topChiNhanh_func", CommandType.Text);
            return result;
        }

        public DataSet searchBrach(string name)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from timkiemCN_func (N'" + name + "')", CommandType.Text);
        }



    }
}
