using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 5
 * 1 2 1 3 2 
 * 3 2
 * Sample output 0:
 * 2
 * Sample input 1:
 * 6
 * 1 1 1 1 1 1
 * 3 2
 * Sample output 1:
 * 0
 * Sample input 2:
 * 1
 * 4
 * 4 1
 * Sample output 2:
 * 1
 */
namespace Implementations
{
    /// <summary>
    /// Time complexity < O(n^2). Checked sum of elements with expected sum.
    /// https://www.hackerrank.com/challenges/the-birthday-bar
    /// </summary>
    class BirthdayChocolate
    {
        public static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            String[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            String[] md = Console.ReadLine().Split(' ');
            int expectedSum = Convert.ToInt32(md[0]);
            int numBites = Convert.ToInt32(md[1]);
            int count = 0;
            for (int i = 0; i <= size - numBites; i++)
            {
                int sum = 0;
                sum += arr[i];
                for (int j = i+1; j < i + numBites; j++)
                    sum += arr[j];
                if (sum == expectedSum)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
