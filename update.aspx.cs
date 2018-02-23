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
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id1 = Convert.ToInt32(id.Text);
            string n1 = name.Text;
            string c1 = city.Text;
            long con1 = Convert.ToInt64(contact.Text);

            DBOperations db = new DBOperations();
            Student S = new Student(n1,con1,c1);
           int x=  db.update(S,id1);
            if (x == id1)
            {
                Response.Write("<script> alert('Updated Successfully the ID " + id1 + "')</script>");
            }
            else
            {
                Response.Write("<script> alert('Something went wrong....be careful with BBBipin')</script>");
            }


        }
    }
}
