using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NullValues
    {
    static void Main(string[] args)
        {
        int? a = null;
        double? b = null;

        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}",a ,b);

        a += null;
        b += 3.1415926; // Adding value to null variable results null!!!

        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
        }
    }
 
