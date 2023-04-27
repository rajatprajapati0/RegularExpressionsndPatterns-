using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionsAndPatterns
{
    public class pattern
    {
        public static string Strings = "^[a]+_[b]$";
    }
    internal class LowercaseWithUnderscore
    {

        public void  MatcheStrings()
        {

            Regex str = new Regex(pattern.Strings);
            bool check = false;
           string inputLoweCaseStr= Console.ReadLine();
            check = str.IsMatch(inputLoweCaseStr);

            if (check==true)
            {
                Console.WriteLine("match");

            }
            else 
            {
                Console.WriteLine("notMatch");
            }
        }   
    }
}
