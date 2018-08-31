using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RhombusOfStars
{
    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());
        int stars = 1;
        int spaces = n - stars;
 
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < spaces; col++)
            {
                Console.Write(" ");
            }
            for (int col = 0; col < stars; col++)
            {
                Console.Write("* ");
            }
            spaces--;
            stars++;
            Console.WriteLine();
        }
 
       
        spaces = 1;
        stars = n - spaces;
        for (int row = n; row < 2*n; row++)
        {
           
            for (int col = 0; col < spaces; col++)
            {
                Console.Write(" ");
            }
            for (int col = 0; col < stars; col++)
            {
                Console.Write("* ");
            }
            spaces++;
            stars--;
            Console.WriteLine();
            }

    }
}

