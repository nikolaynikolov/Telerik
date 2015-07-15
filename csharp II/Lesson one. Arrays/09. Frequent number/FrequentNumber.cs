//Write a program that finds the most frequent number in an array.
using System;

class FrequentNumber
{
    static void Main()
    {
        //initialising the variables
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        int frequentNumber = 0;

        //read the array size and elements from console
        Console.Write("Input the lenght of the array: ");
        int arrLen = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLen];

        Console.WriteLine("Input elements of the array: ");
        for (int i = 0; i < arrLen; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //sorting the array
        Array.Sort(arr);

        //using the Maximal Sequence code, to find it. See exercise 04;
        for (int j = 0; j < arr.Length; j++)
        {
            if (j != 0)
            {
                if (arr[j] == arr[j - 1])
                {
                    frequentNumber = arr[j];
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = j + 1 - maxCount;
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", frequentNumber, maxCount);
    }
}
