using System;
using System.IO;

class StringsInCSharp
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\StringsInCSharp.txt");
        string stringsExplained = reader.ReadToEnd();
        Console.WriteLine(stringsExplained);
        Console.WriteLine("*******************************************");
        Console.WriteLine("Press Enter key to exit.");
        Console.ReadLine();
    }
}

