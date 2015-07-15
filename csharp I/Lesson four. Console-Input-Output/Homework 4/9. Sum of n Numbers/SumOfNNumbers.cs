using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.

class SumOfNNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        double someNumber = 0;
        Console.Clear();
        Console.WriteLine("Please input {0} numbers:", numberN);
        for (int i = 1; i <= numberN; i++)
        {
            double nNumbers = double.Parse(Console.ReadLine());
            someNumber += nNumbers;
        }
        Console.WriteLine(someNumber);
    }
}

