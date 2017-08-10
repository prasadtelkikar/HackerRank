using System;
using System.Collections.Generic;
using System.Text;
/* Sample input 0:
 * 2
 * 3 
 * 1
 * 2
 * 4
 * 10
 * 100
 * Sample output 0:
 * 2 3 4 
 * 30 120 210 300
 */
namespace Implementations
    {
    /// <summary>
    /// Manasa and stones
    /// https://www.hackerrank.com/challenges/manasa-and-stones
    /// </summary>
    public class ManasaAndStones
        {
        public static void Main (string[] args)
            {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for ( int i = 0; i < testCases; i++ )
                {
                int length = Convert.ToInt32(Console.ReadLine());
                int startPoint = Convert.ToInt32(Console.ReadLine());
                int endPoint = Convert.ToInt32(Console.ReadLine());
                string output = "";
                if ( startPoint < endPoint )
                    output = GetFinalList(length - 1, startPoint, endPoint);
                else
                    output = GetFinalList(length - 1, endPoint, startPoint);

                results.Add(output);
                }
            foreach ( string item in results )
                {
                Console.WriteLine(item);
                }
            Console.ReadKey();
            }

        private static string GetFinalList (int length, int startPoint, int endPoint)
            {
            StringBuilder sb = new StringBuilder();
            int lowerBound = startPoint * (length);
            int upperBound = endPoint * (length);
            sb.Append(lowerBound + " ");
            int diff = (upperBound - lowerBound) / (length);
            int temp = lowerBound;
            while ( lowerBound <= upperBound )
                {
                temp += diff;
                sb.Append(temp + " ");
                lowerBound = temp;
                }
            return sb.ToString();
            }
        }
    }
