using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int counter = 0;
           for (int i = 1; i <= n;i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {

                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
    }
}
