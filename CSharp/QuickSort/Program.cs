using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        static public void Quicksort(int[] numbers, int left, int right)
        {
            int i = left, j = right;
            int pivot = numbers[(left+right)/2];

            while (i <= j)
            {
                while (numbers[i] < pivot )
                {
                    i++;
                }

                while (numbers[j] > pivot )
                {
                    j--;
                }

                if (i <=j)
                {
                    // Swap
                    int tmp = numbers[i];
                   numbers[i] = numbers[j];
                   numbers[j] = tmp;

                    i++;
                    j--;
                }
                
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(numbers, left, j);
            }

              
        }

        /*   static public void SortQuick(int[] arr, int left, int right)
           {
               // For Recusrion  
               if (left < right)
               {
                   int pivot = Partition(arr, left, right);

                   if (pivot > 1)
                       SortQuick(arr, left, pivot - 1);

                   if (pivot + 1 < right)
                       SortQuick(arr, pivot + 1, right);
               }
           }*/

        static void Main(string[] args)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            Random rnd = new Random();
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[max];

            for (int i = 0; i < max; i++)
            {

                numbers[i] = rnd.Next(-65000, 65000);
            }









            Quicksort(numbers, 0, max - 1);

         //   for (int i = 0; i < max; i++)
             //   Console.WriteLine(numbers[i]);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }
    }
}