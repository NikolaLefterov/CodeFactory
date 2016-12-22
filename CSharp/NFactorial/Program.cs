using System;
using System.Numerics;


class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Nfac(n);
    }

    static void Nfac(int number)
    {
        BigInteger factorial = 1;

        if (number < 0)
        {
            return;
        }
        
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            return;
        }
    }
}