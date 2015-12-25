using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinRTLogger
{
    public class Logger
    {
        
        public Logger(Uri path, string filename)
        {
            //todo
        }

        public Logger(string email, string filename)
        {
            throw new NotImplementedException();
        }

        public void AddLog(Importance importance, string sourceTitle, string message, string description)
        {
            //todo
        }
    }
}
