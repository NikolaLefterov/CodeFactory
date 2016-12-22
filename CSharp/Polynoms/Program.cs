using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polynoms
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int [] arr2 = new int[size];
            int[] polynomsum = new int[size];
            printpolynom(polysum(fillArr(size), fillArr(size), size),size);
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
        static int[] polysum(int [] arr, int [] arr2,int size)
        {
            int[] polynomsum = new int[size];
            for (int i = 0; i < size; i++)
            {
                polynomsum[i] = arr[i] + arr2[i];
            }
            return polynomsum;
        }
        static void printpolynom(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
