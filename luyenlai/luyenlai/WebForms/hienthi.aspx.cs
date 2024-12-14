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
    }
}