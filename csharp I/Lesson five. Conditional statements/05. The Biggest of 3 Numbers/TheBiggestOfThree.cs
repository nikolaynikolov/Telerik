using System;

//Write a program that finds the biggest of three numbers.

class TheBiggestOfThree
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());

        if ((numA >= numB) && (numA >= numC))
        {
            Console.WriteLine(numA);
        }
        else if ((numB >= numC) && (numB >= numA))
        {
            Console.WriteLine(numB);
        }
        else if ((numC >= numA) && (numC >= numB))
        {
            Console.WriteLine(numC);
        }
    }
}
