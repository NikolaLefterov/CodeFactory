using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            int state = 1;
            string separator = "<a href=\"";//, "\">", "</a>" };
            string href = "";
            for (int currrentPos = 0; state != 0;)
            {
                int res = input.IndexOf(separator, currrentPos);
                string currentPart;
                if (res < 0)
                {
                    currentPart = input.Substring(currrentPos);
                }
                else
                {
                    currentPart = input.Substring(currrentPos, res - currrentPos);
                    currrentPos = res + separator.Length;
                }

                switch (state)
                {
                    case 1:
                        Console.Write(currentPart);
                        separator = "\">";
                        state = 2;
                        break;
                    case 2:
                        href = currentPart;
                        separator = "</a>";
                        state = 3;
                        break;
                    case 3:
                        Console.Write("[{0}]({1})", currentPart, href);
                        separator = "<a href=\"";
                        state = 1;
                        break;
                    default:
                        state = 0;
                        break;
                }
                if (res < 0) state = 0;
            }
        }
    }
}
