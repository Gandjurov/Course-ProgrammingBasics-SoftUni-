using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CalculateFacturial
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X = ");
        int X = int.Parse(Console.ReadLine());

        double result = 1.00;
        double FaktSum = 1.00;
        double tempDivider = 1.00;

        for (int i = 1; i <= n; i++)
            {
            FaktSum *= i;
            tempDivider = tempDivider * n;
            result += FaktSum / tempDivider;
            }
        Console.WriteLine(result);
        }
    }

