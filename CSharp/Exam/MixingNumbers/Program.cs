using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int[] arr2 = new int[N];
            int[] arr3 = new int[N];
            int arr2Counter = 0;
            int arr3Counter = 0;
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int counter = 0;
            while (true) {


                   N-- ;
                if (N <= 0)
                {
                    break;
                }
                
                
                
                arr2[arr2Counter] = (arr[counter] % 10) * ((arr[counter+1] / 10) % 10);
                arr2Counter++;
                counter++;

               // arr2[arr2Counter] = (arr[counter] % 10) * ((arr[counter + 1] / 10) % 10);
               // arr2Counter++;
               /// counter++;
                
               // arr3[arr3Counter] = Math.Abs(arr[arr3Counter]-arr[arr3Counter+1]);
              //  arr3Counter++;
                arr3[arr3Counter] = Math.Abs(arr[arr3Counter] - arr[arr3Counter + 1]);
                arr3Counter++;
                
            }
            for (int i = 0; i < arr2Counter; i++)
            {
                Console.Write(arr2[i]+" ");
                
            }
           
            Console.WriteLine();
            for (int i = 0; i < arr3Counter; i++)
            {
                Console.Write(arr3[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
