using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int first, second, third, fourth;
            fourth = num % 10;
            num = num / 10;
            third = num % 10;
            num = num / 10;
            second = num % 10;
            num = num / 10;
            first = num % 10;
            Console.WriteLine(first+second+third+fourth);
            Console.WriteLine("{0}{1}{2}{3}",fourth,third,second,first);
            Console.WriteLine("{0}{1}{2}{3}", fourth, first, second, third);
            Console.WriteLine("{0}{1}{2}{3}", first, third, second, fourth);

        }
    }
}
