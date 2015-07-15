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
            string number = Console.ReadLine();

            string[] numberSeparated = number.Split(' ');
            float a = 0;
            float b = 0;
            float sum = 0;
            for (int i = 1; i < numberSeparated.Length; )
            {
                a = int.Parse(numberSeparated[i]);
                b = int.Parse(numberSeparated[i - 1]);
                float maxFromTwo = Math.Max(a, b);
                float minFromTwo = Math.Min(a, b);
                float sumOfOdd = 0;
                
                bool isOdd =( maxFromTwo - minFromTwo) %2 ==1;


                if (isOdd == true)
                {
                    sumOfOdd += maxFromTwo - minFromTwo;
                    float absolute = Math.Abs(sumOfOdd);
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
