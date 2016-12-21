using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexofaletter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            int[] n = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                n[i] = Convert.ToInt32(input[i]);
                Console.WriteLine(n[i]-97);
            }
           
        }
    }
}
