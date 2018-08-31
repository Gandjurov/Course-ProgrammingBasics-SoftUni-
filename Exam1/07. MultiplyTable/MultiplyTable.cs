using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiplyTable
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i * j + "\t");
            }
            Console.Write("\n");
        }

        Console.ReadLine();
    }
}