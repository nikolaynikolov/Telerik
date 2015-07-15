using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the
//rectangle R(top=1, left=-1, width=6, height=2).

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (1.5 * 1.5));
        bool isOutsideRectangle = (x > -1) || (x < 5) && (y > -1) || (y < 1);

        if (x == 0 || y == 0)
        {
            Console.WriteLine("no");
        }
        else if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
