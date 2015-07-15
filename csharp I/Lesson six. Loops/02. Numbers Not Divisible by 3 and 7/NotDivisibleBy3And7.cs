using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible
//by 3 and 7, on a single line, separated by a space.

class NotDivisibleBy3And7
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
            if (!(i % 3 == 0) && !(i % 7 == 0))
            {
                Console.Write(i + " ");
            }
        }
    }
}
