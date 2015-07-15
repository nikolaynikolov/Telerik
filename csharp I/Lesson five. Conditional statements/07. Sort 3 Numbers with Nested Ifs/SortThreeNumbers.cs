using System;

//    Write a program that enters 3 real numbers and prints them sorted in descending order.
//    Use nested if statements.

//Note: Don’t use arrays and the built-in sorting functionality.

class SortThreeNumbers
{
    static void Main()
    {
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());


        if (numA >= numB && numA > numC)
        {
            if (numB >= numC)
            {
                Console.WriteLine("{0} {1} {2}", numA, numB, numC);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numA, numC, numB);
            }
        }

        if (numB > numA && numB >= numC)
        {
            if (numA >= numC)
            {
                Console.WriteLine("{0} {1} {2}", numB, numA, numC);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numB, numC, numA);
            }
        }
        if (numC >= numA && numC > numB)
        {
            if (numA >= numB)
            {
                Console.WriteLine("{0} {1} {2}", numC, numA, numB);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numC, numB, numA);
            }
        }
        if (numA == numB && numA == numC)
        {
            Console.WriteLine("{0} {1} {2}", numC, numB, numA);
        }

    }
}

