using System;

//Write a program that reads 3 real numbers from the console and prints their sum.


class SumOfTree
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber + secondNumber + thirdNumber);
    }
}

