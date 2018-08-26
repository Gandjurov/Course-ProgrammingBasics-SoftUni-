using System;

class NumberSequence
{
    public static string GetSequence(int n, string sequence)
    {
        int sign = 1;
        if (n % 2 == 1)
        {
            sign = -1;
        }
        else
        {
            sign = 1;
        }
        if (n < 2)
        {
            return sequence;
        }
        else
        {
            return GetSequence(n - 1, n * sign + ", " + sequence);
        }
    }
    static void Main()
    {
        int n = 1000;  
        string sequence = "";
        sequence = GetSequence(n + 1, sequence);
        sequence = sequence.Substring(0, sequence.Length - 2) + ".";
        Console.WriteLine(sequence);
    }
}