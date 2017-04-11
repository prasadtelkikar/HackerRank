using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample inputs 0:
 * 8 5
 * 2 3 1 2 3 2 3 3
 * 0 3
 * 4 6
 * 6 7
 * 3 5
 * 0 7
 * Sample output 0:
 * 1
 * 2
 * 3
 * 2
 * 1
  */
namespace Implementations
{
    /// <summary>
    /// Used StringBuilder to read all test cases
    /// https://www.hackerrank.com/challenges/service-lane
    /// </summary>
    class ServiceLane
    {
        public static void Main(String[] args)
        {
            String[] ntString = Console.ReadLine().Split(' ');
            int[] nt = Array.ConvertAll(ntString, Int32.Parse);

            String[] widthString = Console.ReadLine().Split(' ');
            int[] width = Array.ConvertAll(widthString, Int32.Parse);

            StringBuilder segmentsSB = new StringBuilder();

            for (int i = 0; i < nt[1]; i++)
                segmentsSB.Append(Console.ReadLine()).Append(';');

            String[] segments = segmentsSB.ToString().Split(';');
            for (int i = 0; i < nt[1]; i++)
            {
                String[] limits = segments[i].Split(' ');
                int startPoint = Convert.ToInt32(limits[0]);
                int endPoint = Convert.ToInt32(limits[1]);
                int min = Int32.MaxValue;

                for (int j =  startPoint; j <= endPoint; j++)
                    if (width[j] < min)
                        min = width[j];

                Console.WriteLine(min);
            }
            Console.ReadKey();
        }
    }
}
