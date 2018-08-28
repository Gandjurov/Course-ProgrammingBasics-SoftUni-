using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEven
    {
    static void Main()
        {
        Console.WriteLine("Please enter number: ");
        long a = long.Parse(Console.ReadLine());
            {
            if (a > long.MinValue && a < long.MaxValue)
            {
                if (a % 2 == 0)
                    Console.WriteLine("The entered number is even.");
                else
                    Console.WriteLine("The entered number is odd.");
            }
            
            else
                Console.WriteLine("Error: Please enter a valid number!");
            }
        }
    }

