﻿//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class ArrayAllocation
{
    static void Main()
    {

        //initialising and declaring an array
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };


        //multiplying its elements by five
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= 5;
        }
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write("{0} ", arr[j]);
        }
        Console.WriteLine();
    }
}
