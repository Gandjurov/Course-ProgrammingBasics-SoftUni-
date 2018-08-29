// 01. Write a program that prints all the numbers from 1 to N.

using System;



class Numbers1toN
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter N numbers: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
            {
            Console.Write("{0} ", i);
            }
        Console.WriteLine();
        }
    }

