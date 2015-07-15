//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
using System;

class MaxKSum
{
    static void Main()
    {
        Console.Write("Input the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        Console.Write("Input K: ");
        int k = int.Parse(Console.ReadLine());
        int[] arrK = new int[k];

        Console.WriteLine("Input the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrN);

        //Find in the array those K elements that have maximal sum.
        for (int j = arrN.Length - 1; j > arrN.Length - k - 1; j--)
        {
            if (j < arrN.Length - k - 1)
            {
                Console.Write("{0}, ", arrN[j]);
            }
            else
            {
                Console.Write("{0} ", arrN[j]);
            }
        }
    }
}

