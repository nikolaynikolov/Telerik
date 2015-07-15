//Write a program to convert hexadecimal numbers to their decimal representation.
using System;

class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Please enter decimal number (use capslook): ");
        string number = Console.ReadLine();
        int decNumber = 0;
        int index = 0;
        int j = 0;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            switch (number[i])
            {
                case 'A': index = 10;
                    break;
                case 'B': index = 11;
                    break;
                case 'C': index = 12;
                    break;
                case 'D': index = 13;
                    break;
                case 'E': index = 14;
                    break;
                case 'F': index = 15;
                    break;
                default: index = int.Parse(number[i].ToString());
                    break;
            }
            decNumber += index * (int)Math.Pow(16, j);
            j++;
        }
        Console.WriteLine(decNumber);
    }
}
