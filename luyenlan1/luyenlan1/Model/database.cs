using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace luyenlan1.Model
{
    public class database
    {
        SqlConnection conn;
        public void OpennConn()
        {
            string sql = @"Data Source=Lap-Tuan-Anh;Initial Catalog=QLSach;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void ClosenConn()
        {
            conn.Close();
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM Sach";
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Use SqlDataAdapter to fill the DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            ClosenConn();
            return dt;


        }
        public void add (Sach s)
        {
            OpennConn();
            string sql = "insert into Sach values (@MaSach,@TenSach,@NhaXB,@NamXB,@TacGia,@DonGia,@Hinhanh)";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@MaSach",s.MaSach);
            cmd.Parameters.AddWithValue("@TenSach", s.TenSach);
            cmd.Parameters.AddWithValue("@NhaXB", s.Nhaxb);
            cmd.Parameters.AddWithValue("@NamXB", s.Namxb);
            cmd.Parameters.AddWithValue("@TacGia", s.Tacgia);
            cmd.Parameters.AddWithValue("@DonGia", s.Dongia);
            cmd.Parameters.AddWithValue("@Hinhanh", s.Hinhanh);
            cmd.ExecuteNonQuery();
            ClosenConn();
        }

        public void delete(string ms)
        {
            OpennConn();
            string sql = "delete from Sach where MaSach = @MaSach ";
            SqlCommand sqlcom = new SqlCommand(sql,conn);
            sqlcom.Parameters.AddWithValue("@MaSach", ms);
            sqlcom.ExecuteNonQuery();
            ClosenConn();
        }
        public Boolean checkBookID(string ms)
        {
            DataTable tb = new DataTable();
            string sql = "select * from Sach where MaSach = @MaSach";
            OpennConn();
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //da.Fill(tb);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaSach", ms);
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Load(dr);
            ClosenConn();
            if (tb.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

}
