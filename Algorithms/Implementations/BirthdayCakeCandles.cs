using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample Input 0:
 * 4
 * 3 2 1 3
 * Sample output 0:
 * 2
 */
namespace Implementations
{
    /// <summary>
    /// Birthday cake candles: Here we need to count candles with max height. Used Lambda expression.
    /// https://www.hackerrank.com/challenges/birthday-cake-candles
    /// </summary>
    class BirthdayCakeCandles
    {
        public static void Main(String[] args)
        {
            int numberOfCandles = Convert.ToInt32(Console.ReadLine());
            string[] candlesString = Console.ReadLine().Split(' ');
            int[] candles = Array.ConvertAll(candlesString, Int32.Parse);

            Array.Sort(candles);
            int maxHeight = candles[numberOfCandles - 1];

            int count = candles.Count(candle => maxHeight == candle);

            Console.WriteLine(count);
            Console.ReadKey();

        }
    }
}
