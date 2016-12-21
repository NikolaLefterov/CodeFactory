using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostFrequnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int temp;
            for (int i = 0; i < N; i++)
            {

                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            int counter = 0, number=0, maxcounter=0;
            for (int i = 0; i < N-1; i++)
            {

                if(arr[i] == arr[i + 1])
                {
                    counter++;
                    if (maxcounter < counter)
                    {
                        maxcounter = counter;
                        number = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
               
            }
            Console.WriteLine(number+"("+maxcounter+" times)");

        }
    }
}
