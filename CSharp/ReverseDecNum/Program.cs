using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            Console.WriteLine(ReverseDecNum(n));
        }

        
        static string ReverseDecNum(string number)
        {
            char[] arrNumber = number.ToCharArray();
            Array.Reverse(arrNumber);
            string numberString = new string(arrNumber);

            return numberString;
        }
    }
}
