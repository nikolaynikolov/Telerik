//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static bool IsBalanced(string text, char open = '(', char close = ')')
    {
        var level = 0;
        foreach (var character in text)
        {
            if (character == close)
            {
                if (level == 0)
                {
                    return false;
                }
                level--;
            }
            if (character == open)
            {
                level++;
            }
        }
        return level == 0;
    }


    static void Main()
    {
        Console.Write("Enter an expression to check: ");
        string expression = Console.ReadLine();
        Console.WriteLine("\"{0}\" is {1}correct.", expression, IsBalanced(expression) ? string.Empty : "not ");

    }
}
