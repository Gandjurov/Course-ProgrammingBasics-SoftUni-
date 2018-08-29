using System;



class ExchangeIFGreater
    {
    static void Main()
        {
        Console.WriteLine("Please enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number b: ");
        int b = int.Parse(Console.ReadLine());

    if (a > b)
        { 
        a = a ^ b;
        b = a ^ b;
        Console.WriteLine(a + " " + b);
        }
    else
        {
        Console.WriteLine(a + " " + b);
        }
    }
}

