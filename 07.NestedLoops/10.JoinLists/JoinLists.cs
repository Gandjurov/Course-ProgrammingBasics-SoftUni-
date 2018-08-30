using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class JoinLists
    {
    static void Main()
        {
        
        Console.SetIn(new StreamReader("../../input.txt"));

        string[] firstLine = Console.ReadLine().Split(' ');
        string[] secondLine = Console.ReadLine().Split(' ');

        SortedSet<int> sortedNumbers = new SortedSet<int>();
        foreach (var number in firstLine) sortedNumbers.Add(int.Parse(number));
        foreach (var number in secondLine) sortedNumbers.Add(int.Parse(number));
        foreach (var number in sortedNumbers) Console.Write(number + " ");
        }
    }
