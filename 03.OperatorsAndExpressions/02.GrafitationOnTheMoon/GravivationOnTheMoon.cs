using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GravivationOnTheMoon
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Please enter your weight: ");
        double mass = double.Parse(Console.ReadLine());

        double powAcMoon = (0.17 * 9.8);
        double moonWeight = (mass * powAcMoon);
        Console.Write("Your weight on the moon is: ");
        Console.Write(moonWeight);
        Console.WriteLine(" kg.");
        }
    }
