using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateNandK
{
static void Main(string[] args)
    {
        
    Console.WriteLine("Enter N = ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter K = ");
    int K = int.Parse(Console.ReadLine());
        
    double rezult = 0.00;
    int FaktN = 1;
    int FakK = 1;
    int temp = 0;
    int diffFakt = 1;
        
    if (N > 1 && K > 1 && N < 100 && K < 100)
        {
            temp = N - K;
            for (int i = 1; i <= temp; i++)
            {
                diffFakt *= i;
            }
            for (int i = 1; i <= N; i++)
            {
                FaktN *= i;
            }
            for (int i = 1; i <= K; i++)
                {
                FakK *= i;
                }
            rezult = FaktN / (FakK * diffFakt);
            Console.WriteLine(rezult);
        }
        else
        {
            Console.WriteLine("Error value!");
        }
    }
}

