using System;
using System.Text.RegularExpressions;

namespace RegexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n {1}", matches.Count, text);

            foreach(Match hit in matches)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
        }
    }
}
