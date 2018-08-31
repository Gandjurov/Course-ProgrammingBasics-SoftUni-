using System;



class CartezeanSystem
    {
    static void Main(string[] args)
        {
        //input
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //logic
        int result = 0;

        if (x == 0 && y == 0)
            {
            result = 0;
            }
        else if (x > 0 && y > 0)
            {
            result = 1;
            }
        else if (x < 0 && y > 0)
            {
            result = 2;
            }
        else if (x < 0 && y < 0)
            {
            result = 3;
            }
        else if (x > 0 && y < 0)
            {
            result = 4;
            }
        else if (x == 0)
            {
            result = 5;
            }
        else if (y == 0)
            {
            result = 6;
            }
         
        //output
        Console.WriteLine(result);

        }
    }
