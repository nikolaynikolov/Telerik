using System;


namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[6];
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            myArray[1] = 1;
            myArray[5] = 5;
            
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr[i] = i;
            }

        }
    }
}
