using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourDigitNumber
{
    static void Main(string[] args)
        {
        Console.WriteLine("Enter 4 digit number(Please,can`t start with 0) : ");
        string inputNum = Console.ReadLine();
        int number = int.Parse(inputNum);

        if (inputNum.Length > 4)
            {
            Console.WriteLine("The input number is more than 4 digits long! Try again. ");
            return;
            }
        int a = number / 1000;
        a %= 10;

        int b = number / 100;
        b %= 10;

        int c = number / 10;
        c %= 10;

        int d = number % 10;

        if (a == 0)
            {
            Console.WriteLine("The number musn`t start with 0! Try again. ");
            return;
            }

        int SumOfDigits = (a + b + c + d);
        Console.WriteLine("The sum of the digits is {0}", SumOfDigits);
        Console.WriteLine("Your number is reversed order is " + d + c + b + a);
        Console.WriteLine("Your number with last digit in front is " + d + a + b + c);
        Console.WriteLine("Your number with second and third digits exchanged is " + a + c + b + d);
        }
}
