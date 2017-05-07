using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.RookieRank_3
{
    class MaxScore
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arrString = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arrString, Int64.Parse);

            Array.Sort(arr);
            long maxValue = -1;
            int middle = (size) / 2;
            long runningScore = 0;
            long score = 0;
            int[] visisted = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (runningScore == 0)
                {
                    score += (runningScore%arr[0]);
                    runningScore += arr[0];
                    visisted[0] = 1;
                }
                else
                {
                    if (arr[i] > runningScore && visisted[i] == 0)
                    {
                        score += (runningScore%arr[i]);
                        runningScore += arr[i];
                        visisted[i] = 1;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (visisted[i] == 0)
                {
                    score += (runningScore%arr[i]);
                    runningScore += arr[i];
                    visisted[i] = 1;
                } 
            }
            Console.WriteLine(score);
            Console.ReadKey();
        }
    }
}
