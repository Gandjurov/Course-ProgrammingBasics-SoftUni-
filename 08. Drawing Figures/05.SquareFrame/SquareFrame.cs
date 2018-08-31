using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareFrame
{
    static void Main(string[] args)
    {
        //here create first line
        var n = int.Parse(Console.ReadLine());
        Console.Write("+");
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write(" -", n - 2);
        }
        Console.Write(" +");
        Console.WriteLine();

        //here create lines |-------|
        for (int row = 1; row <= n - 2; row++)
        {
            Console.Write("|");
            for (int k = 1; k <= n - 2; k++)
            {
                Console.Write(" -", n - 2);
            }
            Console.Write(" |");
            Console.WriteLine();
        }

        //here create last line
        Console.Write("+");
        for (int j = 1; j <= n - 2; j++)
        {
            Console.Write(" -", n - 2);
        }
        Console.Write(" +");
        Console.WriteLine();
    }
}

