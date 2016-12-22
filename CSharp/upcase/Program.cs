using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isUpper = false;
            StringBuilder upString = new StringBuilder();
            for (int i = 0; ;)
            {
                string pattern = isUpper ? "</upcase>" : "<upcase>";
                int result = input.IndexOf(pattern, i, StringComparison.OrdinalIgnoreCase);
                if (result < 0)
                {
                    upString.Append(input.Substring(i));
                    break;
                }
                string subStr = input.Substring(i, result - i);
                upString.Append(isUpper ? subStr.ToUpper() : subStr);
                i = result + pattern.Length;
                isUpper = !isUpper;
            }
            Console.WriteLine(upString.ToString());
        }
    }
}
