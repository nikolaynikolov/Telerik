using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

class NullValues
{
    static void Main()
    {
        int? nullValueInteger = null;
        double? nullValueDouble = null;
        Console.WriteLine("This is the integer with Null value: " + nullValueInteger);
        Console.WriteLine("This is the real number with Null value: " + nullValueDouble);
        nullValueInteger = 5;
        nullValueDouble = 11.3;
        Console.WriteLine("This is the integer with value 5: " + nullValueInteger);
        Console.WriteLine("This is the real number with value 11.3: " + nullValueDouble);
    }
}