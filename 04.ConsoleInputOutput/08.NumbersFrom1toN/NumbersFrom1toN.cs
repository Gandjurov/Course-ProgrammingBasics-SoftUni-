using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersFrom1toN
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter 'n': ");
        Console.Write("n = ");
        string nStr = Console.ReadLine();
        int n = int.Parse(nStr);
        for (int counter = 1; counter <= n; counter++)
            {
            Console.WriteLine(counter);
            }
        }
    }

