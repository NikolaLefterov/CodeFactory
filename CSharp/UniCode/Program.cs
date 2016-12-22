using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder unicode = new StringBuilder();
            foreach (char ch in input)

            {
                unicode.AppendFormat("\\u{0:X4}", (int)ch);
            }

            Console.WriteLine(unicode.ToString());
        }
    }
}
