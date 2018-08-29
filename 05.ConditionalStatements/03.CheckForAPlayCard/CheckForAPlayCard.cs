using System;



class CheckForAPlayCard
    {
    static void Main()
        {
        Console.WriteLine("Please enter charakter: ");
        string input = Console.ReadLine();

        switch (input)
            {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "A":
            case "J":
            case "K":
            case "Q":
                Console.WriteLine("Yes");
                break;

            default:
                Console.WriteLine("No");
                break;
            }
        }
    }

