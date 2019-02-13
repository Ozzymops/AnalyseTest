using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAnalyse.Models.ChatTest
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public void ChangeUsername(string un)
        {
            this.Username = un;
        }
    }
}