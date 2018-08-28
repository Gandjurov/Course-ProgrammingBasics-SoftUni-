using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangles
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter side a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("please enter side b: ");
        int b = int.Parse(Console.ReadLine());

        double s = a * b;
        double p = ((2 * a) + (2 * b));
        
        Console.WriteLine("The area of rectangle is: ");
        Console.Write(s);
        Console.WriteLine(" sm^2.");

        Console.WriteLine("The perimeter of rectangle is: ");
        Console.Write(p);
        Console.WriteLine(" sm.");
        }
    }

