/*  You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/
using System;
using System.Text.RegularExpressions;

class ParseTags
    {
        private static string ConvertToUpperCase(string input)
        {
            string pattern = @"<upcase>(?<content>(.|\s)+?)</upcase>";
            MatchCollection matches = Regex.Matches(input, pattern);
            string result = Regex.Replace(input, pattern, m => m.Groups["content"].Value.ToUpper());
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string text = Console.ReadLine();
            string result = ConvertToUpperCase(text);
            Console.WriteLine("Your converted text:\n{0}", result);
        }
    }

