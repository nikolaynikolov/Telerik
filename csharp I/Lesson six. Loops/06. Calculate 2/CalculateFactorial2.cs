using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

class CalculateFactorial2
{
    static void Main()
    {
        Console.Write("Input n: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Input k: ");
        int numK = int.Parse(Console.ReadLine());

        if (numK > numN || numK < 1 || numN < 1 || numN > 100 || numK > 100)
        {
            Console.WriteLine("n and k must be in range (1 < k < n < 100)");
        }
        else
        {
            BigInteger result = 1;
            for (int i = numN; i > numK; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
