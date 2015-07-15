using System;
using System.Collections.Generic;
using System.Text;

class MultiCommunication
{
    static void Main()
    {

        var words = new List<string>();
        //var words = new List<string> { "1", "2", "3", "4" };

       // Console.WriteLine("Plase input a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            words.Add(Console.ReadLine());
        }

        //Reorder: 
        for (int i = 0; i < n; i++)
        {
            var word = words[i];
            var newIndex = word.Length % (n + 1);

            words.Insert(newIndex, word);
            if (newIndex < i)
            {
                words.RemoveAt(i + 1);
            }
            else
            {
                words.RemoveAt(i);
            }
        }

        //foreach (var word in words)
        //{
        //    Console.WriteLine(word);
        //}

        var maxLength = 0;
        foreach (var word in words)
        {
            maxLength = Math.Max(maxLength, word.Length);

        }
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < maxLength; i++)
        {
            foreach (var word in words)
            {
                if (word.Length > i)
                {
                    result.Append(word[i]);
                }
            }
        }
        Console.WriteLine(result.ToString());
        //Console.WriteLine("wnptrarhokoitobsevlem");
    }

}

