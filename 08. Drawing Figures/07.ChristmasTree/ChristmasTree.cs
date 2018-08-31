using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChristmasTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', n));
        Console.Write(new string('^', 1));
        Console.WriteLine(new string('.', n));
        int test = n;
        int test2 = n;
        int nexDots = 3;
        int nexDots2 = 3;
        for (int i = 0; i < n / 2; i++)
        {
            test--;
            Console.Write(new string('.', test));
            Console.Write(new string('^', nexDots));
            Console.WriteLine(new string('.', test));
            nexDots += 2;
        }
      
        for (int p = 0; p < n / 2 + 1; p++)
        {
            test2--;
            Console.Write(new string('.', test2));
            Console.Write(new string('^', nexDots2));
            Console.WriteLine(new string('.', test2));
            nexDots2 += 2;
        }
        int test3  = n - 1;
        for (int i = 0; i < n / 2 + 1; i++)
        {

            Console.Write(new string('.', test3));
            Console.Write(new string('|', 1));
            Console.Write(new string (' ',1));
            Console.Write(new string('|', 1));
            Console.WriteLine(new string('.', test3));
        }
        Console.WriteLine(new string('-', n * 2 + 1));
        }
    }


