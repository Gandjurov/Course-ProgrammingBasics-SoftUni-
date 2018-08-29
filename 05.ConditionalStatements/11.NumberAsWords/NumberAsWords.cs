using System;



    class NumberAsWords
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Enter the number between in the range[0...999]");
            int number = int.Parse(Console.ReadLine());

            string[] digit = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] special = { "", "eleven", "twelve", "thirteen", "fourtheen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] round = { "", "then", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int temp = 0;


            if (number <= 999)    //<-- range [0...999]
                {

                if (number == 0) //<-- only zero
                    {
                    Console.WriteLine("zero");
                    }
                else if (number != 0 && number < 10)  // <-- range[1...9]<-- digit
                    {
                    for (int i = number; i < digit.Length; i = +11)
                        {
                        temp = i % 10;
                        Console.WriteLine("{0}", digit[temp]);

                        }
                    }
                else if (number > 10 && number < 20)  //<-- range[11...19]<-- special
                    {
                    for (int i = number; i >= special.Length; i = -i)
                        {
                        temp = i % 10;
                        Console.WriteLine("{0}", special[temp]);

                        }
                    }
                else if (number % 10 == 0 && number < 99) // <-- range[10..20...90]<--round
                    {
                    for (int i = number; i >= round.Length; i = -i)
                        {
                        temp = i / 10;
                        Console.WriteLine("{0}", round[temp]);
                        }
                    }
                else if (number >= 20 && number <= 99) // <-- range[20...99]<--round and digit
                    {
                    for (int i = number; i >= round.Length; i = -i)
                        {
                        temp = i / 10;
                        Console.Write("{0}", round[temp]);
                        }
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", digit[temp]);
                        }

                    }
                else if (number >= 100 && number % 100 == 0) // <--range[100..200.....900]<--digit
                    {
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i / 100;
                        Console.WriteLine("{0}" + " " + "hundred", digit[temp]);
                        }
                    }
                else if (number > 100 && number / 10 == 10) // <-- range[101...109]<--digit and hundred
                    {
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i / 100;
                        Console.Write("{0}", digit[temp]);
                        Console.Write(" " + "hundred");
                        temp = i % 10;
                        Console.Write(" " + "and" + " " + "{0}", digit[temp]);
                        Console.WriteLine();
                        }
                    }
                else if (number > 110 && number < 920 && (number / 10) % 10 == 1) // <-- range[111.211..919]<--digit and hundred and special
                    {
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i / 100;
                        Console.Write("{0}" + " " + "hundred" + " " + "and", digit[temp]);
                        }
                    for (int i = number; i >= special.Length; i = -i)
                        {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", special[temp]);
                        }
                    }
                else if (number >= 110 && number <= 999) // <-- range[110.210.320.990..999]<--digit and hundred and round and digit
                    {
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i / 100;
                        Console.Write("{0}" + " " + "hundred" + " " + "and", digit[temp]);
                        }
                    for (int i = number; i >= round.Length; i = -i)
                        {
                        temp = (i / 10) % 10;
                        Console.Write(" " + "{0}", round[temp]);
                        }
                    for (int i = number; i >= digit.Length; i = -i)
                        {
                        temp = i % 10;
                        Console.WriteLine(" " + "{0}", digit[temp]);
                        }
                    }
                }
            else
                {
                Console.WriteLine("Out of range! Please enter the number in the range [0 ....999]");
                }
            }
        }

