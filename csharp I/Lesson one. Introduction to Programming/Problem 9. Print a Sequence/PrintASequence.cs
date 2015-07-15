using System;

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class PrintASequence
{
    static void Main(string[] args)
    {
        int number = 2;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number);
            if (number > 0)
            {
                number++;
            }
            else number--;

            number = number * -1;
        }
    }
}

