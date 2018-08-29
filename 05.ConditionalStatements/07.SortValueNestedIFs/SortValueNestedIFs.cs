using System;



class SortValueNestedIFs
    {
    static void Main()
        {
        Console.Write("Number A:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Number B:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Number C:");
        int c = int.Parse(Console.ReadLine());

        if (a > b)
            {
            if (a > c)
                {
                if (b > c)
                    {
                    Console.WriteLine("{0} | {1} | {2}", a, b, c);
                    }
                else
                    {
                    Console.WriteLine("{0} | {1} | {2}", a, c, b);
                    }
                }
            else
                {
                Console.WriteLine("{0} | {1} | {2}", c, a, b);
                }
            }
        else if (b > c)
            {
            if (a > c)
                {
                Console.WriteLine("{0} | {1} | {2}", b, a, c);
                }
            else
                {
                Console.WriteLine("{0} | {1} | {2}", b, c, a);
                }
            }
        else
            {
            Console.WriteLine("{0} | {1} | {2}", c, b, a);
            }
        Console.WriteLine();
        }
    }
 
