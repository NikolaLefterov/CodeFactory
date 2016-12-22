using System;
using System.Linq;


class GetLargestNumber
{
    
    static void Main()
    {
        GetMax(ReadNumbers());
    }

    static string ReadNumbers()
    {
        string numbers = Console.ReadLine();
        return numbers;
    }
    
    static void GetMax(string inputNumbers)
    {
        int[] arrayNumbers = inputNumbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(arrayNumbers.Max());
    }
}