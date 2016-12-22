using System;
class SortArr
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = fillArr(n);
        int[] sortedArray = SortArray(array);
        PrintSortedArr(sortedArray,n);
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
    static int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

   
    static void PrintSortedArr(int[] sortArray , int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(sortArray[i]+ " ");
        }
    }
}
