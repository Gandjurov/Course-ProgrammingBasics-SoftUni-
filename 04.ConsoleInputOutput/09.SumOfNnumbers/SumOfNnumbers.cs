using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfNnumbers
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
            {
            Console.WriteLine("Please enter next number n{0}",i);
            number = int.Parse(Console.ReadLine());
            sum = sum + number; 
            }
        Console.WriteLine("Sum of number {0}", sum);
        }
    }
    
