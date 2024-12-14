using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace luyenlan3.Models
{
   
    public class database
    {
        SqlConnection conn;
        public void openncon()
        {
            string sql = @"Data Source=Lap-Tuan-Anh;Initial Catalog=QLSach2;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void closecon()
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
            closecon();
            return dt;
        }
        public Boolean checkBookID(string ms)
        {
            DataTable tb = new DataTable();
            string sql = "select *from Sach where Masach = @Masach";
            openncon();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Masach", ms);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            closecon();
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void add(Sach s)
        {
            openncon();
            string sql = "insert into Sach values (@Masach,@Tensach,@NhaXB,@NamXB,@Tacgia,@Dongia,@Hinhanh)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@Masach", s.Masach);
            cmd.Parameters.AddWithValue("@Tensach", s.Tensach);
            cmd.Parameters.AddWithValue("@NhaXB", s.Nhaxb);
            cmd.Parameters.AddWithValue("@NamXB", s.Namxb);
            cmd.Parameters.AddWithValue("@Tacgia", s.Tacgia);
            cmd.Parameters.AddWithValue("@Dongia", s.Dongia);
            cmd.Parameters.AddWithValue("@Hinhanh", s.Hinhanh);
            cmd.ExecuteNonQuery();
            closecon();
        }
        public void delete(string ms)
        {
            openncon();
            string sql = "delete from Sach where Masach = @Masach";
            SqlCommand sqlcom = new SqlCommand(sql,conn);
            sqlcom.Parameters.AddWithValue("@Masach", ms);
            sqlcom.ExecuteNonQuery();
            closecon();
        }

    }
}