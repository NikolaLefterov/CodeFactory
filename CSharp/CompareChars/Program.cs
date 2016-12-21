using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int alenght = a.Length;
            int blenght = b.Length;
            string compare = "=";
            int min = Math.Min(alenght, blenght);
            for (int i = 0; i < min; i++)
            {
                if (a[i] < b[i])
                {
                    compare = "<";
                    break;
                }
                else if(a[i] > b[i])
                {
                    compare = ">";
                    break;
                }
                else {
                    if (alenght > blenght)
                    {
                        compare = ">";
                    }
                    else if (alenght < blenght)
                    {
                        compare = "<";
                    }
                    else
                        compare = "=";
                }
            
            }
            Console.WriteLine(compare);
        }
    }
}
