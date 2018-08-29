using System;



class IntDoubleAndString
{
static void Main(string[] args)
    {
    Console.WriteLine("Enter 1 for int, 2 for double, and 3 for string");
    byte choice = byte.Parse(Console.ReadLine());
    
    
    switch (choice)
        {
        case 1:
            int intChoice = int.Parse(Console.ReadLine());
            Console.WriteLine(intChoice + 1);
            break;
        case 2:
            double doubleChoice = double.Parse(Console.ReadLine());
            Console.WriteLine(doubleChoice + 1.00);
            break;
        case 3:
            string stringChoice = Console.ReadLine();
            Console.WriteLine(stringChoice + "*");
            break;
        default: Console.WriteLine("Invalid input!");
            break;
        }
    }
}

