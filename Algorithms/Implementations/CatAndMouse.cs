using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample Input 0:
 * 3
 * 1 2 3
 * 1 3 2
 * 2 1 3
 * Sample Output 0:
 * Cat B
 * Mouse C
 * Cat A
 */

namespace Implementations
{
    /// <summary>
    /// Cats and a mouse
    /// https://www.hackerrank.com/challenges/cats-and-a-mouse
    /// </summary>
    class CatAndMouse
    {
        public static void Main(String[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();

            for (int i = 0; i < testCase; i++)
            {
                String[] values = Console.ReadLine().Split(' ');
                int catA = Convert.ToInt32(values[0]);
                int catB = Convert.ToInt32(values[1]);
                int mouseC = Convert.ToInt32(values[2]);

                int distCatAToMouseC = Math.Abs(mouseC - catA);
                int distCatBToMouseC = Math.Abs(mouseC - catB);

                if (distCatAToMouseC > distCatBToMouseC)
                    results.Add("Cat B");
                else if (distCatAToMouseC == distCatBToMouseC)
                    results.Add("Mouse C");
                else
                    results.Add("Cat A");
            }

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
