using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int n = int.Parse(size[0]);
            int m = int.Parse(size[1]);
            calculation(fillArr(n), fillArr2(m), n, m);
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
        static int[] fillArr2(int m)
        {

            string[] tokens = new string[m];
            tokens = Console.ReadLine().Split();
            int[] arr2 = new int[m];
            for (int i = 0; i < m; i++)
            {

                arr2[i] = int.Parse(tokens[i]);
            }
            return arr2;

        }
        static void calculation(int [] arr , int [] arr2, int n , int m)
        {
           int  keep = 0;
            if (n > m)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < m)
                    {
                        if (arr[i] + arr2[i] > 9)
                        {
                            Console.Write((arr[i] + arr2[i]) % 10 +keep+ " ");
                            keep = 1;
                        }
                        else if (arr[i] + arr2[i] <= 9)
                        {
                            if (arr[i] + arr2[i] + keep > 9)
                            {
                                Console.Write((arr[i] + arr2[i]) % 10 + keep+" ");
                                keep = 1;
                            }
                            else
                            {
                                Console.Write(arr[i] + arr2[i] + keep + " ");
                                keep = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write(arr[i]+ " ");
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    if (i < n)
                    {
                        if (arr[i] + arr2[i] > 9)
                        {
                            Console.Write((arr[i] + arr2[i]) % 10 + keep+ " ");
                            keep = 1;
                        }
                        else if (arr[i] + arr2[i] <= 9)
                        {
                            if (arr[i] + arr2[i] + keep > 9)
                            {
                                Console.Write((arr[i] + arr2[i]+keep) % 10 + " ");
                                keep = 1;
                            }
                            else
                            {
                                Console.Write(arr[i] + arr2[i] + keep+ " ");
                                keep = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write(arr2[i] + " ");
                    }

                }
            }
          
        }
    }
}
