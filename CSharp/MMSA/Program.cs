using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double number = 0;

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                sum += number;

                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("min="+min.ToString("F2"));
            Console.WriteLine("max="+max.ToString("F2"));
            Console.WriteLine("sum="+sum.ToString("F2"));
            Console.WriteLine("avg="+(sum/ n).ToString("F2"));

        }
    }
}
