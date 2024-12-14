using luyenlai.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace luyenlai.WebForms
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
            db.openconn();
            GridView1.DataSource = db.getAll();
            GridView1.DataBind();
            db.closeconn();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            db.openconn();
            if (db.checkBookID(txtmasach.Text.Trim()))
            {
                lbMaSach.Text = "Trung Ma Sach";
            }
            else
            {
                lbMaSach.Visible = false;
                Sach s = new Sach()
                {
                    MaSach = txtmasach.Text,
                    TenSach = txttensach.Text,
                    NhaXB = txtnxb.Text,
                    Namxb = int.Parse(txtnamxb.Text.Trim()),
                    Tacgia = txttacgia.Text.Trim(),
                    Dongia = Convert.ToDouble(txtdg.Text.Trim()),
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
                    db.closeconn();
                    load();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnXoa1_Click(object sender, EventArgs e)
        {
            db.openconn();
            Button BtnXoa1 = (Button)sender;
            GridViewRow row = (GridViewRow)BtnXoa1.NamingContainer;
            string masanpham = row.Cells[0].Text;
            db.delete(masanpham);
            db.closeconn();
            load();
        }
    }
}