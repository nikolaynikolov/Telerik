using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the
//reminder of the division by 5 is 0.

class NumbersDividableByGivenNumber
{
    static void Main()
    {
        int firsNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        if ((firsNum < secondNum) && (firsNum >= 0) && (secondNum >= 0))
        {
            int numP = 0;
            for (int i = firsNum; i <= secondNum; i++)
            {
                if ((i % 5) == 0)
                {
                    numP++;
                    //Console.WriteLine(i);
                    //If remove comment from the line above, you will see the numbers between theese you input, that are dividible by 5 without reminder.
                }
            }
            Console.WriteLine(numP);
        }
        else
        {
            Console.WriteLine("First number is bigger than the second, or one of them is negative!");
        }
    }
}
