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

        public static void Connected(string clientID)

        {
            string textAdd = clientID+ "connected";
            // LOCALIZAÇÃO DO TXT
            string path = @"logs.txt";
     
            // ADICIONA AO TXT A STRING COM UMA NOVA LINHA NO FIM, COM CODIFICAÇÃO UTF8
            File.AppendAllText(path, textAdd + Environment.NewLine, Encoding.UTF8);
            string espaco = "" +
                "" ;
            // LOCALIZAÇÃO DO TXT
            string pat = @"logs.txt";
            // ADICIONA AO TXT A STRING COM UMA NOVA LINHA NO FIM, COM CODIFICAÇÃO UTF8
            File.AppendAllText(pat, espaco + Environment.NewLine, Encoding.UTF8);
        }



        public static void WriteLog(string clientID,string message)

        {
    
            DateTime data = DateTime.Now;
            // (...)
            string textAdd = clientID+message+data;
            // LOCALIZAÇÃO DO TXT
            string path = @"logs.txt";
            // ADICIONA AO TXT A STRING COM UMA NOVA LINHA NO FIM, COM CODIFICAÇÃO UTF8
            File.AppendAllText(path, textAdd + Environment.NewLine, Encoding.UTF8);
            // (...)

        }
    }
}