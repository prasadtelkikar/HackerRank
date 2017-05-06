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
            long maxValue = Int32.MinValue;
            for (int i = 0; i < size; i++)
            {
                long runningScore = 0, score = 0;
                for (int j = i; j < size; j++)
                {
                    score += (runningScore % arr[j]);
                    runningScore += arr[j];
                }
                for (int k = 0; k < i; k++)
                {
                    score += (runningScore % arr[k]);
                    runningScore += arr[k];
                }
                if (maxValue < score)
                    maxValue = score;
            }
            Console.WriteLine(maxValue);
            Console.ReadKey();
        }
    }
}
