using System;

namespace RegularExpressionsAndPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LowercaseWithUnderscore matcheString = new LowercaseWithUnderscore();
            matcheString.MatcheStrings();
        }
    }
}
