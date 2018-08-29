using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter your decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        long rest;
        string binary = string.Empty;

        while (dec > 0)
            {
            rest = dec % 2;
            dec /= 2;
            binary = rest.ToString() + binary;
            }

        
        Console.WriteLine("Binary number is: {0}", binary);
        }
    }

