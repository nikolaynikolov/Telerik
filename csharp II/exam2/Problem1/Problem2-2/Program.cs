using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
           // string number = Console.ReadLine();
            // string number = Console.ReadLine();
            string number = "1 6 8 10 3 1 1";

            string[] numberSeparated = number.Split(' ');
            int a = 0;
            int b = 0;
            int sum = 0;
            for (int i = 0; i < numberSeparated.Length - 1; )
            {
                a = int.Parse(numberSeparated[i + 1]);
                b = int.Parse(numberSeparated[i]);
                int maxFromTwo = Math.Max(a, b);
                int minFromTwo = Math.Min(a, b);
                int sumOfOdd = 0;

                if ((maxFromTwo - minFromTwo) % 2 == 1)
                {
                    sumOfOdd += maxFromTwo - minFromTwo;
                    i += 1;
                    sum += sumOfOdd;
                }
                else
                {
                    i += 2;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
