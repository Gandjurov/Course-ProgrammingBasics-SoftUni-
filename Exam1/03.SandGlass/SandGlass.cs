﻿using System;




class SandGlass
    {
    static void Main()
        {
        //input
        int n = int.Parse(Console.ReadLine());

        //for (int row = 0; row < n / 2 + 1; row++)
        //    {
        //    string dots = new string('.', row);
        //    string stars = new string('*', n - 2 * row);
        //    Console.WriteLine("{0}{1}{0}", dots, stars);
        //    }
        //for (int row = 2; row <= n / 2 + 1; row++)
        //    {
        //    string dots = new string('.', n / 2 + 1 - row);
        //    string stars = new string('*', row * 2 - 1);
        //    Console.WriteLine("{0}{1}{0}", dots, stars);
        //    }


        for (int row = 0; row < n; row++)
            {
            for (int col = 0; col < n; col++)
                {
                if (row <= n / 2 && (row <= col && row <= n - 1 - col))
                    {
                    Console.Write("*");
                    }
                else if (row > n / 2 && (row >= col && row >= n - 1 - col))
                    {
                    Console.Write("*");
                    }
                else
                    {
                    Console.Write(".");
                    }
                }
            Console.WriteLine();
            }




        }
    }
