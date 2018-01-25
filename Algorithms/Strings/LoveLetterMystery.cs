using System;
using System.Collections.Generic;

namespace Strings
{
    class LoveLetterMystery
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> resultList = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                int result = 0;
                result = GetResult(input, (input.Length / 2));

                resultList.Add(result);
            }

            foreach (int item in resultList)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        public static int GetResult(string input, int midIndex)
        {
            int result = 0;
            string firstString = input.Substring(0, midIndex);
            string secondString = input.Substring(midIndex);
            string reverseString = "";
            int len = secondString.Length - 1;

            while (len >= 0)
            {
                reverseString = reverseString + secondString[len];
                len--;
            }

            for (int j = 0; j < firstString.Length; j++)
                result += firstString[j] > reverseString[j] ? Convert.ToInt32(firstString[j] - reverseString[j]) : Convert.ToInt32(reverseString[j] - firstString[j]);
            return result;
        }
    }
}
