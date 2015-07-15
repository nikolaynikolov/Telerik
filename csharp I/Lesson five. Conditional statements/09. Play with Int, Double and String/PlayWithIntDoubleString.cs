using System;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        string choise = Console.ReadLine();
        switch (choise)
        {
            case "1":
                Console.WriteLine("Please enter a int:");
                int choiseOne = int.Parse(Console.ReadLine());
                Console.WriteLine(choiseOne + 1);
                break;
            case "2":
                Console.WriteLine("Please enter a double:");
                double choiseTwo = double.Parse(Console.ReadLine());
                Console.WriteLine(choiseTwo + 1);
                break;
            case "3":
                Console.WriteLine("Please enter a string:");
                string choiseThree = Console.ReadLine();
                Console.WriteLine("{0}*", choiseThree);
                break;

            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}
