using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfNumbers
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter N = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 1 && n < 20)
            {
            for (int i = 0; i < n; i++)
                {
                for (int j = i + 1; j <= n + 1; j++)
                    {
                    Console.Write(j + " ");
                    }
                Console.WriteLine();
                }
            }
        else
            {
            Console.WriteLine("Invalid input!");
            }
        }
    }

