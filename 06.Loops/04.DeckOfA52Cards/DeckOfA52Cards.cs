// 04. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 

using System;

class DeckOfA52Cards
    {
    static void Main()
        {
        // Console.WriteLine( "Enter card number");
        // int card=int.Parse(Console.ReadLine());
        int a = 3;
        int b = 4;
        int c = 5;
        int d = 6;
        // Console.WriteLine((char) a);
        for (int i = 2; i < 15; i++)
            {
            if (i > 1 && i < 11)
                {
                Console.WriteLine(" " + ((char)a) + i + " " + ((char)b) + i + " " + ((char)c) + i + " " + ((char)d) + i);

                }
            else
                {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                        {
                        case 11: Console.WriteLine((char)a + "D " + (char)b + "D " + ((char)c) + "D " + ((char)d) + "D "); break;
                        case 12: Console.WriteLine((char)a + "A " + (char)b + "A " + (char)c + "A " + ((char)d) + "A "); break;
                        case 13: Console.WriteLine((char)a + "J " + (char)b + "J " + (char)c + "J " + ((char)d) + "J "); break;
                        case 14: Console.WriteLine((char)a + "K " + (char)b + "K " + (char)c + "K " + ((char)d) + "K "); break;
                        }
                }
            }

        }
    }