using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sum5Numbers
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter 5 number in a separate line: ");
        
        decimal dcmA = decimal.Parse(Console.ReadLine());
        decimal dcmB = decimal.Parse(Console.ReadLine());
        decimal dcmC = decimal.Parse(Console.ReadLine());
        decimal dcmD = decimal.Parse(Console.ReadLine());
        decimal dcmE = decimal.Parse(Console.ReadLine());
        decimal sum = dcmA + dcmB + dcmC + dcmD + dcmE;
        
        Console.WriteLine("{0} {1} {2} {3} {4} =--> The sum of numbers is: {5}", dcmA, dcmB, dcmC, dcmD, dcmE, sum);
         
        }
    }

