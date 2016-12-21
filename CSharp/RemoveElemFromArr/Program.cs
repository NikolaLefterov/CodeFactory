using System;
using System.Collections.Generic;

public class RemoveElementsFromArray
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }
        int[] subsetLength = new int[numbers.Count];

      
        for (int i = 0; i < numbers.Count; i++)
        {
            subsetLength[i] = 1;
        }

        int maxSubset = 1;

        for (int i = 1; i < numbers.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                 if (numbers[i] >= numbers[j] && subsetLength[i] <= subsetLength[j] + 1)
                {
                    subsetLength[i] = subsetLength[j] + 1;
                   
                    maxSubset = Math.Max(maxSubset, subsetLength[i]);
                }
            }
        }

      
        int numbersToRemove = n - maxSubset;
        Console.WriteLine(numbersToRemove);
    }

  
}