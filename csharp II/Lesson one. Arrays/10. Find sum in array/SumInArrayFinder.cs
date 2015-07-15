//Write a program that finds in given array of integers a sequence of given sum S (if present).
using System;

class SumInArrayFinder
{
    static void Main()
    {
        //initialising the variables
        int i = 0;
        int j = 0;
        int k = 0;
        int curentSum = 0;

        //and read the array from console
        Console.Write("Input the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        Console.WriteLine("Input the elements of the array: ");
        for (i = 0; i < n; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Input the sum S: ");
        int sum = int.Parse(Console.ReadLine());

        //searching the sum in array
        for (j = 0; j < arrN.Length; j++)
        {
            curentSum = arrN[j];

            for (k = j + 1; k <= n; k++)
            {
                if (curentSum == sum)
                {
                    for (int l = j; l <= k - 1; l++, j++)
                    {
                        if (j < k - 1)
                        {
                            Console.Write("{0}, ", arrN[j]);
                        }
                        else
                        {
                            Console.Write("{0} ", arrN[j]);
                        }
                    }
                }
                if (curentSum > sum || k == n)
                    break;
                curentSum = curentSum + arrN[k];
            }
            Console.WriteLine();
        }
    }
}