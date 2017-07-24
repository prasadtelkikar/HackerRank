using System;
using System.Collections.Generic;
/*Sample Input 0:
 * 3
 * 10 2 5
 * 12 4 4
 * 6 2 2
 * Sample Output 0:
 * 6
 * 3
 * 5
 */
namespace Implementations
    {
    /// <summary>
    /// https://www.hackerrank.com/challenges/chocolate-feast
    /// Chocolate Feast
    /// </summary>
    public class ChocolateFeast
        {
        public static void Main (string[] args)
            {
            int trips = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>(trips);
            for ( int i = 0; i < trips; i++ )
                {
                string input = Console.ReadLine();
                int result = GetTotalNumberOfChocolate(input);
                results.Add(result);
                }
            foreach ( int result in results )
                {
                Console.WriteLine(result);
                }
            Console.ReadKey();
            }

        private static int GetTotalNumberOfChocolate (string input)
            {
            string[] inputs = input.Split(' ');
            int dollers = Convert.ToInt32(inputs[0]);
            int rateOfChocolate = Convert.ToInt32(inputs[1]);
            int tradeRate = Convert.ToInt32(inputs[2]);

            int result = dollers / rateOfChocolate;
            int wrappers = result;

            while ( wrappers >= tradeRate )
                {
                int newWrappers = wrappers / tradeRate;
                result += newWrappers;
                int remainingChocolate = wrappers % tradeRate;
                wrappers = newWrappers + remainingChocolate;
                }

            /*
             * First failure approach
                do
                 {
                 wrappers = dollers / rateOfChocolate;
                 int remainingChocolate = dollers % rateOfChocolate;
                 dollers = wrappers + remainingChocolate;
                 rateOfChocolate = tradeRate;
                 result += wrappers;
                 } while ( wrappers != 0 && dollers >= tradeRate );*/
            return result;
            }
        }
    }
