using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddProductEven
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            long oddProduct = 1;
            long evenProduct = 1;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (index % 2 == 0)
                    oddProduct *= numbers[index];

                else evenProduct *= numbers[index];
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes " + oddProduct);

            }
            else
            {
                Console.WriteLine("no " + oddProduct + " " + evenProduct);

            }
            

        }

    }
}
