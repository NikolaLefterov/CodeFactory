using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseurl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int protocolEnd = input.IndexOf("://");
            string prot =input.Substring(0, protocolEnd);
            int serverStart =protocolEnd + 3;
            int serverEnd = input.IndexOf("/", serverStart);
            string server = input.Substring(serverStart, serverEnd - serverStart);
            int resourceStart = serverEnd;
            string resource = input.Substring(resourceStart);
            Console.WriteLine("[protocol] = {0}", prot);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
