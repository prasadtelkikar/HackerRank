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
        /// Checked combinations of 0-1-0 and 0-0-0 to solve this problem
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
                int[] sequence = Array.ConvertAll(arrSequenceString, Int32.Parse);
                
                int turn = 0;
                turn = findOnes(sequence, size);
                int[] tempArr = removeOnes(sequence, size, turn);
                turn += findZeros(tempArr, tempArr.Length);
                results.Add((turn % 2));
            }

            //result is even means Bob wins otherwise Alice wins
            foreach (int result in results)
                Console.WriteLine((result == 0) ? "Bob" : "Alice");
            Console.ReadKey();
        }

        private static int[] removeOnes(int[] sequence, int size, int turn)
        {
            List<int> tempArr = new List<int>();
            for (int i = 1; i <= (size - 2); i++)
                if (sequence[i - 1] == 0 && sequence[i] == 1 && sequence[i + 1] == 0)
                    sequence[i] = -1;

            for (int i = 0; i < size; i++)
                if (sequence[i] != -1)
                    tempArr.Add(sequence[i]);

            return tempArr.ToArray();

        }

        private static int findOnes(int[] sequence, int size)
        {
            int count = 0;
            for (int i = 1; i <= (size - 2); i++)
                if (sequence[i - 1] == 0 && sequence[i] == 1 && sequence[i + 1] == 0)
                    count++;
            return count;
        }

        private static int findZeros(int[] sequence, int size)
        {
            int count = 0;
            for(int i = 1; i <= (size-2);i++)
                if (sequence[i - 1] == 0 && sequence[i] == 0 && sequence[i + 1] == 0)
                    count++;
            return count;
        }
    }
}
