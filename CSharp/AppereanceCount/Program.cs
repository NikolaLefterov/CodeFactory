using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppereanceCOunt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            appereance(fillArr(size), size);
        }
       
        static int[] fillArr(int n)
        {
            string[] tokens = new string[n];
            tokens = Console.ReadLine().Split();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                
                arr[i] = int.Parse(tokens[i]);
            }
            return arr;
            
        }
        static void appereance(int [] arr , int n)
        {
            int x = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if(arr[i] == x)
                {
                    counter++;
                }
               
            }
            Console.WriteLine(counter);
        }
    }
}
