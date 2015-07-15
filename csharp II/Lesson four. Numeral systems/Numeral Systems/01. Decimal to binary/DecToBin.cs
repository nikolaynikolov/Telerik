﻿//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        Console.Write("number: ");
        int binary = int.Parse(Console.ReadLine());
        string binaryNumber = "";

        List<int> digits = new List<int>();

        if (binary >= 0)
        {
            while (binary != 0)
            {
                digits.Add(binary % 2);
                binary /= 2;
            }

            digits.Reverse();

            for (int i = 0; i < digits.Count; i++)
            {
                binaryNumber += digits[i];
            }

            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber = "0" + binaryNumber;
            }
        }
        else
        {
            binary = Math.Abs(binary) - 1;

            while (binary != 0)
            {
                digits.Add(binary % 2);
                binary /= 2;
            }

            digits.Reverse();

            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] == 0)
                {
                    binaryNumber += "1";
                }
                else
                {
                    binaryNumber += "0";
                }
            }

            while (binaryNumber.Length % 16 != 0)
            {
                binaryNumber = "1" + binaryNumber;
            }
        }
        Console.Write("Result: ");
        Console.WriteLine(binaryNumber);
    }
}