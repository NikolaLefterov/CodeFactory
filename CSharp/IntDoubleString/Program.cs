using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a;
            double b;
            string c;
            if(input == "integer")
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(a+1);
            }
            else if(input == "real")
            {
                b = double.Parse(Console.ReadLine());
                b = b + 1;
                Console.WriteLine(b.ToString("F2"));
            }
            else if(input == "text")
            {
                c = Console.ReadLine();
                Console.WriteLine(c+"*");
            }
        }
    }
}
