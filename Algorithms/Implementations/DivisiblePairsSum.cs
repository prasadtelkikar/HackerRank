using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample Input
 * 6 3
 * 1 3 2 6 1 2
 * Sample Output
 * 5
 */
namespace Implementations
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/linkedin-practice-divisible-sum-pairs
    /// </summary>
    class DivisiblePairsSum
    {
        public static void Main()
        {
            string[] tokennk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokennk[0]);
            int k = Convert.ToInt32(tokennk[1]);

            string[] elementsString = Console.ReadLine().Split(' ');
            int[] elements = Array.ConvertAll(elementsString, Int32.Parse);
            int count = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if ((elements[i] + elements[j])%k == 0)
                        count++;

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
