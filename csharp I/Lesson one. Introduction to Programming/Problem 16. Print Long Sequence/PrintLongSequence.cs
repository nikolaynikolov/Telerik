using System;


    //Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
    //You might need to learn how to use loops in C# (search in Internet).

class PrintLongSequence
{
    static void Main()
    {
        int number = 2;
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine(number);
            if (number > 0)
            {
                number++;
            }
            else number--;

            number = number * -1;
        }
        Console.Read();
    }
}
