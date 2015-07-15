using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

class EmployeeData
{
    static void Main()
    {
        string firstName = "Peter";
        string lastName = "Ivanov";
        byte age = 30;
        bool isFemale = false;
        long personalID = 8306112507;
        int employeeNumber = 27567999;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine(isFemale == false ? "Gender: Male" : "Gender: Female");
        Console.WriteLine("Personal ID number: " + personalID);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}
