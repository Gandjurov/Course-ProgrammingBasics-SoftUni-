using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class HexadecimalToDecimal
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter hexadecimal value: ");
        string hexa = Console.ReadLine();

        long dec = long.Parse(hexa, NumberStyles.HexNumber);

        Console.WriteLine("Decimal number is : {0}", dec);
        }
    }

