//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
using System;
using System.Globalization;
using System.Linq;

class WorkingDays
{
    private static DateTime[] nationalHolidays2015 = {
                                                    new DateTime(2015, 1, 1),    //nova godina
                                                    new DateTime(2015, 3, 3),    //osvobojdenieto
                                                    new DateTime(2015, 4, 10),   //velikden
                                                    new DateTime(2015, 4, 13),   //velikden
                                                    new DateTime(2015, 5, 1),    //den na truda
                                                    new DateTime(2015, 5, 6),    //den na armiata
                                                    new DateTime(2015, 9, 22),   //nezavisimostta
                                                    new DateTime(2015, 12, 24),  //nova godina
                                                    new DateTime(2015, 12, 25),  //nova godina
                                                    new DateTime(2015, 12, 31)   //nova godina
                                                    };

    private static bool IsWorkDay(DateTime date)
    {
        return date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Friday;
    }
    static void Main()
    {
        DateTime userInput;
        DateTime futureDate;
        DateTime today = DateTime.Today;
        Console.Write("Enter a future date during this year (dd.MM.yyyy): ");
        userInput = DateTime.Parse(Console.ReadLine());
        futureDate = userInput;

        DateTime currentDate = today;
        int count = 0;
        do
        {
            currentDate = currentDate.AddDays(1);
            if (IsWorkDay(currentDate) && !nationalHolidays2015.Contains(currentDate))
            {
                count++;
            }
        }
        while (currentDate < futureDate);
        Console.WriteLine("There are {0} work days until {1:dd.MM.yyyy}.", count, futureDate);
    }
}
