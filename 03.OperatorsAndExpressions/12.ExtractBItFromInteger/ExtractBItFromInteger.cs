using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractBItFromInteger
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Give an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Give a position of the bit you want to see: ");
        int position = int.Parse(Console.ReadLine());

        int nRightPosition = number >> position;
        int bit = nRightPosition & 1;
        Console.Write("The bit is: ");
        Console.WriteLine(bit);
        }
    }

