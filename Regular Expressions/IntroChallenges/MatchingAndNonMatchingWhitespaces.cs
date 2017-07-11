using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntroChallenges
    {
    public class MatchingAndNonMatchingWhitespaces
        {
        public static void Main (string[] args)
            {
            string input = Console.ReadLine();
            Regex regularEx = new Regex(@"\S{2}\s\S{2}\s\S{2}"); //for whiteSpaces and non whitespaces
            //Regex regularEx = new Regex(@"\w{3}\W\w{10}\W\w{3}"); //for Matching word and non word
            //Regex regularEx = new Regex(@"^\d\w{4}.$"); //For start and end symbols
            Match result = regularEx.Match(input);
            Console.WriteLine(result.Success ? "Yes" : "No");
            Console.ReadKey();
            }
        }
    }
