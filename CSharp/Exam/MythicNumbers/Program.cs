using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            uint n = uint.Parse(Console.ReadLine());
            uint firstDigit = 0, secondDigit = 0, thirdDigit = 0;
            thirdDigit = n % 10;
            n = n / 10;
            secondDigit = n % 10;
            n = n / 10;
            firstDigit = n % 10;
            double product = 0;
            if(thirdDigit == 0)
            {
                product = (double)Math.Max((firstDigit*secondDigit), secondDigit);
                Console.WriteLine(product.ToString("F2"));
            }
            else if(thirdDigit >0 && thirdDigit <= 5)
            {
                product = (double)Math.Max((firstDigit*secondDigit), secondDigit) / (double)thirdDigit;
                Console.WriteLine(product.ToString("F2"));
            }
            else if(thirdDigit> 5)
            {
                product = (double)(firstDigit + secondDigit) *(double) thirdDigit;
                Console.WriteLine(product.ToString("F2"));
            }
        }
    }
}
