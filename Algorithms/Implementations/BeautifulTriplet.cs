using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 7 3
 * 1 2 4 5 7 8 10
 * Sample output 0:
 * 3
 */
namespace Implementations
{
    /// <summary>
    /// Wrote program with O(n^3) complexity. Will try to reduce it's time complexity.
    /// https://www.hackerrank.com/challenges/beautiful-triplets
    /// </summary>
    class BeautifulTriplet
    {
        public static void Main(String[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');
            int size = Convert.ToInt32(nd[0]);
            int diff = Convert.ToInt32(nd[1]);
            String[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if ((arr[j] - arr[i]) == diff)
                    {
                        for (int k = j + 1; k < size; k++)
                        {
                            if ((arr[k] - arr[j]) == diff)
                            {
                                count++;
                                //Console.WriteLine(arr[i] + " , " + arr[j] + " , " + arr[k]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
