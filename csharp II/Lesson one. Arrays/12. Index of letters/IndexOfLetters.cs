    //Write a program that creates an array containing all letters from the alphabet (A-Z).
    //Read a word from the console and print the index of each of its letters in the array.

using System;

    class IndexOfLetters
    {
        static void Main()
        {
            //create an array from letters
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //string alphabet = "abcdefghijklmnopqrstuvwxyz";
         //   char[] alphabetChars = alphabet.ToCharArray();
            //reading a word from the console
            string word = Console.ReadLine();

            char[] wordLetters = word.ToCharArray();

            //compare each letter with alphabet
            for (int i = 0; i < alphabet.Length; i++)
            {
                
                Console.WriteLine(Array.BinarySearch<string>(alphabet, "wordLetters[i]"));
            }
        }
    }
