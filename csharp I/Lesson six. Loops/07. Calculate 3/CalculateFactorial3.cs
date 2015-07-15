using System;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
//Try to use only two loops.


class CalculateFactorial3
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
            BigInteger factorialNtoK = 1;
            for (int i = numN; i > numK; i--)
            {
                factorialNtoK *= i;
            }

            BigInteger divisorFactorial = 1;
            for (int j = 2; j <= (numN - numK); j++)
            {
                divisorFactorial *= j;
            }

            BigInteger result = factorialNtoK / divisorFactorial;
            Console.WriteLine(result);
        }
    }
}
