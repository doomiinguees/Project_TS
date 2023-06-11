using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Logg
    {
        public static void WriteLog(string clientID,string message)
        {
            string logpath = ConfigurationManager.AppSettings["LOGCAMINHO"];
            using (StreamWriter writer = new StreamWriter(logpath, true))
            {
                writer.WriteLine($"{DateTime.Now}:{clientID}{message}");

            
            }
        }
    }
}