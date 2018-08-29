using System;




class MultiplicationSign
    {
    static void Main()
        {
        Console.WriteLine("Please enter number A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number C: ");
        int c = int.Parse(Console.ReadLine());


        if (a < 0)
            {
            if (b < 0)
                {
                if (c < 0)
                    {
                    Console.WriteLine("-");
                    }
                else
                    {
                    Console.WriteLine("+");
                    }
                }
            else
                {
                if (c < 0)
                    {
                    Console.WriteLine("-");
                    }
                else
                    {
                    Console.WriteLine("+");
                    }
                }
            }
        else if (a > 0)
            {
            if (b < 0)
                {
                if (c < 0)
                    {
                    Console.WriteLine("+");
                    }
                else
                    {
                    Console.WriteLine("-");
                    }
                }
            else
                {
                if (c < 0)
                    {
                    Console.WriteLine("-");
                    }
                else
                    {
                    Console.WriteLine("+");
                    }
                }
            }
        else if ((a == 0) || (b == 0) || (c == 0))
            {
            Console.WriteLine("0");
            }
        }
    }


