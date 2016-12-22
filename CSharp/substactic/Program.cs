using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substacting
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string substring = Console.ReadLine();
            string input = Console.ReadLine();
            int result;
            for (int i = 0; ; counter++)
            {
                result = input.IndexOf(substring, i, StringComparison.OrdinalIgnoreCase);
                if (result < 0)
                    break;
                i = result + substring.Length;
            }
            Console.WriteLine(counter);
        }
    }
}
