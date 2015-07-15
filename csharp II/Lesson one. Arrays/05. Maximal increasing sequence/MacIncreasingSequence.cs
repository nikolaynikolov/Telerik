//    Write a program that finds the maximal increasing sequence in an array.
using System;


class MacIncreasingSequence
{
    static void Main()
    {
        {
            int maxCount = 0;
            int currentCount = 1;
            int sequenceStart = 0;
            Console.Write("Input the lenght of the array: ");
            int arrLen = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLen];

            Console.WriteLine("Input elements of the array: ");
            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int j = 0; j < arr.Length; j++)
            {
                if (j != 0)
                {
                    if (arr[j] > arr[j - 1])
                    {
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
            Console.Write("The maximal sequence of equal elements is: ");
            for (int k = sequenceStart; k < sequenceStart + maxCount; k++)
            {
                if (k < sequenceStart + maxCount - 1)
                {
                    Console.Write("{0}, ", arr[k]);
                }
                else
                {
                    Console.Write("{0} ", arr[k]);
                }
            }
            Console.WriteLine();
        }
    }
}
