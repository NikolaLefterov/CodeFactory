using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggestof5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
           if(a>b && a>c && a>d && a > f)
            {
                Console.WriteLine(a);
            }
           else if(b>a && b>c && b>d && b > f)
            {
                Console.WriteLine(b);
            }
           else if(c>a && c>b && c>d && c> f)
            {
                Console.WriteLine(c);
            }
           else if(d>a && d>b && d>c && d> f)
            {
                Console.WriteLine(d);
            }
           else if(f>a && f>b && f>c && f> d)
            {
                Console.WriteLine(f);
            }
           else if(a==b && b==c && c==d && d== f)
            {
                Console.WriteLine(a);
            }
        }
    }
}
