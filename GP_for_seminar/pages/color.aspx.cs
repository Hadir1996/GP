using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class color : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Black");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Blue");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Brown");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Gray");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Green");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Orange");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Pink");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Purple");
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Red");
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=White");
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Color&lessno=1&name=Yellow");
        }

       
    }
}