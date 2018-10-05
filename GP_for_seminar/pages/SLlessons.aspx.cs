using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class SLlessons : System.Web.UI.Page
    {
        string levno = "";
        string levtyp = "";
        string lesno = "";
        string videoname = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["levelno"]))
            {


                levno = Convert.ToString(Request.QueryString["levelno"]);
                levtyp = Convert.ToString(Request.QueryString["leveltype"]);
                lesno = Convert.ToString(Request.QueryString["lessno"]);
                videoname = Convert.ToString(Request.QueryString["video"]);



                Models.LessonModel w = new Models.LessonModel();      
                Lesson_Content res = w.signlangLesson(lesno, levtyp, Convert.ToInt32(lesno), videoname);
                if (res != null)
                {


                    video.Src = "../images/SLlettersvideos/" + res.video;

                }

            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("slalphabets.aspx");
        }
    }
}