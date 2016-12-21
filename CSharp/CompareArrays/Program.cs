using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparearrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int counter = 0;
            for(int i = 0;i< n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());

            }
            for(int i = 0;i < n; i++)
            {
                if (a[i] == b[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("Not equal");
                    break;
                }
            }
            if (counter == n)
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
