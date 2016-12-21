using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dectobinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while(n>=1)
            {
                binary = (n % 2) + binary;
                n = n / 2;
            }
            Console.WriteLine(binary);
        }
    }
}
