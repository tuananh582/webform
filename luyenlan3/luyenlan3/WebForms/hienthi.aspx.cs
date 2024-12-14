using luyenlan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace luyenlan3.WebForms
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
            db.openncon();
            GridView1.DataSource = db.getall();
            GridView1.DataBind();
            db.closecon();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            db.openncon();
            if (db.checkBookID(txtma.Text.Trim()))
            {
                lbMaSach.Text = "Trung Ma Sach";
            }
            else
            {
                lbMaSach.Visible = false;
                Sach s = new Sach()
                {
                    Masach = txtma.Text.Trim(),
                    Tensach = txttensach.Text.Trim(),
                    Nhaxb = txtnhaxuatban.Text.Trim(),
                    Namxb = int.Parse(txtnxb.Text.Trim()),
                    Tacgia= txttacgia.Text.Trim(),
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
                    db.closecon();
                    load();

                }


            }
        }

        protected void btnlammoi_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txttensach.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnxoa2_Click(object sender, EventArgs e)
        {
            db.openncon();
            Button btnxoa2 = (Button)sender;
            GridViewRow row = (GridViewRow)btnxoa2.NamingContainer;
            string masanpham = row.Cells[0].Text;
            db.delete(masanpham);
            db.closecon();
            load();
        }
    }
}