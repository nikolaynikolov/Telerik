using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line,
//separated by a space.

class NumbersFrom1ToN
{
    static void Main()
    {
        int numN = 0;
        do
        {
            Console.Clear();
            Console.Write("Please input a positive integer: ");
            numN = int.Parse(Console.ReadLine());
        } while (numN <= 0);

        for (int i = 1; i <= numN; i++)
        {
            Console.Write(i + " ");
        }
    }
}
