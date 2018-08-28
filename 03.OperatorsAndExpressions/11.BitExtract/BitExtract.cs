using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitExtract
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter your integer: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int numberMask = number & mask;
        int bit = numberMask >> 3;
        Console.Write("Third bit is: ");
        Console.WriteLine(bit);
        }
    }
