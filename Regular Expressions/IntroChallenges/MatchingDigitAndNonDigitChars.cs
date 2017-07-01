using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntroChallenges
    {
    public class MatchingDigitAndNonDigitChars
        {
        public static void Main (string[] args)
            {
            string testInput = Console.ReadLine();
            Regex regularEx = new Regex("\\d{2}\\D\\d{2}\\D\\d{4}");
            Match result = regularEx.Match(testInput);
            Console.WriteLine(result.Success);
            Console.ReadLine();
            }
        }
    }
