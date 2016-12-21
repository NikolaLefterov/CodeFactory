using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] n = new int[N];
            int[] tmp = new int[N];
            int j = 0;
            for (int i = 0; i < N; i++)
            {
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0; i < N-1; i++)
            {
                if(n[i] == n[i + 1]) {
                    counter++;
                }
                else {
                    counter++;
                    tmp[j] = counter;
                    j++;
                    counter = 0;
                }
                    

            }
            counter++;
            tmp[j] = counter;
            Console.WriteLine(tmp.Max());
        }
    }
}
