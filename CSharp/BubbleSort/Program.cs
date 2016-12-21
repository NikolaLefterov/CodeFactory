using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bublesort
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
           
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            int temp = 0;
            
            for (int i = 0; i < n; i++)
            {

                arr[i] = rnd.Next(-65000,65000);
            }
            for (int write = 0; write <= arr.Length-1; write++)
            {
                for (int sort = write+1; sort <=arr.Length - 1; sort++)
                {
                    if (arr[write] > arr[sort])
                    {
                        temp = arr[write];
                        arr[write] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

         //   for (int i = 0; i < arr.Length; i++)
              //  Console.WriteLine(arr[i]);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }
    }
}
