using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class Program
    {

        static public void MergeSort(int[] numbers, int left, int mid, int right, int n)
        {
            int[] temp = new int[n];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right, int n)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid,n);
                MergeSort_Recursive(numbers, (mid + 1), right,n);

                MergeSort(numbers, left, (mid + 1), right, n);
            }
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            

            
            MergeSort_Recursive(numbers, 0, N - 1,N);
            for (int i = 0; i <N; i++)
                Console.WriteLine(numbers[i]);

           

        }
    }
}