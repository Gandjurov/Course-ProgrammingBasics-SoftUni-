using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntervalDividableByGivenNumber
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Number for Start:");
        long start = long.Parse(Console.ReadLine());
        Console.WriteLine("Number for end");
        long end = long.Parse(Console.ReadLine());
        long count = 0;
        for (long i = start; i <= end; i++)
            {
            if (i%5==0)
                {
                count++;
                }

            }
        Console.Write("Number P: ");
        Console.WriteLine(count);
        }
    }
    
