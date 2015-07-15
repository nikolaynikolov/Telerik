using System;

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point
//arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

class FloatCompare
{
    static void Main()
    {
        double a;
        double b;
        double eps = 0.000001;
        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out b);
        double result = a - b;

        //If the result is positive number, compare it with eps
        if (result >= 0)
        {
            if (result < eps)
            {
                Console.WriteLine("Numbers A and B are equal");
            }

            else if (result == eps)
            {
                Console.WriteLine("Numbers A and B are not equal");
            }
            else
            {
                Console.WriteLine("Numbers A and B are not equal");
            }
        }
            //if the result is negative number, make it positive, and compare with eps
        else
        {
            double result2 = result * -1;
            if (result2 < eps)
            {
                Console.WriteLine("Numbers A and B are equal");
            }

            else if (result2 == eps)
            {
                Console.WriteLine("Numbers A and B are not equal");
            }
            else
            {
                Console.WriteLine("Numbers A and B are not equal");
            }
        }
    }
}