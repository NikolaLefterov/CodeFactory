using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace CatalanNumbers
{
    class Program
    {
      
        public static double factorial(int x)
        {
            if (x == 0) return 1;
            return x * factorial(x - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           double catalanNumber = 0;
            if (n == 0)
            {
                Console.WriteLine("1");
                return;
            }
                catalanNumber = (factorial(2 * n)) / (factorial(n + 1) * factorial(n));

            Console.WriteLine(catalanNumber);
            
        }
    }
}
