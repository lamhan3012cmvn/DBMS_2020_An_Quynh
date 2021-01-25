using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_2020.Model;
using System.Windows;

namespace DBMS_2020.Controllers.Admin
{
    public class Customer
    {
        private string tk;
        private string mk;

        public Customer()
        {
            this.tk = ConfigurationManager.AppSettings["userName"];
            this.mk = ConfigurationManager.AppSettings["password"];
            System.Windows.Forms.MessageBox.Show(tk);
        }
        public DataSet loadViewManagerCustomer()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("Select * from KhachHang", CommandType.Text);
            return result;
        }
        public DataSet pickCustomer(string code)
        {
            Database db = new Database(this.tk, this.mk);
            return db.ExecuteQueryDataSet("select * from pickCustomer_func ('" + code + "')", CommandType.Text);
        }
        public bool addCustomer(string SDT, string TenKH, string DiaChi, int DaMua, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute themKH_proc '" + SDT + "',N'" + TenKH + "',N'" + DiaChi + "','" + DaMua + "'", CommandType.Text, ref err);
            return result;
        }

        public bool updateCustomer(string SDT, string TenKH, string DiaChi, ref string err)
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.MyExecuteNonQuery("execute suaKH_proc '" + SDT + "',N'" + TenKH + "',N'" + DiaChi + "'", CommandType.Text, ref err);
            return result;
        }

        public bool deleteCustomner(string SDT, ref string err)
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

        public DataSet top3Customer()
        {
            Database db = new Database(this.tk, this.mk);
            var result = db.ExecuteQueryDataSet("select * from top3KhachHang_func", CommandType.Text);
            return result;
        }
    }
}
