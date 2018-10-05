using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class practice_score : System.Web.UI.Page
    {

       
        static string levno;
        static string levtyp;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie total = Request.Cookies["tota"];
            HttpCookie correct = Request.Cookies["correct"];
            if (total != null && correct != null)
           {
                double score = (double.Parse(Server.HtmlEncode(correct.Value)) / double.Parse(Server.HtmlEncode(total.Value))) * 100;
                prog_bar.Style["width"] = score.ToString() + "%";
                string scor_s = score.ToString();
                if (score.ToString().Count()>4)
                {
                     scor_s = scor_s.Substring(0, 4);

                }
                prog_val.InnerText = scor_s + "%";

                if(score >=80)
                {
                    rate.InnerText = "EXCELLENT";
                }
                else if(score<80 && score>=75)
                {
                    rate.InnerText = "Very Good";
                }
                else if (score < 75 && score >= 50)
                {
                    rate.InnerText = "Good";
                }
                else 
                {
                    rate.InnerText = "Bad";
                }

                corect.InnerText = Server.HtmlEncode(correct.Value).ToString();
                tot.InnerText = Server.HtmlEncode(total.Value).ToString();
            }

        }

        protected void ok_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(HttpContext.Current.Request.QueryString["levelno"]))
            {
                levno = Convert.ToString(HttpContext.Current.Request.QueryString["levelno"]);
                levtyp = Convert.ToString(HttpContext.Current.Request.QueryString["leveltype"]);

                if (levno == "1" && levtyp == "Numbers")
                {
                    Response.Redirect("num_Level1_lesson_practice.aspx");
                }
                else if (levno == "1" && levtyp == "Alphabets")
                {
                    Response.Redirect("alpha_Level1_lesson_practice.aspx");

                }
                else if (levno == "2" && levtyp == "Alphabets")
                {
                    Response.Redirect("alpha_Level2_lesson_practice.aspx");

                }
                else if (levno == "1" && levtyp == "Family")
                {
                    Response.Redirect("family_Level1_lesson_practice.aspx");

                }
                else if (levno == "1" && levtyp == "Color")
                {
                    Response.Redirect("color_Level1_lesson_practice.aspx");

                }
            }
        }
    }
}