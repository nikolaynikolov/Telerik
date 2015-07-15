using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if (numA > 0 && numB > 0 && numC > 0 || numA < 0 && numB < 0 && numC > 0 || numA > 0 && numB < 0 && numC < 0 ||
        numA < 0 && numB > 0 && numC < 0)
        {
            Console.WriteLine("+");
        }
        else if (numA < 0 && numB > 0 && numC > 0 || numA > 0 && numB < 0 && numC > 0 || numA > 0 && numB > 0 && numC < 0 ||
        numA < 0 && numB < 0 && numC < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
