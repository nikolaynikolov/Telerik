using System;

namespace _12_3
{
    class Program
    {
        static void Main()
        {
            char[] firstArr = { 'a', 'c', 'a', 'h' };
            char[] secArr = { 'a', 'c', 'e', 'h' };
            bool areEqual = true;
            int count = -1;
            if (firstArr.Length == secArr.Length)
            {
                
                for (int i = 0; i < firstArr.Length; i++)
                {
                    
                    if (firstArr[i] != secArr[i])
                    {
                        areEqual = false;
                        break;
                    }
                    count++;

                }
                if (firstArr[count] < secArr[count])
                {
                    Console.WriteLine("First array is lexicographicaly before second array");
                }
                else
                {
                    Console.WriteLine("Second array is lexicographicaly before first array");
                }
            }
            
        }
    }
}
