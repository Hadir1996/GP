using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class family : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Grandfather");

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Grandmother");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Mother");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Father");

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Baby");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Brother");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Family&lessno=1&name=Sister");
        }

    }
}