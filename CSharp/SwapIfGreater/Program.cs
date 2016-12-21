using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if(a> b)
            {
                double tmp = a;
                a = b;
                b = tmp;
                Console.WriteLine(a + " " + b);

            }
            else
            {
                Console.WriteLine(a + " " + b);

            }
            
        }
    }
}
