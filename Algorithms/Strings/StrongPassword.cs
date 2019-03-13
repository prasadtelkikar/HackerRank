using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    public class StrongPassword
    {
        public static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            var watch = Stopwatch.StartNew();
            int answer = MinimumNumber(n, input);
            watch.Stop();
            Console.WriteLine("Execution Time : " + watch.Elapsed.TotalSeconds);

            Console.WriteLine(answer);
            Console.ReadKey();
        }

        //Fastest solution suggested by teammate : Thanks harikrishna_kada 
        private static int MinimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            int result = 0;
            int min = 6;
            var lowercase = Regex.Matches(password, @"[a-z]").Count;
            var upppercase = Regex.Matches(password, @"[A-Z]").Count;
            var num = Regex.Matches(password, @"[0-9]").Count;
            var sp = Regex.Matches(password, @"[!@#$%^&*()-+]").Count;

            int[] intArray2 = new int[4] { lowercase, upppercase, num, sp };
            var total = password.Length;

            if (total < n)
                result = Math.Abs(min - total);
            else
                foreach (int item in intArray2)
                    if (item == 0)
                        result++;

            return result;
        }
        //My solutions.
        private static int MinimumNumberMine(int n, string password)
        {
            // Return the minimum number of characters to make the password strong

            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            int answer = 0;

            if (!(password.Any(x => numbers.Contains(x))))
                answer++;
            if (!(password.Any(x => lower_case.Contains(x))))
                answer++;
            if (!(password.Any(x => upper_case.Contains(x))))
                answer++;
            if (!(password.Any(x => special_characters.Contains(x))))
                answer++;

            return (Math.Max((6 - n), answer));

        }

    }
}
