namespace PrintArrayToTheConsole
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] array = {"one","two","three","four" };

            for (int i = 0; i < array.Length; i++)
            {
                //Print each element on a separate line
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
        }
    }
}
