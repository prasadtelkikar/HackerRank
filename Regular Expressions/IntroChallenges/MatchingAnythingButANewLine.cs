using System;
using System.Text.RegularExpressions;

namespace IntroChallenges
    {
    public class MatchingAnythingButANewLine
        {
        public static void Main (string[] args)
            {
            Tester t = new Tester();
            t.Check(".{3}\\..{3}\\..{3}\\..{3}");

            }
        }
    public class Tester
        {
        public void Check (string pattern)
            {
            string inputString = Console.ReadLine();
            Regex regEx = new Regex(pattern);
            Match match = regEx.Match(inputString);
            Console.WriteLine(match.Success);
            Console.ReadKey();
            }
        }
    }
