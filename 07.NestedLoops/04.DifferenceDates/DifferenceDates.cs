using System;



class PeriodOfDays
    {
    static void Main()
        {
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        DateTime endDay = DateTime.Parse(Console.ReadLine());
        double days = CountDays(startDate, endDay);

        Console.WriteLine("Days between: {0}", days);
        }

    private static double CountDays(DateTime start, DateTime end)
        {
        TimeSpan span = end - start;
        double result = span.TotalDays;

        return result;
        }
    }
