// 03. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;



class MinMaxSumAverageOfN
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter length of loop: ");
        int length = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        double sum = 0;
        double avg = 0;

        for (int i = 0; i < length; i++)
            {
            int number = int.Parse(Console.ReadLine());

            min = Math.Min(min, number);        //Min

            max = Math.Max(max, number);        //Max

            sum += number;                      //Sum

            avg = sum / length;                 //Avg

            }
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", avg);

        }
    }
