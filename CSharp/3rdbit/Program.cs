using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdbit
{
    class Program
    {
        static void Main()
        {
           
            int number = int.Parse(Console.ReadLine());

            int checkBit = 1 << 3;
            int thirdBit = number & checkBit;

            if (thirdBit == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
