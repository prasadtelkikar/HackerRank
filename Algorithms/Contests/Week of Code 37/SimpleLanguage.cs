using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_37
{
    public class SimpleLanguage
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long result = MaximumProgramValue(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static long MaximumProgramValue(int n)
        {
            BigInteger maxValue = new BigInteger();
            BigInteger x = new BigInteger();
            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine().Split(' ');
                int input = Convert.ToInt32(entry[1]);
                if (entry[0].Equals("set"))
                {
                    x = input;
                }
                else
                {
                    x += input;
                }
                maxValue = BigInteger.Max(maxValue, x);
                x = maxValue;
            }
            return maxValue;
        }
    }
}
