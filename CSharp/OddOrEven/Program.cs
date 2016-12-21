using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("even " + num );
            }
            else
            {
                Console.WriteLine("odd " + num);
            }
        }
    }
}
