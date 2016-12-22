using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breckets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter1 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    counter1++;
                else if(input[i] == ')')
                {
                    counter1--;
                }
                if(input[0] == ')')
                {
                    Console.WriteLine("Incorrect");
                    break;
                }
                 
            }
            if(counter1 < 0)
            {
                Console.WriteLine("Incorrect");
            }
            else
                Console.WriteLine("Correct");
        }
    }
}
