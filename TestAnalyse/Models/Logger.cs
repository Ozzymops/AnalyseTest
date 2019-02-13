using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestAnalyse.Models
{
    public class Logger
    {
        public void Write(string msg)
        {
            Debug.WriteLine("[LOGGER] " + msg);
        }

        public void Write(Exception ex)
        {
            Debug.WriteLine("[LOGGER EX] " + ex.ToString());
        }
    }
}