//Problem statement: @https://www.hackerrank.com/challenges/drawing-book
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class DrawingBook
    {
        public static void Main(String[] args)
        {
            int startingPage = 1;
            int lastPage = Convert.ToInt32(Console.ReadLine());
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            int turnFromStart = -1, turnFromEnd = 0, rightPage = 0, leftPage = 0, rem = 0;
            //Iterate look from starting
            while (rightPage < pageNumber && leftPage < pageNumber)
            {
                turnFromStart++;
                rightPage = 2 * startingPage - 1;
                leftPage = rightPage - 1;
                startingPage++;
            }
            rightPage = 0;
            leftPage = 0;

            if (lastPage % 2 == 0)
            {
                rem = lastPage / 2;
                leftPage = lastPage; //even Page
                rightPage = leftPage + 1; //Odd Page
            }
            else
            {
                rem = lastPage / 2;
                rightPage = lastPage; //Odd page
                leftPage = rightPage - 1; // even Page
            }
            startingPage = 1;
            //Interate from end
            while (pageNumber < rightPage && pageNumber < leftPage)
            {
                turnFromEnd++;
                rightPage = 2 * rem - 1; //odd page
                leftPage = rightPage - 1;//even page
                rem--;
            }
            //Compare smallest one
            if (turnFromStart > turnFromEnd)
                Console.WriteLine(turnFromEnd);
            else
                Console.WriteLine(turnFromStart);
            Console.ReadKey();
        }
    }
}
