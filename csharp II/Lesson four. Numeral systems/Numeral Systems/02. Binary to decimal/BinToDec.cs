//Write a program to convert binary numbers to their decimal representation.
using System;


    class BinToDec
    {
        static void Main()
        {
            Console.WriteLine("Please enter binary number:");
            string number = Console.ReadLine();
            int decNumber = 0;
            int index = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                decNumber += (int)(int.Parse(number[i].ToString()) * Math.Pow(2, index));
                index++;
            }
            Console.WriteLine(decNumber);
        }
    }
