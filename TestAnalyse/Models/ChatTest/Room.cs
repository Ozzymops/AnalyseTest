using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAnalyse.Models.ChatTest
{
    public class Room
    {
        public int Id { get; set; }
        public List<User> Users { get; set; }
    }
}