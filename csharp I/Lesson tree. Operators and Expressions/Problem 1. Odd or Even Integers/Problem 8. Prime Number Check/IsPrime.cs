using System;


//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without
//remainder only to itself and 1).
//Note: You should check if the number is positive


class IsPrime
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 1)
        {
            if (n == 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                Console.WriteLine("true");
            }
        }
        else
        {
            Console.WriteLine("The number is 0 or negative!");
        }

    }
}