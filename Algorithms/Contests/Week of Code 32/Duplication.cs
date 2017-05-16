using System;
using System.Text;
/* Sample Input:
 * 3
 * 2
 * 5
 * 7
 * Sample output:
 * 1
 * 0
 * 1
 */
namespace Contests.Week_of_Code_32
{
    /// <summary>
    /// Duplication
    ///https://www.hackerrank.com/contests/w32/challenges/duplication
    /// </summary>
    public class Duplication
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arrValues = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrValues[i] = Convert.ToInt32(Console.ReadLine());
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("0");
            while (sb.Length <= 1000)
            {
                foreach (char digit in sb.ToString())
                    sb.Append(digit == '1' ? '0' : '1');
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(sb[arrValues[i]]);
            }
            Console.ReadKey();
        }
    }
}