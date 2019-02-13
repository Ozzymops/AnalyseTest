using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAnalyse.Models.ChatTest
{
    public class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Msg { get; set; }
    }
}