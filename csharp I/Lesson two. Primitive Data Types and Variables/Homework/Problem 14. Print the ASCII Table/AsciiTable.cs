using System;

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints
//the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them
//differently.
//Note: You may need to use for-loops (learn in Internet how).

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int character = 0; character < 255; character++)
        {
            char symbol = (char)character;
            Console.WriteLine("{0} -> {1}", character, symbol);
        }
    }
}
