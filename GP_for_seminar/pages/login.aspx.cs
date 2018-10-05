using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { }
  protected void Log_Click(object sender, EventArgs e)
        {
            Page.Validate("v");
            if (Page.IsValid)
            {
                Models.KidModel kids = new Models.KidModel();
                Boolean result = kids.Login(login_username.Value, login_pass.Value);
                if (result == true)
                {
                    Response.Cookies["username"].Value = login_username.Value;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);
                    Response.Cookies["pass"].Value = login_pass.Value;
                    Response.Cookies["pass"].Expires = DateTime.Now.AddDays(1);
                    Response.Redirect("home.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Wrong Password Or UserName');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Please Enter All the Information');</script>");
            }
        }
    }
}