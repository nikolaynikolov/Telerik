//Write methods that calculate the surface of a triangle by given:
//-Side and an altitude to it;
//-Three sides;
//-Two sides and an angle between them;

using System;
using System.Globalization;

class Program
{
    private enum TriangleAreaOption : byte
    {
        SideAndAltitude = 1,
        ThreeSides = 2,
        TwoSidesAndAngle = 3
    }


    private static double CalculateArea(double a, double b, int degrees)
    {
        double radians = degrees * Math.PI / 180;
        return (a * b * Math.Sin(radians)) / 2;
    }


    private static void CalculateTriangleAreaByTwoSidesAndAngle()
    {
        double a = 0.0;
        double b = 0.0;
        int degrees = 0;

        Console.Write("Enter the length of the first side: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Enter the angle between the sides: ");
        degrees = int.Parse(Console.ReadLine());

        double area = CalculateArea(a, b, degrees);
        Console.WriteLine("The area of the triangle is {0:N4}.", area);
    }


    private static double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }


    private static bool IsTrianglePossible(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }


    private static void CalculateTriangleAreaByThreeSides()
    {
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;

        Console.Write("Enter the length of the first side: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second side: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Enter the angle between the sides: ");
        c = int.Parse(Console.ReadLine());

        double area = CalculateArea(a, b, c);
        Console.WriteLine("The area of the triangle is {0:N4}.", area);

    }


    private static double CalculateArea(double a, double ha)
    {
        return (a * ha) / 2;
    }


    private static void CalculateTriangleAreaBySideAndAltitude()
    {
        double a = 0.0;
        double ha = 0.0;
        Console.Write("Enter the length of the side: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of the altitude: ");
        ha = double.Parse(Console.ReadLine());

        double area = CalculateArea(a, ha);

        Console.WriteLine("The area of the triangle is {0:N4}.", area);
    }


    static void Main()
    {
        int userChoise = 0;
        Console.WriteLine("Please choose a variant to calculate the area of a triangle:");
        Console.WriteLine("Press 1 if you are given a side and an altitude perpendicular to it.");
        Console.WriteLine("Press 2 if you are given three sides.");
        Console.WriteLine("Press 3 if you are given two sides and the angle between them.");
        userChoise = int.Parse(Console.ReadLine());

        switch (userChoise)
        {
            case 1:
                {
                    CalculateTriangleAreaBySideAndAltitude();
                    break;
                }
            case 2:
                {
                    CalculateTriangleAreaByThreeSides();
                    break;
                }
            case 3:
                {
                    CalculateTriangleAreaByTwoSidesAndAngle();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
}
