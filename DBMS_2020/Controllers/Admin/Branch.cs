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
    public class Branch
    {
        private string tk;
        private string mk;

        public Branch()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
        }


        public DataSet loadViewManagerBranch()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from ChiNhanh", CommandType.Text);
            return result;
        }


        public bool addBranch(string MaChiNhanh, string TenChiNhanh, string DiaChi, float DoanhThu, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themCN_proc '" + MaChiNhanh + "',N'" + TenChiNhanh + "',N'" + DiaChi + "','" + DoanhThu + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateBranch(string MaChiNhanh, string TenChiNhanh, string DiaChi, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaCN_proc '" + MaChiNhanh + "',N'" + TenChiNhanh + "',N'" + DiaChi + "'", CommandType.Text, ref err);
            return result;
        }

        public bool deleteBranch(string MaChiNhanh, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute xoaCN_proc '" + MaChiNhanh + "'", CommandType.Text, ref err);
            return result;
        }

        public DataSet Top1Branch()
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
        public DataSet pickBranch(string code)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from pickBranch_func (N'" + code + "')", CommandType.Text);
        }

    }
}
