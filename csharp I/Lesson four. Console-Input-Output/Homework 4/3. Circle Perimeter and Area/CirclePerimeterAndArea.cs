using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted 
//with 2 digits after the decimal point.

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius r of a circle: ");
            double radiusOfCircle = double.Parse(Console.ReadLine());
            double areaOfCircle = (Math.PI) * (Math.Pow(radiusOfCircle, 2));
            double perimeterOfCircle = (2 * Math.PI) * radiusOfCircle;

            Console.WriteLine("Perimeter: {0:0.00}", perimeterOfCircle);
            Console.WriteLine("Area: {0:0.00}", areaOfCircle);
        }
    }
