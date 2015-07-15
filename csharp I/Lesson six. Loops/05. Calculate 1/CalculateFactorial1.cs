using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

class CalculateFactorial1
{
    static void Main()
    {
        Console.Write("Input n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Input x: ");
        int numX = int.Parse(Console.ReadLine());
        if (numN < 1)
        {
            Console.WriteLine("n must be > 1");
        }
        else
        {
            double factorialN = 1;
            double numXPowN = 1;
            double sum = 1;
            for (int i = 1; i <= numN; i++)
            {
                factorialN *= i;
                numXPowN *= numX;
                sum += (factorialN / numXPowN);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
