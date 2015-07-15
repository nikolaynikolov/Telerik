using System;

namespace _12_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input first array lenght: ");
            int firstArrLen = int.Parse(Console.ReadLine());
            int[] firstArr = new int[firstArrLen];
            for (int i = 0; i < firstArrLen; i++)
            {
                Console.WriteLine("Input the {0} element of the first array: ", i);
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Input second array length: ");
            int secondArrLen = int.Parse(Console.ReadLine());
            int[] secondArr = new int[secondArrLen];
            for (int i = 0; i < secondArrLen; i++)
            {
                Console.WriteLine("Input the {0} element of the second array: ", i);
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            //foreach (var item in firstArr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //foreach (var item in secondArr)
            //{
            //    Console.Write(item + " ");
            //}
            bool areEqual = true;
            if (firstArrLen == secondArrLen)
            {
                for (int i = 0; i < firstArrLen; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        areEqual = false;
                    }
                }
                if (areEqual == false)
                {
                    Console.WriteLine("The arrays are NOT equal");
                }
                else
                {
                    Console.WriteLine("The arrays are equal");
                }
            }
            else
            {
                Console.WriteLine("The arrays are NOT equal");
            }
 
        }
    }
}
