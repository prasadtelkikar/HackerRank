using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample input: 0
 * 6 3
 * 5 1
 * 2 1
 * 1 1
 * 8 1
 * 10 0
 * 5 0
 * Sample output: 0
 * 29
 */
namespace Sorting
{
    /// <summary>
    /// Luck Balance
    /// https://www.hackerrank.com/challenges/luck-balance
    /// </summary>
    class Luck_Balance
    {
        public static void Main(String[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int preliminaryContest = Convert.ToInt32(nk[0]);
            int maxLossCount = Convert.ToInt32(nk[1]);

            List<int> impContest = new List<int>();
            int impContestCount = 0, winCount = 0, total = 0, totalWinLuck = 0;

            for (int i = 0; i < preliminaryContest; i++)
            {
                string[] lr = Console.ReadLine().Split(' ');
                int luck = Convert.ToInt32(lr[0]);
                int result = Convert.ToInt32(lr[1]);
                
                if (result == 1)
                {
                    impContest.Add(luck);
                    impContestCount++;
                }

                total += luck;
            }
            impContest.Sort();

            foreach (int ic in impContest)
            {
                if (winCount < (impContestCount - maxLossCount))
                    totalWinLuck += ic;
                winCount++;
            }

            Console.WriteLine(total - (2 * totalWinLuck));
            Console.ReadLine();
        }
    }
}
