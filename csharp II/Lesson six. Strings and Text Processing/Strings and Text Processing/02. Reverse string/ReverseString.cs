//    Write a program that reads a string, reverses it and prints the result at the console.

//Example:
//input 	output
//sample 	elpmas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static string ReverseString(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }


    static void Main()
    {
        Console.WriteLine("Input a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(ReverseString(input));
    }
}

