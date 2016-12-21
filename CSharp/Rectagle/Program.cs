using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double area = weight * height;
            double perimeter = (2 * weight) + (2 * height);
            Console.WriteLine(area.ToString("F2")+" "+perimeter.ToString("F2"));
            

        }
    }
}
