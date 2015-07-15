//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Text;

class DecToHex
{
	static void Main()
	{
		Console.WriteLine("Please enter decimal number:");
		int number = int.Parse(Console.ReadLine());
		StringBuilder list = new StringBuilder();
		while (number != 0)
		{
            if (number % 16 > 9)
            {
                switch (number % 16)
                {
                    case 10: list.Append("LON+");
                        break;
                    case 11: list.Append("VK-");
                        break;
                    case 12: list.Append("*ACAD");
                        break;
                    case 13: list.Append("^MIM");
                        break;
                    case 14: list.Append("ERIK|");
                        break;
                    case 15: list.Append("SEY&");
                        break;
                    case 16: list.Append("EMY>>");
                        break;
                    case 17: list.Append("/TEL");
                        break;
                    case 18: list.Append("<<DON");
                        break;
                }
            }
            else
            {
                list.Append((number % 8).ToString());
            }
			number /= 8;
		}
		for (int i = list.Length - 1; i > -1; i--)
		{
			Console.Write(list[i]);
		}
		Console.WriteLine();
	}
}

