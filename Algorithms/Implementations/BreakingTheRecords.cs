/*Thank you Sung Kim for your help @http://www.slightedgecoder.com/ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    /*Sample Input 1:
     * 9
     * 10 5 20 20 4 5 2 25 1
     *
     *Sample output 1:
     * 2 4
     */

    /*Sample Input 1:
     * 10
     * 3 4 21 36 10 28 35 5 24 42
     * 
     *Sample output 1:
     * 4 0
     */

    class BreakingTheRecords
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] score_temp = Console.ReadLine().Split(' ');
            int[] score = Array.ConvertAll(score_temp, Int32.Parse);
            int highestRecordBreakCount = 0, worstRecordBreakCount = 0;
            int hightestRecord = score[0];
            int worstRecord = score[0];
            for (int i = 1; i < n; i++)
            {
                if (hightestRecord < score[i])
                {
                    hightestRecord = score[i];
                    highestRecordBreakCount++;
                }
                if (worstRecord > score[i])
                {
                    worstRecord = score[i];
                    worstRecordBreakCount++;
                }
            }
            Console.WriteLine(highestRecordBreakCount+" "+worstRecordBreakCount);
            Console.ReadKey();
        }
    }
}
