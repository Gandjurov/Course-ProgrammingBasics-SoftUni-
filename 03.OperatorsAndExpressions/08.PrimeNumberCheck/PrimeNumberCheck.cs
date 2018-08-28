using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeNumberCheck
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter the number: ");
        int number = int.Parse(Console.ReadLine());
        int maxResultToCheck = 100;

        bool isPrime = ((number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0) ||
                        (number % 2 > 0) || (number % 3 > 0) || (number % 5 > 0) || (number % 7 > 0));

        Console.Write("Not divisible without remainder: ");
        Console.WriteLine(isPrime);
        }
    }

