using System;
/* Sample input 0:
 * hackerhappy
 * hackerrank
 * 9
 * Sample output 0:
 * Yes
 * 
 * Sample input 1:
 * aba
 * aba
 * 7
 * Sample output 1:
 * Yes
 * 
 * Test case input 3:
 * zzzz
 * zzzzzz
 * 4
 * Test case output 3:
 * Yes
 * 
 * Test case input 7:
 * y
 * yo
 * Test case output 7:
 * No
 */
namespace Implementations
    {
    /// <summary>
    /// Append and delete
    /// https://www.hackerrank.com/challenges/append-and-delete/problem
    /// </summary>
    public class AppendAndDelete
        {
        public static void Main (string[] args)
            {
            string initialString = Console.ReadLine();
            string desireString = Console.ReadLine();
            int desireOperation = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int smallerString = (initialString.Length < desireString.Length)
                ? initialString.Length
                : desireString.Length;
            for ( int i = 0; i < smallerString; i++ )
                {
                if ( initialString[i] != desireString[i] )
                    break;
                count++;
                }

            string endInitialString = initialString.Substring(count);
            string endDesireString = desireString.Substring(count);

            Console.WriteLine( (endDesireString.Length % 2 == 0 || endInitialString.Length >= endDesireString.Length) && (endInitialString.Length + endDesireString.Length <= desireOperation) ? "Yes" : "No");
            Console.ReadKey();
            }
        }
    }
