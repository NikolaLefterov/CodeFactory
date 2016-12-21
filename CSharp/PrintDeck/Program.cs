using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAdeck
{
    class Program
    {
        static void Main(string[] args)
        {
            string input  = Console.ReadLine();

            int n = 0;
           
            if (input == "J")
            {
                n = 11;
            }
            else if(input == "Q")
            {
                n = 12;
            }
            else if(input == "K")
            {
                n = 13;
            }
            else if(input == "A")
            {
                n = 14;
            }
            else
            {
                n = Convert.ToInt32(input);
            }
           
          

           for(int i = 2;i<= n; i++)
            {
                if (i == 11)
                {
                    Console.Write("J of spades, J of clubs, J of hearts, J of diamonds\n");
                }
            else    if (i == 12)
                {
                    Console.Write("Q of spades, Q of clubs, Q of hearts, Q of diamonds\n");
                }
              else  if (i == 13)
                {
                    Console.Write("K of spades, K of clubs, K of hearts, K of diamonds\n");
                }
            else    if (i == 14)
                {
                    Console.Write("A of spades, A of clubs, A of hearts, A of diamonds\n");
                }
                else
                Console.Write(i+" of spades, " +i+" of clubs, "+i+" of hearts, "+i+ " of diamonds\n");
             
            }
        }



    }
}
