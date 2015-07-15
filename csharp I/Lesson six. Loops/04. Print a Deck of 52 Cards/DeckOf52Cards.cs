using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and
//a switch-case statement.

class DeckOf52Cards
{
    static void Main()
    {
        int a = 4;
        int b = 3;
        int c = 6;
        int d = 5;

        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("" + i + (char)a + " " + i + (char)b + " " + i + (char)c + " " + i + (char)d);
            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11:
                            Console.WriteLine("" + "J" + (char)a + " J" + (char)b + " J" + (char)c + " J" + (char)d);
                            break;
                        case 12:
                            Console.WriteLine("" + "D" + (char)a + " D" + (char)b + " D" + (char)c + " D" + (char)d);
                            break;
                        case 13:
                            Console.WriteLine("" + "K" + (char)a + " K" + (char)b + " K" + (char)c + " K" + (char)d);
                            break;
                        case 14:
                            Console.WriteLine("" + "A" + (char)a + " A" + (char)b + " A" + (char)c + " A" + (char)d);
                            break;
                    }
            }
        }

    }
}