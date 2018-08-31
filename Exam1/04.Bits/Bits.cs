using System;



class Bits
    {
    static void Main(string[] args)
        {
        //input
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            {
            int num = int.Parse(Console.ReadLine());

            //logic
            int Pnew = 0;
            while (num != 0)
                {
                Pnew <<= 1;
                Pnew |= (num & 1);
                num >>= 1;
                }

            //output
            Console.WriteLine(Pnew);

            }
        }
    }

