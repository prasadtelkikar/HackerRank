using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 3 2 3 
 *1 2 3
 *0
 *1
 *2
 * Sample output
 * 2
 * 3
 * 1
 */
namespace Implementations
{
    /// <summary>
    /// Circular array rotation
    /// https://www.hackerrank.com/challenges/circular-array-rotation
    /// Hint: http://www.slightedgecoder.com/2017/01/13/solving-hackerrank-problem-modulo-array-rotation/#more-137
    /// </summary>
    class CircularArrayRotation
    {
        public static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] values = Array.ConvertAll(arrayString, Int32.Parse);

            int[] result = values;
            result = GetRightShift(result, k);

            for (int i = 0; i < q; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(result[m]);
            }
            Console.ReadKey();
        }
        public static int[] GetRightShift(int[] a, int k)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[((i + k) % result.Length)] = a[i];
            }
            return result;
        }
    }
}
