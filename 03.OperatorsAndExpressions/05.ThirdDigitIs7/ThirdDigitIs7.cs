using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThirdDigitIs7
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool ThirdDigitIs7 = (number / 100) % 10 == 7;
        Console.WriteLine(ThirdDigitIs7);
        }
    }

