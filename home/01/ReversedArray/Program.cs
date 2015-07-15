using System;

namespace ReversedArray
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1,2,3,4,5};
            //Get array size
            int length = array.Length;
            //Declare and create reversed array
            int[] reversed = new int[length];

            //initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            //Print reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
        }
    }
}
