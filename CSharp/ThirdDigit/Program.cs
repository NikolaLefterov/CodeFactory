using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDig
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            num = (num / 100) % 10;
            if(num == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false "+num);
            }
        }
    }
}
