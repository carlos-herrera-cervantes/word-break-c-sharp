using System;
using WordBreakDomain.Models;

namespace WordBreakConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new[] { "leet", "code" };
            var str = "leetcode";

            var result = SuperString.IsWordBreak(str, dict);

            Console.WriteLine($"Is the word: {str} a word break?: {result}");
        }
    }
}
