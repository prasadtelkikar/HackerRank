using System;
/* Sample input 0:
 * 2
 * 1
 * 2
 * Sample output 0:
 * 2
 * 3
 */
namespace Implementations
{
    /// <summary>
    /// Maximum draws
    /// https://www.hackerrank.com/challenges/maximum-draws
    /// </summary>
    class MaximumDraws
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = (Convert.ToInt32(Console.ReadLine()) + 1);

            for (int i = 0; i < size; i++)
                Console.WriteLine(arr[i]);

            Console.ReadLine();
        }
    }
}
