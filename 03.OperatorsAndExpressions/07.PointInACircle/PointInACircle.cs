using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointInACircle
{
static void Main(string[] args)
    {
    Console.WriteLine("Please enter coordinates x: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter coordinates y: ");
    double y = double.Parse(Console.ReadLine());
    double circleRadius = 2;
    double point = (Math.Pow(x, 2) + Math.Pow(y, 2));
    double r = (Math.Pow(circleRadius, 2));
    Console.WriteLine(point < r ? "The point is within the circle K(0,0)2" : "The point is outside the circle K(0,0)2.");
    }
}

