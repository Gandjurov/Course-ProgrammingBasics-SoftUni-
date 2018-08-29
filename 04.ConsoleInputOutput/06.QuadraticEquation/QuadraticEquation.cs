using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
class QuadraticEquation
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter 'a': ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter 'b': ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter 'c': ");
        double c = double.Parse(Console.ReadLine());

        double x;
        double x1;
        double x2;
        double d = (b * b) - (4 * a * c);

        if (d < 0)
            {
            Console.WriteLine("Equation has no real roots!");
            }
        else if (d == 0)
            {
            x = -b / (2 * a);
            Console.WriteLine("Equation has only one real root - {0}", x);
            }
        else
            {
            x1 = (-b + Math.Sqrt(d) / 2 * a);
            x2 = (-b + Math.Sqrt(d) / 2 * a);
            Console.WriteLine("The equation has two real roots - {0} and {1}", x1,x2);
            }
        }
    }

