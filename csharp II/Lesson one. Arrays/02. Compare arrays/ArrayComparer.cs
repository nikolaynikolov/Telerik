//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class ArrayComparer
{
    static void Main()
    {
        //read from console the lenght of the arrays
        Console.Write("Please input the lenght of the 1st array: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];

        Console.Write("Please input the lenght of the 2nd array: ");
        int m = int.Parse(Console.ReadLine());
        int[] secondArr = new int[m];

        //read the elements of arrays
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.WriteLine("Input {0} number of the 1st array: ", i + 1);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.WriteLine("Input {0} number of the 2nd array: ", i + 1);
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        //comparing the lenght of arrays
        if ((firstArr.Length != secondArr.Length))
        {
            Console.WriteLine("The arrays are NOT equal!");
        }

        bool areEqual = true;

        //comparing arrays index by index
        if ((firstArr.Length == secondArr.Length))
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }
            Console.WriteLine(areEqual ? "Yes, the arrays are equal!" : "No, the arrays are NOT equal!");
        }

    }
}
