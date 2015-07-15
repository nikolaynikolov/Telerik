//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Globalization;
using System.Linq;

class CalculateIntegerSum
{
    private static bool Validate(string[] values)
    {
        if (values == null || values.Length == 0)
        {
            return false;
        }
        for (int i = 0; i < values.Length; i++)
        {
            int number;
            if (!Int32.TryParse(values[i], out number))
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        string[] numbers;
        string inputString;
        do
        {
            Console.Write("Input a sequence of positive integer values: ");
            inputString = Console.ReadLine();
            numbers = inputString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        }
        while (!Validate(numbers));
        int n = numbers.Length;
        int[] integers = new int[n];
        for (int i = 0; i < n; i++)
        {
            integers[i] = Int32.Parse(numbers[i]);
        }
        try
        {
            int sum = integers.Sum();
            Console.WriteLine("The sum is {0}.", sum);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}