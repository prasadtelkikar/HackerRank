using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample Input 0:
 * 6
 * 2
 * Sample output 0:
 * 1
 */
/*Sample Input 1:
 * 5
 * 4
 * Sample output 1:
 * 0
 */
namespace Implementations.Cheated
{
    /// <summary>
    /// Drawing Book: Solved after looking into Discussion board. Simplest way to solve this kind of problems
    /// https://www.hackerrank.com/challenges/drawing-book
    /// </summary>
    class DrawingBook
    {
        public static void Main(String[] args)
        {
            int lastPage = Convert.ToInt32(Console.ReadLine());
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            int pageTurnCount = GetMinPageTurns(lastPage, pageNumber);
            Console.WriteLine(pageTurnCount);
        }

        private static int GetMinPageTurns(int lastPage, int pageNumber)
        {
            int pageTurnCountFromStart = (int)Math.Floor(pageNumber/2.0);
            int pageTurnCountFromLast = (int) Math.Floor((lastPage - pageNumber)/2.0);
            return Math.Min(pageTurnCountFromStart, pageTurnCountFromLast);
        }
    }
}
