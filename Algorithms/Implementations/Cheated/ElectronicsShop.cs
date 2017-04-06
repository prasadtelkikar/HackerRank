using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Sample Input 0:
 * 10 2 3
 * 3 1
 * 5 2 8
 * Sample output 0:
 * 9
 */
/*Sample Input 1:
 * 5 1 1 
 * 4
 * 5
 * Sample output 1:
 * -1
 */
namespace Implementations
{
    /// <summary>
    /// Electronics Shop: Few test cases were failing, so Checked discussion tab.
    ///https://www.hackerrank.com/challenges/electronics-shop
    /// </summary>
    class ElectronicsShop
    {
        public static void Main(String[] args)
        {
            /**/
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] pendrives_temp = Console.ReadLine().Split(' ');
            int[] pendrives = Array.ConvertAll(pendrives_temp, Int32.Parse);

            /* For input containing large number of values

            string[] inputs = File.ReadAllLines(Directory.GetCurrentDirectory()+ @"\ElectronicsShop.txt");
             string[] tokens_s = inputs[0].Split(' ');
             int s = Convert.ToInt32(tokens_s[0]);
             int n = Convert.ToInt32(tokens_s[1]);
             int m = Convert.ToInt32(tokens_s[2]);
             
             string[] keyboards_temp = inputs[1].Split(' ');
             int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
             string[] pendrives_temp = inputs[2].Split(' ');
             int[] pendrives = Array.ConvertAll(pendrives_temp, Int32.Parse);
            */


            Array.Sort(keyboards);
            Array.Sort(pendrives);

            int lastKeyboard = keyboards.Length - 1;
            int lastPendrive = pendrives.Length - 1;

            int finalRate = 0;
            if (keyboards[lastKeyboard] > pendrives[lastPendrive])
                finalRate = GetMaximumBill(keyboards, pendrives, lastKeyboard, lastPendrive, s);
            else
                finalRate = GetMaximumBill(pendrives, keyboards, lastPendrive, lastKeyboard, s);

            Console.WriteLine(finalRate);

            Console.ReadKey();
        }

        private static int GetMaximumBill(int[] keyboards, int[] pendrives, int maxAmount, int minAmount, int pocketMoney)
        {
            int result = -1;
            for (int i = maxAmount; i >= 0; i--)
            {
                for (int j = minAmount; j >= 0; j--)
                {
                    int max = keyboards[i] + pendrives[j];
                    if (max <= pocketMoney && result < max)
                        result = max;
                }
            }
            return result;
        }
    }
}
