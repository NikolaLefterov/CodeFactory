using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBith
{
    class Program
    {

        static void Main()
        {
          
            long number = int.Parse(Console.ReadLine());
            
            int position = int.Parse(Console.ReadLine());

            long moveBit = number >> position;
           long foundBit = moveBit & 1;

            bool isOne = foundBit == 1;
            if(foundBit == 1)
            {
                Console.WriteLine(1);
            }
            else
            Console.WriteLine(0);
            
            
        }
    }
}

