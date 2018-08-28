using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleCopyRight
{
static void Main(string[] args)
    {
    Console.OutputEncoding = Encoding.UTF8;

    Console.WriteLine("         \u00A9");
    Console.WriteLine("        \u00A9\u00A9\u00A9");
    Console.WriteLine("       \u00A9\u00A9\u00A9\u00A9\u00A9");
    Console.WriteLine("      \u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9");
    Console.WriteLine("     \u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9");
    Console.WriteLine("    \u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9\u00A9");


    int n = int.Parse(Console.ReadLine());
    for (int row = 0; row < n; row++)
        {
        for (int col = 0; col < 2 * n - 1; col++)
            {
            if ((row + col < n - 1) || (col >= n + row))
                {
                Console.Write(" ");
                }
            else
                {
                Console.Write("\u00A9");
                }
            }
        Console.WriteLine();

        }
    }
}

