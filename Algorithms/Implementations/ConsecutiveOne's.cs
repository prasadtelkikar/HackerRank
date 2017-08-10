using System;
/*Sample input 0:
 * 5
 * Sample output 0:
 * 1
 * Sample input 1:
 * 13
 * Sample output 1:
 * 2
 */
namespace Implementations
    {
    /// <summary>
    /// Consecutive 1's in binary numbers
    /// https://www.hackerrank.com/challenges/linkedin-practice-binary-numbers
    /// </summary>
    public class ConsecutiveOne_s
        {
        public static void Main (string[] args)
            {
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            string binaryNumber = Convert.ToString(decimalNumber, 2);
            int previous = 0;
            int max = int.MinValue;
            for ( int i = binaryNumber.IndexOf('0'); i > -1 && i <= binaryNumber.Length; i = binaryNumber.IndexOf('0', i + 1) )
                {
                int count = i - previous;
                if ( max < count )
                    max = count;
                previous = i;
                previous++;
                }

            int temp = binaryNumber.Length - previous;
            if ( temp > max )
                max = temp;

            Console.WriteLine(max);
            Console.ReadKey();
            }
        }
    }
