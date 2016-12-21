using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyAbit
{
    class Program
    {
        static void Main()
        {

          ulong  number = ulong.Parse(Console.ReadLine());
        
            int position = int.Parse(Console.ReadLine());
          
            byte newBit = byte.Parse(Console.ReadLine());

        

            if (newBit == 1)
            {
                ulong setOne = (ulong)1 << position;
                ulong foundBitOne = number | setOne;
               
                Console.WriteLine(foundBitOne);
            }
            else
            {
                ulong setZero = (ulong)~(1 << position);
                ulong foundBitZero = number & setZero;
                
                Console.WriteLine(foundBitZero);
            }
        }
    }
}
