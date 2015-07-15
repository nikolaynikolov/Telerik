//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
    static void Main()
    {
        int width = 20;
        Console.Write("Input a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(input.PadRight(width, '*'));
    }
}

