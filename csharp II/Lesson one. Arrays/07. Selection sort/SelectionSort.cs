//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Input the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        Console.WriteLine("Input the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrN.Length - 1; i++)
        {
            for (int j = i + 1; j < arrN.Length; j++)
            {
                if (arrN[i] > arrN[j]) // swap items
                {
                    int tmp = arrN[i];
                    arrN[i] = arrN[j];
                    arrN[j] = tmp;
                }
            }
        }
        for (int i = 0; i < arrN.Length; i++) // print sorted array
        {
            Console.Write(arrN[i] + " ");
        }
        Console.WriteLine();
    }
}
