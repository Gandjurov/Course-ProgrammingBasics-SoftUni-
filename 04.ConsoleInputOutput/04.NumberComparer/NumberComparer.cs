using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberComparer
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter first number: ");
        Console.Write("Number 1 = ");
        string num1Str = Console.ReadLine();
        int number1 = int.Parse(num1Str);

        Console.WriteLine("Please enter second number: ");
        Console.Write("Number 2 = ");
        string num2Str = Console.ReadLine();
        int number2 = int.Parse(num2Str);

        int max = number1 - ((number1 - number2) & (number1 - number2) >>31);
        Console.WriteLine("Bigger number is: {0}", max);
        }
    }

