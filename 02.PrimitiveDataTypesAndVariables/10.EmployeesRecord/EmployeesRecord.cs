using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EmployeesRecord
{
    static void Main(string[] args)
        {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        ushort uniqueEmpNumber; //When you need to record this data in the database you add this number to 27560000.

        firstName = "Dimityr";
        familyName = "Georgiev";
        age = 26;
        gender = 'm';
        idNumber = 667;
        uniqueEmpNumber = 256;

        Console.WriteLine("Personal information about {0} {1}:\n\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
        }
}

