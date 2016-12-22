using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {

        static int number = 1;

        static void Spiral(int[,] matrix, int row, int col, int n)
        {
            if (number >= n * n)
            {
                return;
            }
            else
            {
                
                while ((row < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                row--;
                col++;
               
                while ((col < n) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col++;
                    number++;
                }
                col--;
                row--;
             
                while ((row >= 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    row--;
                    number++;
                }
                row++;
                col--;
               
                while ((col > 0) && (matrix[row, col] == 0))
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }

                if (matrix[row, col] != 0)
                {
                    row++;
                    col++;
                    Spiral(matrix, row, col, n);
                }
            }
        }

      
        static void Main()
        {
          
          
            int n = int.Parse(Console.ReadLine());
            char input;
            input = char.Parse(Console.ReadLine());
            
            int[,] array = new int[n, n];

            if (input == 'a')
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[j, i] = j + 1 + (n * i);
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    if (i > 0)
                    {
                        Console.WriteLine();
                    }
                    
                    for (int j = 0; j < n; j++)
                    {
                        if (j < n - 1)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        else
                            Console.Write(array[i, j]);
                    }

                }

                Console.WriteLine();
            }
            else if (input == 'b')
            {


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i % 2) == 0)
                        {
                            array[j, i] = j + 1 + (n * i);
                        }
                        else
                        {
                            array[n - j - 1, i] = j + 1 + (n * i);
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    if (i > 0)
                    {
                        Console.WriteLine();
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (j < n - 1)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        else
                            Console.Write(array[i, j]);
                    }
                }

                Console.WriteLine();
            }
            else if (input == 'c')
            {
                int row = n - 1, col = 0, data = 0;

                for (int i = 0; i < n; i++)
                {
                    do
                    {
                        data++;
                        if (row < 0) row = 0;
                        array[row, col] = data;
                        row++;
                        col++;
                    } while (row < n);

                    row -= col + 1;
                    col = 0;
                }

                row = 0;
                col = 1;
                for (int i = 0; i < n - 1; i++)
                {
                    do
                    {
                        data++;
                        array[row, col] = data;
                        row++;
                        col++;
                    } while (col < n);

                    col -= row - 1;
                    row = 0;
                }

                for (int i = 0; i <n; i++)
                {
                    if (i > 0)
                    {
                        Console.WriteLine();
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (j < n - 1)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        else
                            Console.Write(array[i, j]);
                    }
                }

                Console.WriteLine();
            }
            else if (input == 'd')
            {


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[j, i] = 0;
                    }
                }

                Spiral(array, 0, 0, n);

                for (int i = 0; i < n; i++)
                {
                    if (i > 0)
                    {
                        Console.WriteLine();
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (j < n - 1)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                        else
                            Console.Write(array[i,j]);
                        
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
