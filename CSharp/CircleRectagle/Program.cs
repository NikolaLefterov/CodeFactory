using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class CircleREctagle
{
    static void Main()
    {
     
        double x = double.Parse(Console.ReadLine());
      
        double y = double.Parse(Console.ReadLine());
        if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
        {
            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
            bool isOutsideRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);


            if (isInCircle == true)
            {
                if (isOutsideRectangle == true)
                    Console.WriteLine("inside circle inside rectangle");
                else
                    Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                if (isOutsideRectangle == true)
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
            }
        }
        else
            Console.WriteLine("outside circle inside rectangle");
    }
}