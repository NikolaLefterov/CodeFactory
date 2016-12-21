using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
   
    class Program
    {
     
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int [] arr= new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        
            int pos_min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                       
                        pos_min = j;
                    }
                }

                
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
