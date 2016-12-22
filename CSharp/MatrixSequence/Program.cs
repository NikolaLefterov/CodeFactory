using System;


namespace MatrixSequence
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
            int counter = 1;
            int maxSequence = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m-1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                    {
                        counter++;
                    }
                    else
                        counter = 1;
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                    }
                }
                counter = 1;
            }
          
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j, i] == array[j+1,i])
                    {
                        counter++;
                    }
                    else
                        counter = 1;
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                    }
                }
                counter = 1;
            }
            int k = 0;
            
            
            
                for (int i = 0; i < n - 1; i++)
                {   
                    if(k == m - 1)
                    {
                        break;
                    }
                   
                    if (array[i, k] == array[i + 1, k + 1])
                    {
                        counter++;
                    }
                    else
                        counter = 1;
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                    }
                    k++;
                }
                counter = 1;

            int q = m-1;



            for (int i = 0; i < n - 1; i++)
            {
                if (q <1)
                {
                    break;
                }

                if (array[i, q] == array[i + 1, q-1])
                {
                    counter++;
                }
                else
                    counter = 1;
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                }
                q--;
            }
            counter = 1;





            Console.WriteLine(maxSequence);
        }
    }
}
