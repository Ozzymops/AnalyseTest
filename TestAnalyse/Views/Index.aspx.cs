using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAnalyse.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IndexBulletedList_Click(object sender, BulletedListEventArgs e)
        {
            switch (e.Index)
            {
                case 0: // ChatTest
                    Response.Redirect("~/Views/ChatTest.aspx");
                    break;

                case 1: // UF-01
                    Response.Redirect("~/Views/UF01.aspx");
                    break;
            }
        }
    }
}