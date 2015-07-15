//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. 
//inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;

class SubStringInText
{
    private static int GetStringOccurrences(string input, string value, bool ignoreCase)
    {
        if (ignoreCase)
        {
            input = input.ToUpper();
            value = value.ToUpper();
        }
        int count = 0;
        int index = input.IndexOf(value, 0);
        while (index != -1)
        {
            count++;
            index = input.IndexOf(value, index + 1);
        }
        return count;
    }
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.Write("Enter the string to search for: ");
        string stringToSearch = Console.ReadLine();
        int count = GetStringOccurrences(text, stringToSearch, true);
        Console.WriteLine("\"{0}\" is contained {1} times.", stringToSearch, count);
    }

}

