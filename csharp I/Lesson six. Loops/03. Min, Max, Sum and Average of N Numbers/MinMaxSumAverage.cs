using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class MinMaxSumAverage
{
    static void Main()
    {
        int numN = 0;
        do
        {
            Console.Clear();
            Console.Write("Please input a positive integer: ");
            numN = int.Parse(Console.ReadLine());
        } while (numN <= 0);

        //I decide to use array, to collect all the input numbers;
        int[] numbers = new int[numN];
        for (int i = 0; i <= numN-1; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //This sorts the members of the array ascending;
        Array.Sort(numbers);
        
        //Here i show first and last item from the array;
        Console.WriteLine("min = {0}", numbers[0]);
        Console.WriteLine("max = {0}", numbers[numN-1]);

        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine("sum = {0}", sum);

        double average = sum / numN;
        Console.WriteLine(string.Format("avg = {0:0.00}", average));
    }
}

