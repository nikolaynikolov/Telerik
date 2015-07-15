using System;
using System.Text;
//odd - necheten
//even - cheten

class Program
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        string theText = Console.ReadLine();
        byte[] asciiBytes = Encoding.ASCII.GetBytes(theText);
        // char[] characters = theText.ToCharArray();
        foreach (byte b in asciiBytes)
        {
            if (((b >= 65) & (b <= 90))||((b >= 97) & (b <= 122)))
            {
                Console.WriteLine((b * secretNumber) + 1000);
                for (int i = 0; i < asciiBytes.Length; i++)
                {
                    if (asciiBytes[i] % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", b / 100);
                    }
                    if (asciiBytes[i] % 2 != 0)
                    {
                        Console.WriteLine(b * 100);
                    }
                }
            }
            if ((b >= 48) & (b <= 57))
            {
                Console.WriteLine((b + secretNumber) + 500);
                for (int i = 0; i < asciiBytes.Length; i++)
                {
                    if (asciiBytes[i] % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", b / 100);
                    }
                    if (asciiBytes[i] % 2 != 0)
                    {
                        Console.WriteLine(b * 100);
                    }
                }
            }
            if (((b >= 64) & (b <= 90)) || ((b >= 97) & (b <= 122)) || ((b >= 48) & (b <= 57)))
            {
                Console.WriteLine(b - secretNumber);
                for (int i = 0; i < asciiBytes.Length; i++)
                {
                    if (asciiBytes[i] % 2 == 0)
                    {
                        Console.WriteLine("{0:F2}", b / 100);
                    }
                    if (asciiBytes[i] % 2 != 0)
                    {
                        Console.WriteLine(b * 100);
                    }
                }
            }
        }
    }
}