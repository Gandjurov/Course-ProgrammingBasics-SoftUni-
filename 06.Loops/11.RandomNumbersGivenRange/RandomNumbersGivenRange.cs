using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbersGivenRange
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Minimum value = ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Maximum value = ");
        int max = int.Parse(Console.ReadLine());

        if (min <= max)
            {
            Random random = new Random();

            for (int i = 0; i < n; i++)
                {
                Console.Write(random.Next(min, max + 1) + " ");
                }
            
            Console.WriteLine();
            }
        }
    }
    
