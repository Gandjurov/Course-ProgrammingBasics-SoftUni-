using System;



class BiggestOfFiveNumbers
    {
    static void Main()
        {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        double BiggestNumber = firstNumber;

        if (BiggestNumber < secondNumber)
            {
            BiggestNumber = secondNumber;
            }
        if (BiggestNumber < thirdNumber)
            {
            BiggestNumber = thirdNumber;
            }
        if (BiggestNumber < fourthNumber)
            {
            BiggestNumber = fourthNumber;
            }
        if (BiggestNumber < fifthNumber)
            {
            BiggestNumber = fifthNumber;
            }
        Console.WriteLine("The greatest variable is {0}", BiggestNumber);
        }
    }
    
