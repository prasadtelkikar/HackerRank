/*Thank you Sung Kim for your help @http://www.slightedgecoder.com/ */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample Input 0:
 * aba
 * 10
 * 
 * Sample output 0:
 * 7
 */
/*
 * Sample Input 1:
 * a
 * 1000000000000
 * 
 * Sample output 1:
 * 1000000000000
 */
namespace BreakingTheRecords
{
    /// <summary>
    /// Repeated string
    /// https://www.hackerrank.com/challenges/repeated-string
    /// </summary>
    class RepeatedString
    {
        public static void Main(string[] args)
        {

            long remainder = 0, numberOfa = 0, quotient = 0, remainderCount = 0;
            string infiniteString = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            remainder = n % infiniteString.Length;
            quotient = n / infiniteString.Length;

            foreach(char ch in infiniteString)
            {
                if (ch == 'a')
                    numberOfa++;
            }

            for (int i = 0; i < remainder; i++)
            {
                if (infiniteString[i] == 'a')
                    remainderCount++;
            }

            Console.WriteLine(((quotient * numberOfa) + remainderCount));
            Console.ReadKey();
        }
    }
}
