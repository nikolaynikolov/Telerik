using System;

namespace IterateArrayWithLoops
{
    class Program
    {
        static void Main()
        {
            //Iterations with FOR loop
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Output: ");
            for (int i = 0; i < array.Length; i++)
            {
                //Doubling:
                array[i] = array[i] * 2;
                Console.Write(array[i] + " ");
            }
            array = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i+=2)
            {
                array[i] = array[i] * array[i];
                Console.Write(array[i] + " ");
            }
            array = new int[] { 1, 2, 3, 4, 5 };
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            //Iterations with FOREACH loop
            string[] capitals = { "Sofia", "Washington", "LOndon", "Paris" };
            foreach (var capital in capitals)
            {
                Console.WriteLine(capital);
            }

        }
    }
}
