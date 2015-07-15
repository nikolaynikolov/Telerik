using System;
using System.Collections.Generic;

class ConsoleApplication2
{
    static void Main()
    {
        string end = "END";
        string someText = "test";
        var list = new List<int>();
        do
        {
            someText = Console.ReadLine();
            int num2;
            if (int.TryParse(someText, out num2))
                list.Add(num2);
            //Console.WriteLine(num2);

        } while (!String.Equals(end, someText, StringComparison.Ordinal));
        //   list.ForEach(Console.WriteLine);
        int[] numbers = list.ToArray();
        if (numbers.Length <= 10)
        {
            int globalCalculation1 = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (true)
                {
                    char[] characters = numbers[i].ToString().ToCharArray();
                    int temp = 1;
                    int someValue = 1;
                    for (int j = 0; j < characters.Length; j++)
                    {
                        switch (characters[j].ToString())
                        {
                            case "0": someValue = 0; break;
                            case "1": someValue = 1; break;
                            case "2": someValue = 2; break;
                            case "3": someValue = 3; break;
                            case "4": someValue = 4; break;
                            case "5": someValue = 5; break;
                            case "6": someValue = 6; break;
                            case "7": someValue = 7; break;
                            case "8": someValue = 8; break;
                            case "9": someValue = 9; break;
                        }
                        temp *= someValue;
                    }
                    globalCalculation1 = temp;
                }
                //   globalCalculation1 *= globalCalculation1;

            }
            for (int k = 0; k < numbers.Length; k++)
            {
                globalCalculation1 *= globalCalculation1;
            }
            Console.WriteLine(globalCalculation1);
        }
        else if (numbers.Length > 10)
        {
            int globalCalculation = 1;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (i % 2 == 0 || i == 0)
                {
                    char[] characters = numbers[i].ToString().ToCharArray();
                    int temp = 1;
                    int someValue = 1;
                    for (int j = 0; j < characters.Length; j++)
                    {
                        switch (characters[j].ToString())
                        {
                            case "0": someValue = 0; break;
                            case "1": someValue = 1; break;
                            case "2": someValue = 2; break;
                            case "3": someValue = 3; break;
                            case "4": someValue = 4; break;
                            case "5": someValue = 5; break;
                            case "6": someValue = 6; break;
                            case "7": someValue = 7; break;
                            case "8": someValue = 8; break;
                            case "9": someValue = 9; break;
                        }

                        temp *= someValue;
                    }
                    globalCalculation = temp;
                }


            }
            for (int k = 0; k < numbers.Length; k++)
            {
                globalCalculation *= globalCalculation;
            }
            Console.WriteLine(globalCalculation);
        }
    }
}
