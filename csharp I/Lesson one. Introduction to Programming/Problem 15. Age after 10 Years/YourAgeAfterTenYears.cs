using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class YourAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("How old are you?");
        string yourAge = Console.ReadLine();
        int yourAgeNow;
        int.TryParse(yourAge, out yourAgeNow);

        Console.WriteLine("After ten years, you will be {0} old", yourAgeNow + 10);
    }
}
