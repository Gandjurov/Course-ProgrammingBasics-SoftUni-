using System;

class SortNumbers
    {
    static void Main()
        {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
            {
            Console.Write("numbers[{0}] =  ", i);
            numbers[i] = int.Parse(Console.ReadLine());
            }

        Array.Sort(numbers);
        Console.WriteLine("\nSorted array: ");
        PrintArray(numbers);

        }

    private static void PrintArray(int[] numbers)
        {

        for (int i = 0; i < numbers.Length; i++)
            {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
            }
        }

    }