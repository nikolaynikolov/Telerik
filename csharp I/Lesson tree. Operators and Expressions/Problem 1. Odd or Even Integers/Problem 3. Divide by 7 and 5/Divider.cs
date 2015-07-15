using System;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

class Divider
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if ((num % 7 == 0) && (num % 5 == 0 ) && (num != 0))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
