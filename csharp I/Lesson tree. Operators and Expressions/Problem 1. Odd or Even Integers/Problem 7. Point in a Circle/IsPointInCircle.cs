using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class IsPointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double check = Math.Sqrt((x * x) + (y * y));
        if (check < 2)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
