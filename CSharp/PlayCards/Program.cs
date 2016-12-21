using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playcards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string input = Console.ReadLine();
     
            for (int i = 0; i < cards.Length; i++)
            {
                if (input == cards[i])
                {
                    Console.WriteLine("yes " + cards[i]);
                    
                    break;
                }
                if(i == cards.Length - 1)
                {
                    Console.WriteLine("no "+input);
                }
               
            }
           
            
        }
    }
}
