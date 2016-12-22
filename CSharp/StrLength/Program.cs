using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strlength
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            for (int i = input.Length; i < 20; i++)
            {
                input.Append("*");
            }
            Console.WriteLine(input);
        }
    }
}
