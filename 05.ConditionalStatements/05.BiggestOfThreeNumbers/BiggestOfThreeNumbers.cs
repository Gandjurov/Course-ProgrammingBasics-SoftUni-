using System;




class BiggestOfThreeNumbers
    {
    static void Main()
        {
        Console.WriteLine("A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("C: ");
        int c = int.Parse(Console.ReadLine());

        if ((a >= b && a >= c))
            {
            Console.WriteLine("{0} is the biggest integer.", a);
            }
        else if ((b >= a && b >= c))
            {
            Console.WriteLine("{0} is the biggest integer.", b);
            }
        else
            {
            Console.WriteLine("{0} is the biggest interger.", c);
            }
           
        }
    }

