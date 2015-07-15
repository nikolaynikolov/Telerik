using System;

//Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

class NumberFormatting
{
    static void Main()
    {

        Console.Write("Enter first number: ");
        int numA = int.Parse(Console.ReadLine());
        string bitA = Convert.ToString(numA, 2).PadLeft(10, '0');
        if (numA >= 0 && numA <= 500)
        {
            Console.Write("Enter second number: ");
            double numB = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double numC = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10:X}|{1}|{2,10:N2}|{3,-10:0.000}|", numA, bitA, numB, numC);
        }
        else Console.WriteLine("Invalid integer A!");
    }
}
