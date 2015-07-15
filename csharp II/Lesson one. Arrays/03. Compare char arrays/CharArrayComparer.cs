//Write a program that compares two char arrays lexicographically (letter by letter).

using System;


class CharArrayComparer
{
    static void Main()
    {
        //reading the console and convert the readed string to array of chars
        Console.WriteLine("Please input first char array: ");
        string c1 = Console.ReadLine();
        char[] firstArr = c1.ToCharArray();

        Console.WriteLine("Please input second char array: ");
        string c2 = Console.ReadLine();
        char[] secondArr = c2.ToCharArray();

        //Like the previous exercise:
        if ((firstArr.Length != secondArr.Length))
        {
            Console.WriteLine("The arrays are NOT equal!");
        }

        bool areEqual = true;
        if ((firstArr.Length == secondArr.Length))
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine(areEqual ? "Yes, the arrays are equal!" : "No, the arrays are NOT equal!");
        }

    }
}
