using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BooleanVariables
{
    static void Main()
    {
        bool isMale;
        Console.Write("What is your gender (male/female): ");
        string myGender = Console.ReadLine();

        if (myGender == "male")
        {
            isMale = true;
        }
        else
        {
            isMale = false;
        }

        Console.WriteLine("Are you male: " + isMale);
    }
}

