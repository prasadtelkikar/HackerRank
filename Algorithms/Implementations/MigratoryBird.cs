using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 6
 * 1 4 4 4 5 3
 * Sample output 0:
 * 4
 */
namespace Implementations
{
    class MigratoryBird
    {
        /// <summary>
        /// Migratory bird problem
        /// https://www.hackerrank.com/challenges/migratory-birds
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] birdTypeTemp = Console.ReadLine().Split(' ');
            int[] birdTypes = Array.ConvertAll(birdTypeTemp, Int32.Parse);
            int maxValue = 0, birdType = 0;

            Dictionary<int, int> birdCount = new Dictionary<int, int>();    // to avoid switch condition
            birdCount.Add(1,0);
            birdCount.Add(2,0);
            birdCount.Add(3, 0);
            birdCount.Add(4, 0);
            birdCount.Add(5, 0);

            for (int i = 0; i < n; i++)
                birdCount[birdTypes[i]]++;

            foreach (KeyValuePair<int, int> types in birdCount)
            {
                if (maxValue < types.Value)         //Calculate max
                {
                    maxValue = types.Value;
                    birdType = types.Key;
                }   
            }
            Console.WriteLine(birdType);
        }
    }
}
