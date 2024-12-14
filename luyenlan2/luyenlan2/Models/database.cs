using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace luyenlan2.Models
{
    public class database
    {
        SqlConnection conn;

        public void openconn()
        {
            string sql = @"Data Source=Lap-Tuan-Anh;Initial Catalog=QLSach2;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void closeconn()
        {
            conn.Close();
        }
        public DataTable getall()
        {
            DataTable dt = new DataTable();
            string sql = "select *from Sach";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            closeconn();
            return dt;
        }
    }
}