using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//and solves it (prints its real roots).

class QuadricEquation
{
    static void Main()
    {
        double numA;
        double numB;
        double numC;

        Console.WriteLine("Input first number A: ");
        numA = double.Parse(Console.ReadLine());
        if (numA != 0)
        {
            Console.WriteLine("Input second number B: ");
            numB = double.Parse(Console.ReadLine());
            Console.WriteLine("Input third number C: ");
            numC = double.Parse(Console.ReadLine());

            if ((Math.Pow(numB, 2) - (4 * numA * numC)) < 0)
            {
                Console.WriteLine("No real roots!");
            }

            else
            {
                double x1 = 0;
                double x2 = 0;
                x1 = ((-numB) - Math.Sqrt((Math.Pow(numB, 2) - (4 * numA * numC)))) / (2 * numA);
                x2 = ((-numB) + Math.Sqrt((Math.Pow(numB, 2) - (4 * numA * numC)))) / (2 * numA);

                if (x1 == x2)
                {
                    Console.WriteLine("x1 = x2 = " + x1);
                }

                else
                {
                    Console.WriteLine("x1 = " + x1 + "; x2 = " + x2);
                }
            }

        }
        else
        {
            Console.WriteLine("First number A must be not zero!");
        }

    }

}
