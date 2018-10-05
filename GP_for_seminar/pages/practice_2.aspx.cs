using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class practice_2 : System.Web.UI.Page
    {
        static string charpath = "";
        static string voicepath = "";
        static string levno;
        static string levtyp;
        static string prano;
        int i = 0;
        int score = 0;

        System.Web.UI.HtmlControls.HtmlAudio myAudio = new System.Web.UI.HtmlControls.HtmlAudio();
        List<Practice_content> res = practices();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["score"] == null)
                {
                    ViewState["score"] = score;
                }
                if (ViewState["visited"] == null)
                {
                    ViewState["visited"] = "firsttime";
                }

                if (ViewState["index"] == null)
                {
                    ViewState["index"] = i;
                }
                if (ViewState["beforereplay"] == null)
                {
                    ViewState["beforereplay"] = "nothing";
                }
                if (ViewState["corr"] == null)
                {
                    ViewState["corr"] = 0;
                }
                if (ViewState["wrng"] == null)
                {
                    ViewState["wrng"] = 0;
                }


                fillImages(ImageButton1, ImageButton2, ImageButton3, ImageButton4, (int)ViewState["index"]);

            }

        }


        public void fillImages(ImageButton IB1, ImageButton IB2, ImageButton IB3, ImageButton IB4, int listIndex)
        {



            if (res != null)
            {

                IB1.ImageUrl = charpath + res[i].Choice1;
                IB2.ImageUrl = charpath + res[i].Choice2;
                IB3.ImageUrl = charpath + res[i].Choice3;
                IB4.ImageUrl = charpath + res[i].Choice4;
                myAudio.Src = voicepath + res[i].audio;
                myAudio.Attributes.Add("autoplay", "autoplay");
                Form.Controls.Add(myAudio);
            }

        }
        public static List<Practice_content> practices()
        {
            if (!String.IsNullOrWhiteSpace(HttpContext.Current.Request.QueryString["levelno"]))
            {
                levno = Convert.ToString(HttpContext.Current.Request.QueryString["levelno"]);
                levtyp = Convert.ToString(HttpContext.Current.Request.QueryString["leveltype"]);
                prano = Convert.ToString(HttpContext.Current.Request.QueryString["practiceno"]);

                if (levno == "1")
                {
                    if (levtyp == "Alphabets")
                    {

                        charpath = "../images/alphabet/";
                        voicepath = "~/audios/letters/";
                    }

                    else if (levtyp == "Numbers")
                    {
                        charpath = "../images/numberslevel1/";
                        voicepath = "~/audios/number/";

                    }
                    else if (levtyp == "Color")
                    {
                        charpath = "~/images/color_level/";
                        voicepath = "~/audios/colors/";

                    }
                    else if (levtyp == "Family")
                    {
                        charpath = "~/images/family_level/";
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

                Models.PracticeModel w = new Models.PracticeModel();

                return w.searchpractice(levno, levtyp, Convert.ToInt32(prano));
            }
            return null;
        }

        protected void listen_Click(object sender, ImageClickEventArgs e)
        {
            myAudio.Src = voicepath + res[(int)ViewState["index"]].audio;
            myAudio.Attributes.Add("autoplay", "autoplay");
            Form.Controls.Add(myAudio);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            myAudio.Src = voicepath + res[(int)ViewState["index"]].audio;
            myAudio.Attributes.Add("autoplay", "autoplay");
            Form.Controls.Add(myAudio);
        }

        protected void hint_Click(object sender, ImageClickEventArgs e)
        {
            // Panel1.Visible = true;
            if (ImageButton1.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
            {
                ImageButton2.Visible = false;
                ImageButton3.Visible = false;
                ImageButton4.Visible = false;

            }
            else if (ImageButton2.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
            {
                ImageButton1.Visible = false;
                ImageButton3.Visible = false;
                ImageButton4.Visible = false;

            }
            else if (ImageButton3.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
            {
                ImageButton1.Visible = false;
                ImageButton2.Visible = false;
                ImageButton4.Visible = false;

            }
            else
            {
                ImageButton1.Visible = false;
                ImageButton2.Visible = false;
                ImageButton3.Visible = false;
            }

        

        }

        protected void reply_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton2.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";
            ImageButton3.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";
            ImageButton4.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";
            ViewState["visited"] = "firsttime";
            if (ViewState["beforereplay"].ToString() == "Correct")
            {
                ViewState["score"] = Convert.ToInt32(ViewState["score"]) - 1;
                scores.Text = (Convert.ToInt32(scores.Text.ToString()) - 1).ToString();
                ViewState["corr"] = (int)ViewState["corr"] - 1;
                corrctres.Text = ViewState["corr"].ToString();
            }
            else if (ViewState["beforereplay"].ToString() == "wrong")
            {
                ViewState["wrng"] = (int)ViewState["wrng"] - 1;
                wrngres.Text = ViewState["wrng"].ToString();
            }

            myAudio.Src = voicepath + res[(int)ViewState["index"]].audio;
            myAudio.Attributes.Add("autoplay", "autoplay");
            Form.Controls.Add(myAudio);
        }

        protected void nextQ_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton2.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";
            ImageButton3.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";
            ImageButton4.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0)";


            i = (int)ViewState["index"] + 1;
            if ((i < res.Count) && (ViewState["visited"].ToString() != "firsttime"))
            {

                fillImages(ImageButton1, ImageButton2, ImageButton3, ImageButton4, i);
                ViewState["index"] = i;
                ViewState["visited"] = "firsttime";
            }
            else if ((i == res.Count))

            {
                Models.storescore w = new Models.storescore();
                HttpCookie usernamecookie = Request.Cookies["username"];
                HttpCookie userpasscookie = Request.Cookies["pass"];


                /*new added*/
                Response.Cookies["tota"].Value = res.Count().ToString();
                Response.Cookies["correct"].Value = ViewState["corr"].ToString();

                if (usernamecookie != null && userpasscookie != null)
                {
                    int scorepercent = int.Parse(res.Count().ToString()) / int.Parse(ViewState["corr"].ToString()) * 100;
                    w.savescore(Server.HtmlEncode(usernamecookie.Value), Server.HtmlEncode(userpasscookie.Value), (int)res[i - 1].PracticeID, levtyp, scorepercent);
                }
                string redirct = "practice_score.aspx?levelno=" + levno + "&leveltype=" + levtyp;
                Response.Redirect(redirct);

            }
            ImageButton1.Visible = true;
            ImageButton2.Visible = true;
            ImageButton3.Visible = true;
            ImageButton4.Visible = true;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (ViewState["visited"].ToString() == "firsttime")
            {
                ImageButton2.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0.5)";

                if (ImageButton2.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
                {

                    score = (int)ViewState["score"] + 1;
                    ViewState["score"] = score;
                    ViewState["beforereplay"] = "Correct";
                    scores.Text = score.ToString();
                    ViewState["corr"] = (int)ViewState["corr"] + 1;
                    corrctres.Text = ViewState["corr"].ToString();


                }
                else
                {
                    ViewState["beforereplay"] = "wrong";
                    ViewState["wrng"] = (int)ViewState["wrng"] + 1;
                    wrngres.Text = ViewState["wrng"].ToString();


                }
                ViewState["visited"] = "arleadyvisited";
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (ViewState["visited"].ToString() == "firsttime")
            {
                ImageButton3.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0.5)";

                if (ImageButton3.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
                {

                    score = (int)ViewState["score"] + 1;
                    ViewState["score"] = score;
                    ViewState["beforereplay"] = "Correct";

                    scores.Text = score.ToString();
                    ViewState["corr"] = (int)ViewState["corr"] + 1;
                    corrctres.Text = ViewState["corr"].ToString();
                }
                else
                {
                    ViewState["beforereplay"] = "wrong";
                    ViewState["wrng"] = (int)ViewState["wrng"] + 1;
                    wrngres.Text = ViewState["wrng"].ToString();

                }
                ViewState["visited"] = "arleadyvisited";

            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (ViewState["visited"].ToString() == "firsttime")
            {
                ImageButton4.Style["box-shadow"] = "0px 0px 20px rgba(0,0,0,0.5)";

                if (ImageButton4.ImageUrl == charpath + res[(int)ViewState["index"]].correct)
                {

                    score = (int)ViewState["score"] + 1;
                    ViewState["score"] = score;
                    ViewState["beforereplay"] = "Correct";

                    scores.Text = score.ToString();
                    ViewState["corr"] = (int)ViewState["corr"] + 1;
                    corrctres.Text = ViewState["corr"].ToString();
                }
                else
                {
                    ViewState["beforereplay"] = "wrong";
                    ViewState["wrng"] = (int)ViewState["wrng"] + 1;
                    wrngres.Text = ViewState["wrng"].ToString();

                }
                ViewState["visited"] = "arleadyvisited";

            }
        }
    }
}