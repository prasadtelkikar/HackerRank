using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class TwoStrings
    {
        public static void Main(string[] args)
        {
            int nTestCases = int.Parse(Console.ReadLine());
            List<string> results = new List<string>();

            for (int i = 0; i < nTestCases; i++)
            {
                var s1 = Console.ReadLine().ToCharArray();
                var s2 = Console.ReadLine().ToCharArray();
                results.Add(TwoStringsComparison(s1,s2));
            }

            foreach (var result in results)
                Console.WriteLine(result);

            Console.ReadKey();
        }


        //Passed all test. Looked into discussion board
        private static string TwoStringsComparison(char[] s1, char[] s2)
        {
            foreach (var alphabet in "abcdefghijklmnopqrstuvwxyz".ToCharArray())
                if (s1.Contains(alphabet) && s2.Contains(alphabet))
                    return "YES";

            return "NO";
        }

        //My attempt : Fancy solution but failed with status Terminated due to timeout
        private static string TwoStringComparisonMyAttempt(char[] s1, char[] s2)
        {
            return (s1.Any(x => s2.Contains(x)) ? "YES" : "NO");
        }
    }
}
