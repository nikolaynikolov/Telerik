using System;
using System.Numerics;

    //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Input n: ");
        int numN = int.Parse(Console.ReadLine());

        if (numN < 0 || numN > 100)
        {
            Console.WriteLine("n must be in range (0 <= n <= 100)");
        }
        else
        {
            BigInteger catalanNum = 1;
            for (int i = numN; i > 1; i--)
            {
                catalanNum *= (i + numN) / i;
            }

            Console.WriteLine("{0}", catalanNum);
        }
    }
}
