﻿//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.
using System;

class DayOfWeek
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.DayOfWeek);

        //Or this way:
        //Console.WriteLine(DateTime.Now.DayOfWeek);

    }
}
