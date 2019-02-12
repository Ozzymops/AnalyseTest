using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAnalyse.Views
{
    public partial class TestMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPage = System.IO.Path.GetFileName(Request.Url.AbsolutePath);

            if (currentPage == "Index.aspx")
            {
                BackButton.Visible = false;
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Index.aspx");
        }
    }
}