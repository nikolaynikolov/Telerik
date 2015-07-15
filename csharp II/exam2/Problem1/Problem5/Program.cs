using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] beforeAfter = new string[n];
            string methods = @"static [\w\W]*? ([\w\W]*?)\(";
            List<string> Metodi = new List<string>();
            //string methodMatch;
            //   var methodMatch;
            for (int i = 0; i < n; i++)
            {
                beforeAfter[i] = Console.ReadLine();


            }
            foreach (var item in beforeAfter)
            {
                var methodMatch = Regex.Match(item, methods);
                //Console.WriteLine(methodMatch.Groups[1].ToString());
                Metodi.Add(methodMatch.Groups[1].ToString());
           
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Metodi<i>);
            }

        }

    }
}
