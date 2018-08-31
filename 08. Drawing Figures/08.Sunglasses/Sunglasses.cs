using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunglasses
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int slash = (2 * n) - 2;
        int stars = 1;
        int line = n;
        int spaces = n;
        // first row
        for (int f = 1; f <= 2 * n ; f++)
        {
            Console.Write("*");
        }
 
        for (int l = 1; l <= n; l++)
        {
            Console.Write(" ");
        }
 
        for (int f = 1; f <= 2 * n; f++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        //body
        for (int i = 1; i <= n - 2; i++)
        {
            if (i == (n - 1) / 2)
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', stars), new string('/', slash), new string('|', line));
            else
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', stars), new string('/', slash), new string(' ', spaces));
 
        }
       
        // last row
        for (int f = 1; f <= 2 * n; f++)
        {
            Console.Write("*");
        }
 
        for (int l = 1; l <= n; l++)
        {
            Console.Write(" ");
        }
 
        for (int f = 1; f <= 2 * n; f++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        }
    }

