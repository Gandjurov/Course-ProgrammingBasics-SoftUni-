using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEven
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter number: ");

        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int even = 1;
        int odd = 1;


        for (int i = 0; i < numbers.Length; i++)
            {
            int number = int.Parse(numbers[i]);

            if (i % 2 == 0)
                {
                even *= number;
                }
            else
                {
                odd *= number;
                }
            }

        if (even == odd)
            {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + even);
            }
        else
            {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + odd);
            Console.WriteLine("even_product = " + even);
            }
        }
    }

