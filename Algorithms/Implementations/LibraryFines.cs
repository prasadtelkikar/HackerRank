using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample Input 0:
 * 9 6 2015
 * 6 6 2015
 * Sample output 0:
 * 45
 */
namespace Implementations
{
    /// <summary>
    /// Library fines: Used date class to perform date operations.
    /// https://www.hackerrank.com/challenges/library-fine
    /// </summary>
    class LibraryFines
    {
        public static void Main(string[] args)
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int actualD = Convert.ToInt32(tokens_d1[0]);
            int actualM = Convert.ToInt32(tokens_d1[1]);
            int actualY = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int expectedD = Convert.ToInt32(tokens_d2[0]);
            int expectedM = Convert.ToInt32(tokens_d2[1]);
            int expectedY = Convert.ToInt32(tokens_d2[2]);

            DateTime actualDate = new DateTime(actualY, actualM, actualD);
            DateTime expectedDate = new DateTime(expectedY, expectedM, expectedD);

            double d = (actualDate - expectedDate).Days;

            if (d <= 0)
                Console.WriteLine("0");
            else if( d > 0 && expectedM == actualM && expectedY == actualY)
                Console.WriteLine(15*d);
            else if(d > 0 && expectedM != actualM && expectedY == actualY)
                Console.WriteLine(500*(actualM - expectedM));
            else
                Console.WriteLine("10000");
            
            Console.ReadKey();
        }
    }
}
