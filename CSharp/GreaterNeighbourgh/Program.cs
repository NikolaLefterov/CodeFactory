using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNeighbourgh
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(firstgreaterCheck(fillArr(size), size)); 

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
        static int firstgreaterCheck(int [] arr , int n)
        {
            int first = 0;
            for (int i = 1; i < n-1; i++)
            {
                if(arr[i] > arr[i-1] && arr[i] > arr[i+1])
                {
                    first = i;
                    break;
                }
                else
                {
                    first = -1;
                }
            }
            return first;
        }
    }
}
