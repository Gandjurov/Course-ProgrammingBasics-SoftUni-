using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointOfCircleAndOutsideOfARectangle
    {
    static void Main(string[] args)
        {
        decimal x, y;
        Console.WriteLine("Please enter coordinates x = ");
        x = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please enter coordinates y = ");
        y = Convert.ToDecimal(Console.ReadLine());
            {
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9)
                {
                Console.WriteLine("The point is IN the circle");
                if ((x < (-1)) || (x > 5))
                    {
                    Console.WriteLine("the point is OUTSIDE the rectangle.");
                    }
                else
                    {
                    if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))
                        {
                        Console.WriteLine("The point is IN the rectangle.");
                        }
                    }
                }
            else
            {
            Console.WriteLine("The point is OUT the circle.");
            if ((x < (-1)) || (x > 5))
                {
                Console.WriteLine("The point is OUTSIDE the rectangle.");
                }
            else
                {
                if (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)))

                    Console.WriteLine("The point IN the rectangle.");
                }
            }

            }
        }
    }

