using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(tokens[i]);
            }
            minMaxAvgSumProdcut(arr);
        }
      
        static void minMaxAvgSumProdcut(int [] arr)
        {
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            long  prodcut = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
                prodcut *= arr[i];
            
            }
            double avg = (double)sum /(double) 5;
            Console.WriteLine(avg.ToString("F2"));
            Console.WriteLine(sum);
            Console.WriteLine(prodcut);
            
        }
    }
}
