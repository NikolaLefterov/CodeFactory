using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = double.Parse(Console.ReadLine());
        
            double y = double.Parse(Console.ReadLine());
            double check = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
             var result = Math.Round(check, 2, MidpointRounding.AwayFromZero);
           var str= String.Format("{0:0.00}", check);
            int result1 = (int)((check - (int)check) * 1000);
            if(result1 %10 >= 5)
            {
                result1 = (result1 / 10) + 1;
                
                double result2 = (double)result1 / 100;
                Console.WriteLine((int)check+(double)result2);
                
            }
            
            if (check <= 2) {
                Console.WriteLine("yes " + str);
            }
          else
                Console.WriteLine("no " +str);
           
        }
    }
}



