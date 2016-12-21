using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int [] n = new int[N];
            int found = 0;
            bool flag = false;
            for (int i = 0; i < N; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if(n[i] == x) {
                   flag = true;
                    found = i;
                  
                }
               
            }
            if(flag )
            {
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
