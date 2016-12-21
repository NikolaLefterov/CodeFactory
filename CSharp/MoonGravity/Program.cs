using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double weight = Convert.ToDouble(Console.ReadLine());
            weight = (weight * 17) / 100;
            Console.WriteLine(weight.ToString("F3"));
           
            
        }
    }
}
