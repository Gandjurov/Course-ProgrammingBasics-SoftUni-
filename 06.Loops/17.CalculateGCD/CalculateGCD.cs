using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateGCD
    {
    static void Main(string[] args)
        {
        Console.WriteLine("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b = ");
        int b = int.Parse(Console.ReadLine());

        int c = 0;

        while (b != 0)
            {
            c = b;
            b = a % b;
            a = c;
            }
        Console.WriteLine("Greatest common divisor: {0}", a);
        }
    }

