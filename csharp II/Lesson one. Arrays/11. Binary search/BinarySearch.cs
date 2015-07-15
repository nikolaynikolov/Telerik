//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;

class BinarySearch
{

    //implementing the Binary Search algorythm (I use google, do not discover hot water by myself :D )
    public static object BinarySearchTest(int[] inputArray, int key, int min, int max)
    {
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (key == inputArray[mid])
            {
                return ++mid;
            }
            else if (key < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return "Element is not in the array";
    }


    static void Main()
    {
        //read the searched element from console
        Console.Write("Input the  searched element: ");
        int searchedElement = int.Parse(Console.ReadLine());

        //read the array lenght from console
        Console.Write("Input the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        //read the array elements
        Console.WriteLine("Elements must be sorted! Input the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The element is at {0} position in the array.",BinarySearchTest(arrN, searchedElement, arrN[0], arrN.Length));


        //using integrated method Array.BinarySearch
        //int index = Array.BinarySearch(arrN, searchedElement);
        //Console.WriteLine("The searched element is at index {0} in the array", index);
    }


 
}


