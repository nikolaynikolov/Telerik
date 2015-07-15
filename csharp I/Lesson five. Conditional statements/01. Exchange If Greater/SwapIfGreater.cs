using System;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one
//is greater than the second one. As a result print the values a and b, separated by a space.

class SwapIfGreater
{
    static void Main()
    {
        Console.Write("Input variable A: ");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Input variable B: ");
        double numB = double.Parse(Console.ReadLine());
        double temp = 0;
        if (numA > numB)
        {
            temp = numA;
            numA = numB;
            numB = temp;
        }
        Console.WriteLine("{0} {1}", numA, numB);
    }
}
