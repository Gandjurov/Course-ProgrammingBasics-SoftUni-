using System;

class MyAge
    {
    static void Main()
        {
            Console.WriteLine("Каква е вашата възраст?");
            uint age = 0;
            age = uint.Parse(Console.ReadLine());
            Console.WriteLine("След 10 години, тя ще бъде");
            Console.Write(age + 10);
            Console.WriteLine("г.");
        }
    }
