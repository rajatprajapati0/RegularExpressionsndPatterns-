using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpressionsAndPatterns
{
    public class pattern
    {
        public static string Strings = "^[a]{1}[b]{2,}$";
    }
    internal class MatcheString
    {

        public void  MatcheStrings()
        {

            Regex str = new Regex(pattern.Strings);
            bool check = false;
           string inputStr= Console.ReadLine();
            check = str.IsMatch(inputStr);

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
