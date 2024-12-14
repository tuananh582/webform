using luyenlan2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace luyenlan2.WebForms
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
            GridView1.DataSource = db.getall();
            GridView1.DataBind();
            db.closeconn();
        }
    }
}