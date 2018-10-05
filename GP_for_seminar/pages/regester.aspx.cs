using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class regester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void reg_Click1(object sender, EventArgs e)
        {
            Page.Validate("rv");
            if (Page.IsValid)
            {
                Page.Validate("rcv");
                if (Page.IsValid)
                {
                    Kid kids = new Kid();
                    kids.FName = Fname.Value;
                    kids.LName = Lname.Value;
                    kids.UserName = username.Value;
                    kids.Age = Convert.ToInt32(age.Value);
                    kids.Password = pass.Value;
                    Models.KidModel k = new Models.KidModel();
                    k.Regester(kids);
                    Response.Cookies["username"].Value = username.Value;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["pass"].Value = pass.Value;
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(1);


                    Response.Redirect("home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Password Must Match')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please Enter All The Information')</script>");
            }
        }
    }
}