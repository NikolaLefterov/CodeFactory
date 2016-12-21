using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

           
            int a = int.Parse(tokens[0]);

            
            int b = int.Parse(tokens[1]);
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine(a);
        }
    }
}
