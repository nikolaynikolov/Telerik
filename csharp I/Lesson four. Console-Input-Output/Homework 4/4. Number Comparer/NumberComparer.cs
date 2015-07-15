using System;

    //Write a program that gets two numbers from the console and prints the greater of them.
    //Try to implement this without if statements.

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double numA = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double numB = double.Parse(Console.ReadLine());

        Console.WriteLine((numA > numB)? numA : numB);
    }
}
