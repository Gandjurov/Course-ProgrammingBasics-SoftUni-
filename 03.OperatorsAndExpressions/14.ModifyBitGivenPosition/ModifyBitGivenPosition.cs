using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ModifyBitGivenPosition
{
    static void Main(string[] args)
    {
    Console.Write("Enter a number (Min value = 0, Max value = ");
    int number = int.Parse( Console.ReadLine());

    Console.WriteLine("Enter the bit position, the bit in it, you want to change:");
    int p = int.Parse( Console.ReadLine());

    Console.WriteLine("\nEnter the value you want to put in the bit at position: ");
    int v = int.Parse(Console.ReadLine());

    int oldNumber = number;
    int mask = 1 << p; 
    int bitP = (number & mask) >> p;
    if (v == 1)
    {
            // let's change the bit value in p from 0 to 1
            number = number | mask;
    }
    else if (v == 0)
    {
            // let's change the bit value from 1 to 0
            mask = ~mask;
            number = number & mask;
    }

    Console.WriteLine("\n\nResult : \n\nOld bit value " + bitP + " ---> " + v + " New bit value \n\n"
+ "Old number " + oldNumber + " ---> " + number + " New number\n\n\n ");
}
}


