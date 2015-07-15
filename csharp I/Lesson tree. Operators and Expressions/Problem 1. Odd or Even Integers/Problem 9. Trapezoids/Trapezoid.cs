using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

class Trapezoid
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double heightH = double.Parse(Console.ReadLine());
        //S = (a + b) / 2 * h.
        double area = (sideA + sideB) / 2 * heightH;
        Console.WriteLine(area);
    }
} 
