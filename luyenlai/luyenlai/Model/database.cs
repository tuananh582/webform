using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace luyenlai.Model
{
    
    public class database
    {
        SqlConnection conn;
        public void openconn()
        {
            string sql = @"Data Source=Lap-Tuan-Anh;Initial Catalog=QLSach;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void closeconn()
        {
            conn.Close();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string sql = "select *from Sach";
            SqlCommand cmd = new SqlCommand(sql, conn); 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            closeconn();
            return dt;

        }
        public void add(Sach s)
        {
            openconn();
            string sql = "insert into Sach values(@MaSach,@TenSach,@NhaXB,@NamXB,@TacGia,@DonGia,@Hinhanh)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.Add("@MaSach",s.MaSach);
            cmd.Parameters.Add("@TenSach", s.TenSach);
            cmd.Parameters.Add("@NhaXB", s.NhaXB);
            cmd.Parameters.Add("@NamXB", s.Namxb);
            cmd.Parameters.Add("@TacGia", s.Tacgia);
            cmd.Parameters.Add("@DonGia", s.Dongia);
            cmd.Parameters.Add("@Hinhanh", s.Hinhanh);
            cmd.ExecuteNonQuery();
            closeconn();
        }
        public Boolean checkBookID(string ms)
        {
            DataTable tb = new DataTable();
            string sql = "select *from Sach where MaSach = @MaSach";
            openconn();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSach", ms);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            closeconn();
            if (tb.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void delete(string ms)
        {
            openconn();
            string sql = "delete from Sach where MaSach = @MaSach";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSach", ms);
            cmd.ExecuteNonQuery();
            closeconn();
        }


    }
}