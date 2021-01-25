using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_2020.Model;
using System.Data;
using System.Configuration;

namespace DBMS_2020.Controllers.Admin
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

        public DataSet loadViewManagerStaff()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from NhanVien_ChiNhanh_View", CommandType.Text);
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

        public bool deleteStaff(string MaNV, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaNV_proc '" + MaNV + "'", CommandType.Text, ref err);
            return result;
        }
        public DataSet searchStaff(string name)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from timkiemNV_func (N'" + name + "')", CommandType.Text);
        }
        
        public DataSet branch_Staff(string code)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from pickChiNhanh_NV_func('" + code + "')", System.Data.CommandType.Text);
            return result;
        }

    }
}
