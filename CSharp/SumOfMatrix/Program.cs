using System;


namespace SumOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

           
            int n = int.Parse(tokens[0]);

            int m = int.Parse(tokens[1]);
           
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var spl = line.Split(' ');
               
                for (int j = 0; j < m; j++)
                    array[i, j] = int.Parse(spl[j]);
            }
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < m - 2; j++)
                {
                    for (int p = i; p < 3 + i; p++)
                    {
                        for (int q = j; q < 3 + j; q++)
                        {
                            sum += array[p, q];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    sum = 0;
                }
                
            }
            Console.WriteLine(maxSum);
        }
    }
}
