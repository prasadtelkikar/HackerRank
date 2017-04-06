using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample input 0:
 * 6
 * 4 6 5 3 3 1
 * Sample output 0:
 * 3
 * Sample input 1:
 * 6
 * 1 2 2 3 1 2
 * Sample output 1:
 * 5
 */
namespace Implementations
{
    /// <summary>
    /// Picking numbers: Used absolute function from Math class and LINQ expression.
    /// https://www.hackerrank.com/challenges/picking-numbers
    /// </summary>
    class PickingNumber
    {
        public static void Main(string[] arg)
        {
             int size = Convert.ToInt32(Console.ReadLine());
            string[] integerArray_temp = Console.ReadLine().Split(' ');
            int[] integerArray = Array.ConvertAll(integerArray_temp, Int32.Parse);
            int count = 0;

            /* For input containing large number of values
            
             string[] intputs = File.ReadAllLines(Directory.GetCurrentDirectory()+ @"\PickingNumbers.txt");
             int size = Convert.ToInt32(intputs[0]);
             String[] integerArray_temp = intputs[1].Split(' ');
             int[] integerArray = Array.ConvertAll(integerArray_temp, Int32.Parse);
             int count = 0;
            
            */

            Array.Sort(integerArray);
            for (int i = 0; i < size; i++)
            {
                int countInner = 0;
                List<int> minDiffList = new List<int>();
                for (int j = 0; j < size; j++)
                {
                    if (Math.Abs(integerArray[i] - integerArray[j]) <= 1 && IsSafe(minDiffList, integerArray[j]))
                    {
                        minDiffList.Add(integerArray[j]);
                        countInner++;
                    }
                }
                count = (count > countInner) ? count : countInner;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }

        private static bool IsSafe(List<int> integerArray, int value)
        {
            return integerArray.All(absSum => Math.Abs(absSum - value) <= 1);
        }
    }
}
