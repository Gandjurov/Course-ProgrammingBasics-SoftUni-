using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CircleParameterAndArea
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter radius on the circle:");
        Console.Write("r = ");
        string radius = Console.ReadLine();
        double r = double.Parse(radius);

        double perimeter = 2 * r * Math.PI;
        double area = Math.Pow(r, 2) * Math.PI;
        Console.WriteLine("Perimeter = {0:0.00}", perimeter);
        Console.WriteLine("Area = {0:0.00}", area);
        }
    }

