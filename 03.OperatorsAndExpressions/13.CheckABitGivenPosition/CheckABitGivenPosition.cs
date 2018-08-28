using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckABitGivenPosition
    {
    static void Main(string[] args)
        {

        Console.WriteLine("Fint if the bit on a given position of a given integer is 1:\n");

        Console.WriteLine("Type the integer you want:\n");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("Type the position of the bit you want to check:");
        int p = int.Parse(Console.ReadLine());

        
        int mask = 1 << p;
        int nAndMask = v & mask;
        int bit = nAndMask >> p;

        Console.WriteLine("\n");

        bool check = (bit == 1);

        if (check)
            {
            Console.WriteLine("It is {0} that the bit on position: \"{1}\" of the integer: \"{2}\" is 1", check, p, v);
            }
        else
            {
            Console.WriteLine("It is {0} that the bit on position: \"{1}\" of the integer: \"{2}\" is 1", check, p, v);
            }
        }
    }

