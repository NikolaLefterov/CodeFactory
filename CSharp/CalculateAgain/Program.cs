using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateAgain
{
    class Program
    {
        public static BigInteger factorial(int x)
        {
             BigInteger fac = x;
            for (int i = 1; i <= x - 1; i++)
            {
                fac = fac * i;
            }
            return fac;
        }
        static void Main(string[] args)
        
        {
           
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n)/ factorial(k));
        }
    }
}
