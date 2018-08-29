using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



class DecimalToHexadecimal
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter your decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        string hexaStr = dec.ToString("X");

        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

        Console.WriteLine("Hexadecimal number is: {0}", hexaStr);
        }
    }

