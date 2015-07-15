﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ReadingGriffin
{
    class Game
    {
         static int LetterGathererX = Console.WindowWidth / 2 - 2;
        static int GathererSize = 3;
        static int LetterPositionY = 0;
        static Random Count = new Random();

        static List<int> positionX = new List<int>();
        static List<int> positionY = new List<int>();
        static List<char> Letters = new List<char>();
        
        static void Main()
        {
              //Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            for (int i = 0; i < 10; i++)
            {
                positionX.Add(0);
            }

            for (int i = 0; i < 10; i++)
            {
                positionY.Add(0);
            }

            GetLetter();
            while (true)
            {
                Console.Clear();
                PrintLetter();
                LetterGatherer();
                Move();

                Thread.Sleep(60);
            }
        }
        
        static void GetLetter()
        {
            char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                              'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y','Z'};

            Random generateRandomLetter = new Random();

            for (int i = 0; i < 10; i++)
            {
                char randomLetter = letters[generateRandomLetter.Next(0, 25)];
                Letters.Add(randomLetter);
            }
        }

        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void LetterGatherer()
        {
            for (int x = LetterGathererX; x < LetterGathererX + GathererSize; x++)
            {
                PrintAtPosition(x, Console.WindowHeight - 1, '@');
            }
        }

        static void Move()
        {
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    if (LetterGathererX != Console.WindowWidth - 3)
                    {
                        LetterGathererX++;
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    if (LetterGathererX != 0)
                    {
                        LetterGathererX--;
                    }
                }
            }

        }

        //static void GenerateFallingLetter()
        //{
        //    char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        //                      'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y','Z'};

        //    Random positionX = new Random();
        //    Random positionY = new Random();
        //    Random generateRandomLetter = new Random();

        //    char randomLetter = letters[generateRandomLetter.Next(0, 25)];

        //    PrintAtPosition(positionX.Next(0, 80), positionY.Next(0, 3), randomLetter);
        //}

        static int GetInitialPosition()
        {
            Random positionX = new Random();

            return positionX.Next(0, 80);
        }

        static void SetZerosToY(List<int> positionY)
        {
            for (int i = 0; i < 10; i++)
            {
                positionY.Add(0);
            }
        }

        static void PrintLetter()
        {
            int spaceBetweenNextLetter = Count.Next(0, 2);

            if (spaceBetweenNextLetter == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    positionX[i] = GetInitialPosition();

                    PrintAtPosition(positionX[i], positionY[i], Letters[i]);

                    positionY[i] += 1;
                }


                spaceBetweenNextLetter = Count.Next(0, 2);
            }
            else
            {
                spaceBetweenNextLetter--;
            }
            
            //if (LetterPositionY == Console.WindowHeight -1)
            //{
            //    LetterPositionY = 0;
            //}




            //LetterPositionY++;

            //PrintAtPosition(GetInitialPosition(), LetterPositionY, randomLetter);

        }
    }
}
