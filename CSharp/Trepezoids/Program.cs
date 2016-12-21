using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());
            double area = ((a +b) / 2) * h;
            Console.WriteLine(area.ToString("F7"));
        }
    }
}
