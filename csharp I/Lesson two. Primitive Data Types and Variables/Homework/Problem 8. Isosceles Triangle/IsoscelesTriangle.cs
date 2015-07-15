﻿using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©
//  © ©
// ©   ©
//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to
//UTF-8 and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string triangle = ("   " + copyRight + "\n" + "  " + copyRight + " " + copyRight + "\n" + " " + copyRight + "   " + copyRight + "\n" + copyRight + " " + copyRight + " " + copyRight + " " + copyRight);
        Console.WriteLine(triangle);
    }
}
