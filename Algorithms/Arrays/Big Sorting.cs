using System;
using System.Collections.Generic;
/*Sample Input 0:
 * 6
 * 31415926535897932384626433832795
 * 1
 * 3
 * 10
 * 3
 * 5
 * Sample Output 0:
 * 1
 * 3
 * 3
 * 5
 * 10
 * 31415926535897932384626433832795
 */
namespace Sorting
{
    /// <summary>
    /// Big sorting
    /// https://www.hackerrank.com/challenges/big-sorting
    /// Thanks: Sung kim (dance2 die) Lakshmikant deshpande (lakshmikantd)
    /// </summary>
    public class BigIntegerCustomCompare : IComparer<string>
    {
        public int Compare(string x, string y)
            {
            if ( x.Length > y.Length )
                return 1;
            else if ( x.Length < y.Length )
                return -1;
            else
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (Convert.ToInt32(x[i]) > Convert.ToInt32(y[i]))
                            return 1;
                        if (Convert.ToInt32(x[i]) < Convert.ToInt32(y[i]))
                            return -1;
                    }
                }
            return 0;
        }
    }

    class Big_Sorting
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arrString = new string[size];

            for ( int i = 0; i < size; i++ )
            {
                arrString[i] = Console.ReadLine();
            }
            Array.Sort(arrString, new BigIntegerCustomCompare());
            foreach (string value in arrString)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
