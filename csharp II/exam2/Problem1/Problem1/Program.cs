using System;
using System.Collections.Generic;

class HexToDec
{
    static int ConvertToDigits(string input)
    {
        int decNumber = 0;
        int index = 0;
        int j = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case 'a': index = 0;
                    break;
                case 'b': index = 1;
                    break;
                case 'c': index = 2;
                    break;
                case 'd': index = 3;
                    break;
                case 'e': index = 4;
                    break;
                case 'f': index = 5;
                    break;
                case 'g': index = 6;
                    break;
                case 'h': index = 7;
                    break;
                case 'i': index = 8;
                    break;
                case 'j': index = 9;
                    break;
                case 'k': index = 10;
                    break;
                case 'l': index = 11;
                    break;
                case 'm': index = 12;
                    break;
                case 'n': index = 13;
                    break;
                case 'o': index = 14;
                    break;
                case 'p': index = 15;
                    break;
                case 'q': index = 16;
                    break;
                case 'r': index = 17;
                    break;
                case 's': index = 18;
                    break;
                default: index = int.Parse(input[i].ToString());
                    break;
            }
            decNumber += index * (int)Math.Pow(19, j);
            j++;
        }
        return (decNumber);
    }

    static readonly string[] TresNumFourDigits = new string[19]
    { 
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s"
    };


    static string ConvertToSymbols(int decimalNumber)
    {
        List<string> CatsNumber = new List<string>();
        do
        {
            CatsNumber.Add(TresNumFourDigits[decimalNumber % 19]);

            decimalNumber /= 19;
        }
        while (decimalNumber != 0);

        CatsNumber.Reverse();
        return string.Join(string.Empty, CatsNumber);
    }


    static void Main()
    {
        string number = Console.ReadLine();
        string[] numberSeparated = number.Split(' ');
        int temp = 0;
        int sum = 0;
        for (int i = 0; i < numberSeparated.Length; i++)
        {
            temp = ConvertToDigits(numberSeparated[i]);
            sum += temp;

        }
        string catsLang = ConvertToSymbols(sum);
        Console.WriteLine("{0} = {1}", catsLang, sum);

    }
}
