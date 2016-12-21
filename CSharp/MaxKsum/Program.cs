using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumK
{
    class MaxSumK
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           var list = arr.ToList();
            list.Sort();
            list.Reverse();
            arr = list.ToArray();

            for (int i = 0; i < k; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}