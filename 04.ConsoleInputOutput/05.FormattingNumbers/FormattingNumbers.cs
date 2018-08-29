using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FormattingNumbers
    {
    static void Main(string[] args)
        {
        int numberA = 0;
        double numberB = 0;
        double numberC = 0;
        do
            {
            Console.WriteLine("Please, enter an integer a (0 ≤ a ≤ 500), a floating-point b, a floating-point c," +
                                " by hitting \"Еnter\" for each:");
            bool isParseSuccessful = int.TryParse(Console.ReadLine(), out numberA) && numberA >= 0 && numberA <= 500 &&
                                     double.TryParse(Console.ReadLine(), out numberB) &&
                                     double.TryParse(Console.ReadLine(), out numberC);
            if (isParseSuccessful)
                {
                break;
                }
            else
                {
                Console.WriteLine("You have entered an invalid data. Try again or press \"Cntrl + C\"!");
                }

            } while (true);

        Console.Clear();
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3}", "a", "b", "c", "result");
        Console.WriteLine("{0,-10}{1,-10}{2,-10}|{3,-10:X}|{4,-10}|{5,10:#.##}|{6,-10:0.000}|",
            numberA, numberB, numberC, numberA, Convert.ToString(numberA, 2).PadLeft(10, '0'), numberB, numberC);
        }
    }

