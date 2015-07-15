using System;
//Write an expression that checks if given integer is odd or even.


class OddOrEven
{
    static void Main()
    {
        int oddOrEven = int.Parse(Console.ReadLine());
        int a = oddOrEven % 2;
        if (a == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}
