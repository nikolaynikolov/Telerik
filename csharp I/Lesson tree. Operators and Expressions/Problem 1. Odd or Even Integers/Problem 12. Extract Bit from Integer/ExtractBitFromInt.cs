using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

class ExtractBitFromInt
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bit = (int)(num >> p) & 1;
        Console.WriteLine(bit);
    }
}
