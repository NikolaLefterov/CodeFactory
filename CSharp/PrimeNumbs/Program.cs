using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            bool[] arr = new bool[N + 1];
            int biggestPrime = 0;
            
          
            for (int i = 0; i <= N; ++i)
                arr[i] = true;
            arr[0] = arr[1] = false;

            for (int i = 2; i <= N; i++)
            {
                if (arr[i] == true)
                {
                    for (int j = 2; i * j <= N; j++)
                    {
                        arr[i * j] = false;
                    }
                }
            }
            for(int i = 0;i<= N; i++)
            {
                if(arr[i]== true)
                {
                    biggestPrime = i;
                }
            }
            Console.WriteLine(biggestPrime);
        }
    }
}
