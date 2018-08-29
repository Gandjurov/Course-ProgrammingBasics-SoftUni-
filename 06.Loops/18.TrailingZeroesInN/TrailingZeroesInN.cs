using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



class TrailingZeroesInN
    {
    static void Main(string[] args)
        {
        Console.WriteLine("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger factN = 1;

        for (int i = 0; i <= n; i++)
			{
			 factN *= i;
			}
        Console.WriteLine("Trailing zeroes of n! = " + (n / 5));
        Console.WriteLine(factN);
        }
    }

