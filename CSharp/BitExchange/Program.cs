using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            
            uint number = uint.Parse(Console.ReadLine());
            


            int fakeBitOne = 3;
            int fakeBitTwo = 24;
            int fakeBitThree = 4;
            int fakeBitFour = 25;
            int fakeBitFive = 5;
            int fakeBitSix = 26;
            for (int i = 0; i < 1; i++)
            {
               uint maskOne = (uint)(number & (1 << fakeBitOne)) >> fakeBitOne;
               uint maskTwo = (uint)(number & (1 << fakeBitTwo)) >> fakeBitTwo;
                uint maskThree = (uint)(number & (1 << fakeBitThree)) >> fakeBitThree;
                uint maskFour = (uint)(number & (1 << fakeBitFour)) >> fakeBitFour;
                uint maskFive = (uint)(number & (1 << fakeBitFive)) >> fakeBitFive;
                uint maskSix = (uint)(number & (1 << fakeBitSix)) >> fakeBitSix;

                
                if (maskOne == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitTwo)));
                }
                else if (maskOne == 1)
                {
                    number = (uint)(number | (1 << fakeBitTwo));
                }

              
                if (maskTwo == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitOne)));
                }
                else if (maskTwo == 1)
                {
                    number = (uint)(number | (1 << fakeBitOne));
                }
                if (maskThree == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitFour)));
                }
                else if (maskThree == 1)
                {
                    number = (uint)(number | (1 << fakeBitFour));
                }
                if (maskFour == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitThree)));
                }
                else if (maskFour == 1)
                {
                    number = (uint)(number | (1 << fakeBitThree));
                }
                if (maskFive == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitSix)));
                }
                else if (maskFive == 1)
                {
                    number = (uint)(number | (1 << fakeBitSix));
                }
                if (maskSix == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitFive)));
                }
                else if (maskSix == 1)
                {
                    number = (uint)(number | (1 << fakeBitFive));
                }
                fakeBitOne++;
                fakeBitTwo++;
                fakeBitThree++;
                fakeBitFour++;
                fakeBitFive++;
                fakeBitSix++;
            }

            
            Console.WriteLine(number);
        }
    }
}



