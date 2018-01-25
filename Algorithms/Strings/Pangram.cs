using System;
using System.Collections.Generic;

namespace Strings
{
    class Pangram
    {
        public static void Main(string[] args)
        {
            bool result = IsPangram();
            Console.WriteLine(result ? "pangram" : "not pangram");
            Console.ReadKey();
        }

        private static bool IsPangram()
        {
            string aToz = "abcdefghijklmnopqrstuvwxyz ";
            Dictionary<char, bool> dict = new Dictionary<char, bool>();

            foreach (char item in aToz)
                dict.Add(item, false);

            string input = Console.ReadLine().ToLower() ;

            foreach (char item in input)
            {
                if (!dict[item])
                    dict[item] = true;
            }

            foreach (var item in dict.Keys)
            {
                if (!dict[item])
                    return false;
            }

            return true;
        }
    }
}
