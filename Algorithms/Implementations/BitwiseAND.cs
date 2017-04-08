using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 3
 * 5 2
 * 8 5
 * 2 2
 * Sample output 0:
 * 1
 * 4
 * 0
 */
namespace Implementations
{
    /// <summary>
    /// Use of Bitwise AND (&) operator. I guess we can solve it with less time complexity, will try it
    /// https://www.hackerrank.com/challenges/linkedin-practice-bitwise-and
    /// </summary>
    class BitwiseAND
    {
        public static void Main(String[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            int[] outputs = new int[testCases];
            int index = 0;
            while (testCases > 0)
            {
                string[] inputString = Console.ReadLine().Split(' ');
                int[] inputs = Array.ConvertAll(inputString, Int32.Parse);
                outputs[index] = GetBitwiseAnd(inputs);
                index++;
                testCases --;
            }
            foreach (int output in outputs)
            {
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }

        private static int GetBitwiseAnd(int[] inputs)
        {
            int max = 0;
            for (int i = 1; i <= inputs[0]; i++)
            {
                for (int j = i + 1; j <= inputs[0]; j++)
                {
                    int result = (i & j);
                    if (result < inputs[1] && max < result)
                        max = result;
                }
            }
            return max;
        }
    }
}
