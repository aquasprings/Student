using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentDAL;
using StudentBO;

namespace WebApplication3
{
    public partial class Viewpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBOperations db = new DBOperations();
            GridView1.DataSource = db.ViewData();
            GridView1.DataBind();
        }
    }
}
