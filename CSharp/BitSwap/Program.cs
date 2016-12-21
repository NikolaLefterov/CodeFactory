using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   

class BitsSwap
    {
        static void Main()
        {
            
            uint n = uint.Parse(Console.ReadLine());
         
            int p = int.Parse(Console.ReadLine());
            
            int q = int.Parse(Console.ReadLine());
            
            int k = int.Parse(Console.ReadLine());

          

            if (p + k >= 32)
            {
            return;
            }
            else if (p < q && ((p + q) < k))
            {
            return;
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    int maskOne = (int)(n & (1 << p)) >> p;
                    int maskTwo = (int)(n & (1 << q)) >> q;

                    //mask one
                    if (maskOne == 0)
                    {
                        n = (uint)(n & (~(1 << q)));
                    }
                    else if (maskOne == 1)
                    {
                        n = (uint)(n | (1 << q));
                    }

                    //mask two
                    if (maskTwo == 0)
                    {
                        n = (uint)(n & (~(1 << p)));
                    }
                    else if (maskTwo == 1)
                    {
                        n = (uint)(n | (1 << p));
                    }

                    p++;
                    q++;
                }

                
                Console.WriteLine(n);
            }
        }
    }





