﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
         
  
            for(int i = 1;i<= n; i++)
            {
                
                for(int j = i; j < n+i; j++)
                {
                   
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
