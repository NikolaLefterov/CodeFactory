using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i = 0;
          //  Console.WriteLine(input.Length);
            while(true)
            {
                if (i < 0 || i >= input.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at " + i + "!");
                    break;
                }

                else if (input[i] == '^')   
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at " + i + "!");
                    break;
                }
                else if (input[i] == '0')
                {
                    Console.WriteLine("Too drunk to go on after " + i + "!");
                    break;
                }
                else if (input[i] % 2 == 0)
                {
                    i = i +input[i] -48;
                }
                else if(input[i] == '1' || input[i] =='3' || input[i] == '5' || input[i] == '7' || input[i]=='9')
                {
                    i = i - input[i] + 48;
                }
            }
        }
    }
}
