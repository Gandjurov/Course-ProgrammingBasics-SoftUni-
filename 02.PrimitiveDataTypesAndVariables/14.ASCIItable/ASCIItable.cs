using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ASCIItable
{
    static void Main(string[] args)
    {
    for (int c = 0; c < 127; c++)
        {
        Console.WriteLine("Character: {0} = {1}", c, (char)c);
        }
    }
}

