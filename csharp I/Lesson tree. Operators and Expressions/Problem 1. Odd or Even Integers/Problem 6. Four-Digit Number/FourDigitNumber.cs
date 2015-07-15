using System;

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//    Prints on the console the number in reversed order: dcba (in our example 1102).
//    Puts the last digit in the first position: dabc (in our example 1201).
//    Exchanges the second and the third digits: acbd (in our example 2101).
//    The number has always exactly 4 digits and cannot start with 0.

class FourDigitNumber
{
    static void Main()
    {
        int fourDigitNumber = int.Parse(Console.ReadLine());
        int fourthDigit = fourDigitNumber % 10;
        int a = fourDigitNumber / 10;
        int thirdDigit = a % 10;
        int b = a / 10;
        int secondDigit = b % 10;
        int c = b / 10;
        int firstDigit = c % 10;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}
