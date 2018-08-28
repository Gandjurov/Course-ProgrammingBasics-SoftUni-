using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringAndObjects
{
    static void Main(string[] args)
    {
        string word1 = "Hello";
        string word2 = "World!";

        object concatenation = word1 + " " + word2;
        string result = concatenation.ToString();

        Console.WriteLine(result);
    }
}
