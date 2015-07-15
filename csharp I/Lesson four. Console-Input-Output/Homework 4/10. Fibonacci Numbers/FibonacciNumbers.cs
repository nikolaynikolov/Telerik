using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

class FibonacciNumbers
{
    static void Main()
    {
        int fibonacciLength = int.Parse(Console.ReadLine());
            int numA = 0, numB = 1, numC = 0;

            Console.Write("{0}, {1}", numA, numB);

            for (int i = 2; i < fibonacciLength; i++)
            {
                numC = numA + numB;

                Console.Write(", {0}", numC);

                numA = numB;

                numB = numC;
        }
    }
}
