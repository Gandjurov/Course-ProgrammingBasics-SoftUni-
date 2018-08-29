using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fibonacci
    {
    static void Main(string[] args)
        {
        decimal num1 = 0;
        Console.WriteLine(num1);
        decimal num2 = 1M;
        Console.WriteLine(num2);
        decimal num3 = 0;
        for (decimal i = 0; i < 100; i++)
            {
            num3 = num1 + num2;
            Console.WriteLine(num3);
            num1 = num2;
            num2 = num3;
            }
        }
    }

