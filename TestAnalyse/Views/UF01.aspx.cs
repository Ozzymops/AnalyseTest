using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TestAnalyse.Models;

namespace TestAnalyse.Views
{
    public partial class UF01 : System.Web.UI.Page
    {
        Logger l = new Logger();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Fill GridView
                _BindGridView();

                // Get max width
                Session["barWidth"] = TimerBar.Attributes["title"];
            }
        }

        private void _BindGridView()
        {
            try
            {
                List<Article> articles = new List<Article>();

                int i = 1;
                while (i < 6)
                {
                    articles.Add(new Article { Id = i, Name = "Artikel " + i.ToString(), Description = "Lorem Ipsum bla bla bla van artikel " + i.ToString() });
                    i++;
                }

                articles.Add(new Article { Id = i + 1, Name = "Echt artikel", Description = "De juiste artikel" });

                if (articles.Count > 0 && articles != null)
                {
                    // Shuffle list
                    Random r = new Random();
                    int count = articles.Count;
                    int last = count - 1;
                    for (int x = 0; x < last; ++x)
                    {
                        var rand = r.Next(x, count);
                        var tmp = articles[x];
                        articles[x] = articles[rand];
                        articles[rand] = tmp;
                    }

                    // Assign to label
                    ArticleName_1.Text = articles[0].Name;
                    ArticleName_2.Text = articles[1].Name;
                    ArticleName_3.Text = articles[2].Name;
                    ArticleName_4.Text = articles[3].Name;
                    ArticleName_5.Text = articles[4].Name;
                    ArticleName_6.Text = articles[5].Name;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("[FOUT]" + e);
                throw;
            }
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            int newWidth = 0;
            newWidth = Convert.ToInt32(Session["barWidth"]) - 25;

            if (newWidth == 0)
            {
                newWidth = 0;
                Timer.Enabled = false;
            }

            Session["barWidth"] = newWidth.ToString();
            TimerBar.Attributes["style"] = "width: " + newWidth.ToString() + "px";
            l.Write(newWidth.ToString());
        }
    }
}