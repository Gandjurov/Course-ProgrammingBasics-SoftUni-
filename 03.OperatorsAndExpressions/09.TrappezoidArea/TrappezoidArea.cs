using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrappezoidArea
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter side 'a': ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side 'b': ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side 'h': ");
        double h = double.Parse(Console.ReadLine());

        double s = (a + b) / 2 * h;

        Console.Write("The area of trappezoid is: ");
        Console.WriteLine(s);
        }
    }

