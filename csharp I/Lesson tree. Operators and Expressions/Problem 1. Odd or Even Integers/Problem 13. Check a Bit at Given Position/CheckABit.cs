using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

class CheckABit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bit = (int)(num >> p) & 1;
        bool bitCheck = (bit == 1);
        Console.WriteLine(bitCheck);
    }
}
