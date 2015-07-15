//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.
using System;

class LeapYearCheck
{
    static void Main()
    {
        string inputYear = string.Empty;
        int year = 0;
        do
        {
            Console.Write("Input a year: ");
            inputYear = Console.ReadLine();
        }
        while (!Int32.TryParse(inputYear, out year) || year < 1 || year > 9999);
        bool isLeapYear = DateTime.IsLeapYear(year);

        //Method one:
        Console.WriteLine("This is{0} a leap year.", isLeapYear ? string.Empty : " not");

        //Method two:
        //if (isLeapYear == true)
        //{
        //    Console.WriteLine("This is a leap year.");
        //}
        //else
        //{
        //    Console.WriteLine("This is not a leap year.");
        //}

    }
}
