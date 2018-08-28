using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DevideBy7and5
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool devideBy5 = number % 5 == 0;
        bool devideBy7 = number % 7 == 0;
        bool devide = devideBy5 && devideBy7;
        Console.WriteLine(devide);
        }
    }

