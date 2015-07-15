namespace ReadArrayFromConsole
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 0;
            n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[n - i - 1] = array[i];
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
               
            }
            for (int i = 0; i < n; i++)
            {
                 Console.Write(reversed[i] + " ");
            }
        }
    }
}
