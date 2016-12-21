using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devided_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("true " +num);
            }
            else
                Console.WriteLine("false " + num);

        }
    }
}
