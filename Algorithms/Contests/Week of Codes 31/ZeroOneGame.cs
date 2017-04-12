using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 3
 * 4
 * 1 0 0 1
 * 5
 * 1 0 1 0 1
 * 6
 * 0 0 0 0 0 0
 * 
 * Sample output 0:
 * Bob
 * Alice
 * Bob
 */
namespace Contests.Week_of_Codes_31
{
    class ZeroOneGame
    {
        /// <summary>
        /// Interesting problem: one 0 to n -1 for loop and one n-1 to 0 for loop solved this problem
        /// https://www.hackerrank.com/contests/w31/challenges/zero-one-game
        /// </summary>
        public static void Main(String[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                string[] arrSequenceString = Console.ReadLine().Split(' ');
                IList<int> sequence = Array.ConvertAll(arrSequenceString, Int32.Parse).ToList();

                int turn = 0;
                for (int j = 0; j < sequence.Count; j++)
                {
                    if ((j == 0 || j == sequence.Count - 1))
                        continue;

                    if (sequence[j - 1] == 0 && sequence[j + 1] == 0)
                    {
                        sequence.RemoveAt(j);
                        turn++;
                    }
                }
                for (int j = sequence.Count - 1; j >= 0; j--)
                {
                    if ((j == 0 || j == sequence.Count - 1))
                        continue;

                    if (sequence[j - 1] == 0 && sequence[j + 1] == 0)
                    {
                        sequence.RemoveAt(j);
                        turn++;
                    }
                }
                results.Add((turn % 2));
            }

            //result is even means Bob wins otherwise Alice wins
            foreach (int result in results)
                Console.WriteLine((result == 0) ? "Bob" : "Alice");
            Console.ReadKey();
        }
    }
}
