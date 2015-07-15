using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

class ThirdDigit7
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int a = num / 100;
        int b = a % 10;
        if (b == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
