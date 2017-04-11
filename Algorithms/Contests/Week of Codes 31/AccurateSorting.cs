using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 2
 * 4
 * 1 0 3 2
 * 3
 * 2 1 0
 * Sample output 0:
 * Yes
 * No
 */
namespace Contests.Week_of_Codes_31
{
    /// <summary>
    /// Need to sort array into ascending order so problem statement did not mentioned arr[i] > arr[i+1] condition
    /// https://www.hackerrank.com/contests/w31/challenges/accurate-sorting
    /// </summary>
    class AccurateSorting
    {
        public static void Main(String[] args)
        {
            int testCount = Convert.ToInt32(Console.ReadLine()); 
            List<int> results = new List<int>();
            for (int i = 0; i < testCount; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine()); 
                String[] arrString = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arrString, Int32.Parse);

                for (int j = 0; j < n -1; j++)
                {
                    if ((Math.Abs(arr[j] - arr[j + 1]) == 1) && arr[i] > arr[i+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                results.Add(CheckForAscending(arr) ? 1 : 0);
            }
            foreach (int result in results)
                Console.WriteLine((result == 1)? "Yes": "No");

            Console.ReadKey();
        }

        //Check array is in ascending order or not
        private static bool CheckForAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }
    }
}
