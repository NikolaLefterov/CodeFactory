using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxincreasesequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int []n = new int[length];
            int counter = 1;
            int result = 1;
            for (int i = 0; i < length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length-1; i++)
            {
                if (n[i + 1] - n[i] >= 1)
                {
                    counter++;
                    if (counter > result)
                    {
                        result = counter;
                    }
                }
                else
                    counter = 1;
            }
            Console.WriteLine(result);
        }
    }
}
