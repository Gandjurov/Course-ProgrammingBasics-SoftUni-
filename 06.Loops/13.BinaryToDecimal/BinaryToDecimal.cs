using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter your binary number: ");
        string binary = Console.ReadLine();

        long dec = 0;

        for (int i = 0; i < binary.Length; i++)
            {
            if (binary[binary.Length - i - 1] == 0)
                {
                continue;
                }
            dec += (long)Math.Pow(2, i);
            }
        Console.WriteLine("Decimal number is : {0}", dec);
        }
    }
    
