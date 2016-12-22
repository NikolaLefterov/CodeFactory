using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extactsentece
{
   
    class Program
    {
       static void  Extract(string str, string keyword)
        {
            string[] arr = str.Split('.');
            string answer = string.Empty;

            foreach (string sentence in arr)
            {
                
                string[] words = sentence.Split(new char[] { ' ', ',' });
                if (words.Contains(keyword))
                {
                    answer = sentence;
                    Console.Write(answer+".");
                }
              
            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string input = Console.ReadLine();
            Extract(input, keyword);
        }
    }
}
