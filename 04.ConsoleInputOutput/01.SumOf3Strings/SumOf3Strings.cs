using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOf3Strings
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter number 'a':");
        Console.Write("a = ");
        string integer1Str = Console.ReadLine();
        int a = int.Parse(integer1Str);

        Console.WriteLine("Please enter number 'b':");
        Console.Write("b = ");
        string integer2Str = (Console.ReadLine());
        int b = int.Parse(integer2Str);

        Console.WriteLine("Please enter number 'c':");
        Console.Write("c = ");
        string integer3Str = Console.ReadLine();
        int c = int.Parse(integer3Str);

        int sum = a + b + c;
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
        }
    }

