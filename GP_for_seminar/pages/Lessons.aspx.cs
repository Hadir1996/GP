using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class Lessons : System.Web.UI.Page
    {
        System.Web.UI.HtmlControls.HtmlAudio myAudio = new System.Web.UI.HtmlControls.HtmlAudio();

        string audiosrc;
        string levno;
        string levtyp;
        string lesno;
        string nam;
       
        string charpath = "";
        string voicepath = "";
        List<Lesson_Content> res;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Request.QueryString["levelno"]))
            {
                 levno = Convert.ToString(Request.QueryString["levelno"]);
                 levtyp = Convert.ToString(Request.QueryString["leveltype"]);
                 lesno = Convert.ToString(Request.QueryString["lessno"]);
                 nam = Convert.ToString(Request.QueryString["name"]);
                 Models.LessonModel w = new Models.LessonModel();
                 res = w.searchLesson(levno, levtyp, Convert.ToInt32(lesno), nam);
                if (res!=null)
                {
                    if (levno == "1")
                    {
                        if (levtyp == "Alphabets")
                        {
                            charpath = "../images/capitalsmall/";
                            voicepath = "~/audios/letters/";
                        }
                        else if (levtyp == "Numbers")
                        {
                            charpath = "../images/numberslevel1/";
                            voicepath = "~/audios/number/";

                        }
                        else if (levtyp == "Color")
                        {
                            charpath = "../images/color_level/";
                            voicepath = "~/audios/colors/";
                        }
                        else if (levtyp == "Family")
                        {
                            charpath = "../images/family_level/";
                            voicepath = "~/audios/family/";
                        }
                    }
                    else if (levno == "2")
                    {
                        if (levtyp == "Alphabets")
                        {
                            charpath = "../images/words/";
                            voicepath = "~/audios/words/";
                        }
                    }
                    if (!IsPostBack)
                    {
                        if(res.Count==1)
                        {
                            prev.Visible = false;
                            next.Visible = false;
                        }
                        else
                        {
                            prev.Visible = true;
                            next.Visible = true;
                        }
                     ViewState["res_count"]=0;
                     capital.ImageUrl = charpath + res[0].Image1_C;
                     small.ImageUrl = charpath + res[0].Image2_S;
                     audiosrc = voicepath + res[0].Voice;
                     myAudio.Src = audiosrc;
                     myAudio.Attributes.Add("autoplay", "autoplay");
                     Form.Controls.Add(myAudio);
                     }
                }
            }
        }
        protected void capital_Click(object sender, ImageClickEventArgs e)
        {
            Form.Controls.Add(myAudio);
        }
        protected void small_Click(object sender, ImageClickEventArgs e)
        {
            Form.Controls.Add(myAudio);
        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (levtyp == "Numbers")
            {
                Response.Redirect("~/pages/Numbers.aspx?levelno=" + levno + "");
            }
            else if (levtyp == "Alphabets")
            {
                Response.Redirect("~/pages/Alphabets.aspx?levelno=" + levno + "");

            }
            else if (levtyp == "Color")
            {
                Response.Redirect("~/pages/color.aspx?levelno=" + levno + "");
            }

            else if (levtyp == "Family")
            {
                Response.Redirect("~/pages/family.aspx?levelno=" + levno + "");
            }
        }
        protected void prev_Click(object sender, EventArgs e)
        {
            if (int.Parse(ViewState["res_count"].ToString() )> 0)
            {
                Form.Controls.Remove(myAudio);
                ViewState["res_count"]= int.Parse(ViewState["res_count"].ToString())-1;
            capital.ImageUrl = charpath + res[int.Parse(ViewState["res_count"].ToString())].Image1_C;
            small.ImageUrl = charpath + res[int.Parse(ViewState["res_count"].ToString())].Image2_S;

            audiosrc = voicepath + res[int.Parse(ViewState["res_count"].ToString())].Voice;
            myAudio.Src = audiosrc;
            myAudio.Attributes.Add("autoplay", "autoplay");

            Form.Controls.Add(myAudio);
            }
        }
        protected void next_Click(object sender, EventArgs e)
        {
            if (int.Parse(ViewState["res_count"].ToString()) < res.Count()-1)
            {
                Form.Controls.Remove(myAudio);
                ViewState["res_count"] = int.Parse(ViewState["res_count"].ToString()) +1;
                capital.ImageUrl = charpath + res[int.Parse(ViewState["res_count"].ToString())].Image1_C;
                small.ImageUrl = charpath + res[int.Parse(ViewState["res_count"].ToString())].Image2_S;

                audiosrc = voicepath + res[int.Parse(ViewState["res_count"].ToString())].Voice;
                myAudio.Src = audiosrc;
                myAudio.Attributes.Add("autoplay", "autoplay");
                Form.Controls.Add(myAudio);
            }
        }
    }
}