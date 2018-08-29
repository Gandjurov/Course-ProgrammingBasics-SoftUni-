using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompanyInformation
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Company name");
        Console.Write("Company: ");
        string company = Console.ReadLine();

        Console.WriteLine("Please enter she`s email");
        Console.Write("Email: ");
        string address = Console.ReadLine();

        Console.WriteLine("Telephone number ot the company");
        Console.Write("Telephone number: ");
        string companyPhone = Console.ReadLine();

        Console.WriteLine("Fax: ");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Company yeb site");
        Console.Write("yeb site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("Please enter first name on she`s menager");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter also his last name");
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("how many year old is the manager");
        Console.Write("Age: ");
        string age = Console.ReadLine();

        Console.WriteLine("Manager Phone");
        Console.Write("Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Company: {0} \nAdress: {1} \nPhone: {2}     Fax: {3} \nyeb Site: {4}",
            company, address, companyPhone, companyFax, webSite);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Manager: {0} {1} - {2} age \nPhone Manager: {3}",
            firstName, lastName, age, managerPhone);
        Console.WriteLine(new string('=', 40));
        }
    }

