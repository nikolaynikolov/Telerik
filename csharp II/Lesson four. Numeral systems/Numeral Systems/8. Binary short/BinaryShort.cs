//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter a short integer number: ");
        short n;
        short.TryParse(Console.ReadLine(), out n);
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(n, 2));
    }
}
