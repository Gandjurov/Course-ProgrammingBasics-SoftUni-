using System;


class AdvancedBitExchange
    {
    static void Main()
        {
        Console.Write("Enter positive number here: \nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bit to start: \np = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter posiotion of bit to end: \nq = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Haw many bits you wont to exchange: \nk = ");
        int k = int.Parse(Console.ReadLine());
        k = k + 1;

        for (int i = p, j = q; i < p + k - 1; i++, j++) //bits of position {p, p+1, …, p+k-1) and {q, q+1, …, q+k-1}
            {

            //chacking which bits stay of this positions - 0 or 1
            int mask1 = 1 << i;
            int mask2 = 1 << j;
            int bit1 = (n & mask1);
            int bit2 = (n & mask2);

            //bit of position {p, p+1, …, p+k-1) goes to bit of position {q, q+1, …, q+k-1}
            if (bit1 == 0)
                {
                int replacer = 1 << j;
                n = (n & ~replacer);
                }
            else
                {
                int replacer = 1 << j;
                n = (n | replacer);
                }

            //bit of position {q, q+1, …, q+k-1} goes to bit of position {p, p+1, …, p+k-1)
            if (bit2 == 0)
                {
                int replacer = 1 << i;
                n = (n & ~replacer);
                }
            else
                {
                int replacer = 1 << i;
                n = (n | replacer);
                }
            }


        Console.WriteLine("The number after bit changes (p, p+1, ... , p+k-1 <=> q, q+1, ... , q+k-1) is: \n{0}", n);
        }
    }