using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TestAnalyse.Models.ChatTest;

namespace TestAnalyse.Views
{
    public partial class ChatTest : System.Web.UI.Page
    {
        private List<Room> roomList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Initialise
                InitialiseServer();
            }
        }

        private void InitialiseServer()
        {
            // Create rooms
            roomList = new List<Room>();
            for (int r = 1; r < 6; r++)
            {
                roomList.Add(new Room { Id = r, Users = new List<User>() });
            }
            // Done !
        }

        protected void RoomBoxBut_Click(object sender, EventArgs e)
        {
            // join kamer
        }

        protected void UsernameBoxBut_Click(object sender, EventArgs e)
        {
            // verander huidige username
        }

        protected void MessageBoxBut_Click(object sender, EventArgs e)
        {
            // verstuur bericht
        }
    }
}