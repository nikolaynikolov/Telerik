using System;
using System.Text.RegularExpressions;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class SumOfFive
{
    static void Main()
    {
        string fiveNumbers = Console.ReadLine();
        string regexMatchFiveNumbers = @"([\w\W]*?) ([\w\W]*?) ([\w\W]*?) ([\w\W]*?) ([\w\W])";
        var matchesNumbers = Regex.Match(fiveNumbers, regexMatchFiveNumbers);
        double num1 = double.Parse(matchesNumbers.Groups[1].ToString());
        double num2 = double.Parse(matchesNumbers.Groups[2].ToString());
        double num3 = double.Parse(matchesNumbers.Groups[3].ToString());
        double num4 = double.Parse(matchesNumbers.Groups[4].ToString());
        double num5 = double.Parse(matchesNumbers.Groups[5].ToString());
        double sumOfVive = (num1 + num2 + num3 + num4 + num5);
        Console.WriteLine(sumOfVive);
    }
}
