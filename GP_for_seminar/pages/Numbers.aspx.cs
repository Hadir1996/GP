using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class Numbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=0");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=1");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=2");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=3");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=4");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=5");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=6");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=7");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=8");
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Numbers&lessno=1&name=9");
        }
    }
}