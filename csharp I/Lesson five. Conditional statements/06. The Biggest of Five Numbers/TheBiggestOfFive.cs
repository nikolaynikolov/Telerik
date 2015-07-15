using System;

//Write a program that finds the biggest of five numbers by using only five if statements.

class TheBiggestOfFive
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());
        double numD = double.Parse(Console.ReadLine());
        double numE = double.Parse(Console.ReadLine());

        if ((numA >= numB) && (numA >= numC) && (numA >= numD) && (numA >= numE))
        {
            Console.WriteLine(numA);
        }
        else if ((numB >= numC) && (numB >= numA) && (numB >= numD) && (numB >= numE))
        {
            Console.WriteLine(numB);
        }
        else if ((numC >= numA) && (numC >= numB) && (numC >= numD) && (numC >= numE))
        {
            Console.WriteLine(numC);
        }
        else if ((numD >= numA) && (numD >= numB) && (numD >= numC) && (numD >= numE))
        {
            Console.WriteLine(numD);
        }
        else if ((numE >= numA) && (numE >= numB) && (numE >= numC) && (numE >= numD))
        {
            Console.WriteLine(numE);
        }
    }
}
