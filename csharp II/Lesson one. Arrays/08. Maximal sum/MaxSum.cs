using System;

class MaxSum
{
    static void Main()
    {
        //initialising the variables
        int startOfSequence = 0;
        int endOfSequence = 0;
        int tempStart = 0;
        int maxSum = int.MinValue;
        int sum = 0;
        //and read the array from console
        Console.Write("Input the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        Console.WriteLine("Input the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arrN[i] = int.Parse(Console.ReadLine());
        }

        //search for the max sequence
        for (int i = 0; i < arrN.Length; i++)
        {
            sum += arrN[i];

            if (sum > maxSum)
            {
                maxSum = sum;
                endOfSequence = i;
                startOfSequence = tempStart;
            }

            if (sum <= 0)
            {
                sum = 0;
                tempStart = i + 1;
            }
        }

        //Print the sequence, with numbers separated by comma, exept ater the last element
        for (int i = startOfSequence; i <= endOfSequence; i++)
        {
            if (i < endOfSequence)
            {
                Console.Write("{0}, ", arrN[i]);
            }
            else
            {
                Console.Write("{0} ", arrN[i]);
            }
        }
        Console.WriteLine();

    }
}
