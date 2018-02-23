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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);

            DBOperations db = new DBOperations();
           int r= db.delete(id);
            if (r > 0) 
            Response.Write("<script> alert('Deleted Successfully the ID "+id+"')</script>");
            else
                Response.Write("<script> alert('Deletion Unsuccessfully ')</script>");




        }
    }
}
