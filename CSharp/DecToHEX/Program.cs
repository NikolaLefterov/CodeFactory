using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dectohex
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
           long[] hexNumber = new long[20];
          
            int i = 0;
            while (n != 0)
            {
                hexNumber[i++] = n % 16;
               n = n / 16;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if(hexNumber[j]<10)
                 Console.Write(Convert.ToString(hexNumber[j]));
              else if (hexNumber[j] == 10)
                {
                    Console.Write("A");
                }
                else if(hexNumber[j] == 11)
                {
                    Console.Write("B");
                }
                else if(hexNumber[j]== 12)
                {
                    Console.Write("C");
                }
                else if (hexNumber[j] == 13)
                {
                    Console.Write("D");
                }
                else if (hexNumber[j] == 14)
                {
                    Console.Write("E");
                }
                else if (hexNumber[j] == 15)
                {
                    Console.Write("F");
                }
               

            }
            
        }
    }
}
