using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GP_for_seminar.pages
{
    public partial class Alphabets : System.Web.UI.Page
    {
        string levno = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(HttpContext.Current.Request.QueryString["levelno"]))
            {
                levno = Convert.ToString(HttpContext.Current.Request.QueryString["levelno"]);
                Page.ClientScript.RegisterHiddenField("levnom", levno);
            }
            }
        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            if(levno=="1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=A");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=a_word");

            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=B");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=b_word");

            }



        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=C");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=c_word");

            }


        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=D");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=d_word");

            }

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=E");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=e_word");

            }

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=F");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=f_word");

            }
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=G");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=g_word");

            }
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=H");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=h_word");

            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=I");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=i_word");

            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=J");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=j_word");

            }

        }
     
        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=K");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=k_word");

            }

        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=L");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=l_word");

            }

        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=M");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=m_word");

            }

        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=N");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=n_word");

            }

        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=O");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=o_word");

            }
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=P");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=p_word");

            }

        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=Q");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=q_word");

            }

        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=R");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=r_word");

            }

        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=S");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=s_word");

            }

        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=T");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=t_word");

            }

        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=U");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=u_word");

            }

        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=V");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=v_word");

            }

        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=W");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=w_word");

            }

        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=X");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=x_word");

            }

        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=Y");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=y_word");

            }

        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            if (levno == "1")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=1&leveltype=Alphabets&lessno=1&name=Z");

            }
            else if (levno == "2")
            {
                Response.Redirect("~/pages/Lessons.aspx?levelno=2&leveltype=Alphabets&lessno=1&name=z_word");

            }

        }

      
    }

}
