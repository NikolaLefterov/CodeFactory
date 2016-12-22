using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace englisword
{
    class Program
    {
        static void Main(string[] args)
        {
            EnglishDigit(ReadNumber());
        }
        static int ReadNumber()
        {
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static void EnglishDigit(int number)
        {
            if(number%10== 0)
            {
                Console.WriteLine("zero");
            }
            if (number % 10 == 1)
            {
                Console.WriteLine("one");
            }
            if (number % 10 == 2)
            {
                Console.WriteLine("two");
            }
            if (number % 10 == 3)
            {
                Console.WriteLine("three");
            }
            if (number % 10 == 4)
            {
                Console.WriteLine("four");
            }
            if (number % 10 == 5)
            {
                Console.WriteLine("five");
            }
            if (number % 10 == 6)
            {
                Console.WriteLine("six");
            }
            if (number % 10 == 7)
            {
                Console.WriteLine("seven");
            }
            if (number % 10 == 8)
            {
                Console.WriteLine("eight");
            }
            if (number % 10 == 9)
            {
                Console.WriteLine("nine");
            }
        }
    }
}
