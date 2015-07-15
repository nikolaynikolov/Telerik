using System;

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        if (phoneNumber.Length > 7)
        {
            Console.WriteLine("Tel. " + phoneNumber);            
        }
        else
        {
            Console.WriteLine("Tel. (No phone)");
        }

        if (faxNumber.Length > 7)
        {
            Console.WriteLine("Fax: " + faxNumber);
        }
        else
        {
            Console.WriteLine("Fax: (No fax)");
        }

        Console.WriteLine("Web site: " + webSite);

        if (managerPhone.Length > 7)
        {
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
        }
        else
        {
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. (No phone)");
        }
    }
}
