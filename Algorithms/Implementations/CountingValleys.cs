using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 8
 * UDDDUDUU
 * Sample output 0:
 * 1
 * Sample intput 1:
 * 12
 * DDUUDDUDUUUD
 * Sample output 1:
 * 2
 */
namespace Implementations
{
    /// <summary>
    /// Consider sea level = 0 and do increment and decrement the count and valley completes when count = 0 and laststep = 'U'
    /// https://www.hackerrank.com/challenges/counting-valleys
    /// </summary>
    class CountingValleys
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string steps = Console.ReadLine();

            int count = 0, max = 0;

            foreach (char step in steps)
            {
                if (step == 'D')
                    count--;
                if (step == 'U')
                    count++;
                if (count == 0 && step == 'U')
                    max++;
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
