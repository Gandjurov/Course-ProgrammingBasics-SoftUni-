using System;




class UkFlag
    {
    static void Main()
        {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
            {
            for (int col = 0; col < n; col++)
                {
                if (row == n / 2 && col == n / 2)
                    {
                    Console.Write('*');
                    }
                else if (col == n / 2)
                    {
                    Console.Write('|');
                    }
                else if (row == n / 2)
                    {
                    Console.Write('-');
                    }
                else if (row == col)
                    {
                    Console.Write('\\');
                    }
                else if (row == n - 1 - col)
                    {
                    Console.Write('/');
                    }
                else
                    {
                    Console.Write('.');
                    }
                }
            Console.WriteLine();
            }
        }
    }

