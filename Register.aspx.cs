using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentBO;
using StudentDAL;

namespace WebApplication3
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nam = name.Text;
            long contact1 = Convert.ToInt64(contact.Text);
            string city1 = ddl2.SelectedItem.Text;
            Student s = new Student(nam, contact1, city1);
            DBOperations dbobj = new DBOperations();
            int studentid = dbobj.AddStudent(s);
            if(studentid>0  )



            {
                Response.Write("<script>alert('Added Successfully with the ID" + studentid + "')</script>");
            }
            else
                Response.Write("<script>alert('Error')</script>");
        }
    }
}
