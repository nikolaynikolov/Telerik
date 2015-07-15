using System;

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
//each on a single line.
//Note: You may need to use a for-loop.

class NumbersFrom1ToN
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        Console.Clear();
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }

    }
}
