using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_2020.Model
{
    public class Database
    {
        private string conn_str = @"Data Source=PC;Initial Catalog=QuanLyCuaHangBingSu;Integrated Security=True";
        private SqlConnection conn = null;
        private SqlCommand comm = null;
        private SqlDataAdapter da = null;

        public Database(string userName,string password)
        {
            if (userName != null && password != null)
            {
                this.conn_str = @"Data Source=DESKTOP-UEKLT7K; Initial Catalog=QuanLyCuaHangBingSu;User ID=" + userName + ";Password=" + password + ";";
                //this.conn_str = @"Data Source=192.168.1.6; Initial Catalog=QuanLyCuaHangBingSu;User ID=" + userName + ";Password=" + password + ";";
            }
            //Gán chuỗi kết nối để kết nối với SQL sever
            this.conn = new SqlConnection(this.conn_str);
            //Lệnh gọi để tạo các câu lệnh truy xuất
            this.comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            //Nếu đã có kết nối thì đóng nó lại
            if (conn.State == ConnectionState.Open)
                conn.Close();
            //Mở kết nối
            conn.Open();
            //Gán câu lệnh  
            comm.CommandText = strSQL;
            //Chọn loại lệnh 
            comm.CommandType = ct;
            //Tạo bộ chuyển đổi
            da = new SqlDataAdapter(comm);

            //Tạo Dataset
            DataSet ds = new DataSet();
            //Đổ dữ liệu vào da
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            //Cờ lỗi
            bool f = false;
            //Nếu đã có kết nối thì đóng nó lại
            if (conn.State == ConnectionState.Open)
                conn.Close();
            //Mở kết nối
            conn.Open();
            //Gán câu lệnh 
            comm.CommandText = strSQL;
            //Chọn loại lệnh 
            comm.CommandType = ct;
            try
            {
                //Nếu chương trình chạy bình thường thì cờ được gán là True
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                //Trường hợp lỗi sẽ bắt lỗi
                error = ex.Message;
            }
            finally
            {
                //Đóng kết nối
                conn.Close();
            }
            return f;
        }

        //Them delegate
    }
}
