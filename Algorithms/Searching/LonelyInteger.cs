using System;
/* Sample input 0:
 * 1
 * 1
 * Sample output 0:
 * 1
 * Sample input 1:
 * 3
 * 1 1 2
 * Sample output 1:
 * 2
 * Sample input 2:
 * 5
 * 0 0 1 2 1
 * Sample output 2:
 * 2
 * Sample input 3:
 * 9
 * 4 9 95 93 57 4 57 93 9
 * Sample output 3:
 * 95
 */
namespace Searching
    {
    /// <summary>
    /// Lonely Integer
    /// https://www.hackerrank.com/challenges/lonely-integer
    /// </summary>
    public class LonelyInteger
        {
        public static void Main (string[] args)
            {
            int limit = Convert.ToInt32(Console.ReadLine());
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(stringArr, int.Parse);
            int[] resultCount = new int[101];
            int result = 0;
            for ( int i = 0; i < limit; i++ )
                resultCount[arr[i]]++;

            for ( int i = 0; i < limit; i++ )
                if ( resultCount[arr[i]] == 1 )
                    {
                    result = arr[i];
                    break;
                    }
            Console.WriteLine(result);
            Console.ReadKey();
            }
        }
    }
