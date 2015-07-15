using System;
using System.Text;

class Program
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        string theText = Console.ReadLine();
        byte[] asciiBytes = Encoding.ASCII.GetBytes(theText);
        for (int i = 0; i < asciiBytes.Length-1; i++)
        {
            if (((asciiBytes[i] >= 65) & (asciiBytes[i] <= 90)) || ((asciiBytes[i] >= 97) & (asciiBytes[i] <= 122)))
            {
                if (i % 2 == 0 || i==0)
                {
                    double test1 = ((asciiBytes[i] * secretNumber) + 1000);
                    Console.WriteLine("{0:F2}", test1 / 100);
                }
                if (i % 2 != 0)
                {
                    double test1 = ((asciiBytes[i] * secretNumber) + 1000);
                    Console.WriteLine(test1 * 100);
                }

            }
            else if ((asciiBytes[i] >= 48) & (asciiBytes[i] <= 57))
            {
                if (i % 2 == 0 || i == 0)
                {
                    double test2 = ((asciiBytes[i] + secretNumber) + 500);
                    Console.WriteLine("{0:F2}", test2 / 100);
                }
                else if (i % 2 != 0)
                {
                    double test2 = ((asciiBytes[i] + secretNumber) + 500);
                    Console.WriteLine(test2 * 100);
                }

            }
            else if (!(((asciiBytes[i] < 64) & (asciiBytes[i] > 90)) || ((asciiBytes[i] < 97) & (asciiBytes[i] > 122)) || ((asciiBytes[i] < 48) & (asciiBytes[i] > 57))))
            {
                if (i % 2 == 0 || i == 0)
                {
                    double test3 = (asciiBytes[i] - secretNumber);
                    Console.WriteLine("{0:F2}", test3 / 100);
                }
                else if (i % 2 != 0)
                {
                    double test3 = (asciiBytes[i] - secretNumber);
                    Console.WriteLine(test3 * 100);
                }

            }
        }
    }
}