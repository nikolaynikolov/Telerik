using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        decimal d = (a + b + c);
        int[] arr = { a, b, c };
        Array.Sort(arr);
        //print the biggest
        Console.WriteLine("{0}", arr[2]);

        //print the smallest
        Console.WriteLine("{0}", arr[0]);

        //print arithmeticMean
        Console.WriteLine("{0:F3}", d/3);

    }
}

