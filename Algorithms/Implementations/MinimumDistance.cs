using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input:
 * 6
 * 7 1 3 4 1 7
 * Sample output:
 * 3
 * Sample intput 1:
 * 5
 * 1 2 3 4 10
 * Sample output 1:
 * -1
 */
namespace Implementations
{
    /// <summary>
    /// Can we reduce its's time complexity from O(n^2) to O(n)
    /// https://www.hackerrank.com/challenges/minimum-distances
    /// </summary>
    class MinimumDistance
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i != j && arr[i] == arr[j])
                        min = (min > Math.Abs(i - j)) ? Math.Abs(i - j) : min;

            if (min == Int32.MaxValue)
                min = -1;

            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
