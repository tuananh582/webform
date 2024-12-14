using luyenlan1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace luyenlan1.WebForms
{
    public partial class hienthi : System.Web.UI.Page
    {
        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            db.OpennConn();
            GridView1.DataSource = db.getAll();
            GridView1.DataBind();
            db.ClosenConn();
        }

        protected void btnsua_Click(object sender, EventArgs e)
        {

        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            db.OpennConn();
            if (db.checkBookID(txtMa.Text.Trim()))
            {
                lbMaSach.Text = "*Trùng mã sách";
            }
            else
            {
                lbMaSach.Visible = false;
                Sach s = new Sach()
                {
                    MaSach = txtMa.Text.Trim(),
                    TenSach = txttensach.Text.Trim(),
                    Nhaxb = txtnxb.Text.Trim(),
                    Namxb = int.Parse(txtnamxuatban.Text.Trim()),
                    Tacgia = txttacgia.Text.Trim(),
                    Dongia = Convert.ToDouble(txtdongia.Text.Trim()),
                    Hinhanh = FileUpload1.FileName

                };
                db.add(s);
                if (FileUpload1.HasFile)
                {
                    if (FileUpload1.HasFile)
                    {
                        string path = MapPath("~/Images/") + FileUpload1.HasFile;
                        FileUpload1.SaveAs(path);
                    }
                    db.ClosenConn();
                    load();
                }

                // Lưu file ảnh vào thư mục Images

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnxoacn_Click(object sender, EventArgs e)
        {
            db.OpennConn();
            Button btnxoacn = (Button)sender;
            GridViewRow row = (GridViewRow)btnxoacn.NamingContainer;
            string masanpham = row.Cells[0].Text;
            db.delete(masanpham);
            db.ClosenConn();
            load();
        }
    }
}