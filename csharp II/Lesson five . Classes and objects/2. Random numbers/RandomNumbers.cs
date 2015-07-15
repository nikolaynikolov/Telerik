//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;

class TenRandomNmbers
{
    private static Random randomGenerator = new Random();

    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            //must be to 201, so you can get 200 as result
            int randomValue = randomGenerator.Next(100, 201);
            Console.WriteLine(randomValue);
        }
    }
}