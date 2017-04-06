using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Incomplete.
namespace Implementations
{
    class NonDivisibleSubset
    {
        public static void Main(String[] args)
        {
            string[] nkString = Console.ReadLine().Split(' ');
            string[] setSString = Console.ReadLine().Split(' ');

            int[] nk = Array.ConvertAll(nkString, Int32.Parse);
            int[] setS = Array.ConvertAll(setSString, Int32.Parse);
            List<int> setOfElements = new List<int>();
            int count = 0;
            for (int i = 0; i < nk[0]; i++)
            {
                int countInner = 0;
                for (int j = 0; j < nk[0]; j++)
                {
                    int result = (setS[i] + setS[j])%nk[1];

                    if (result != 0 && IsSafe(setOfElements, setS[j], nk[1]))
                    {
                        setOfElements.Add(setS[j]);
                        countInner++;
                    }
                }
                count = (countInner > count) ? countInner : count;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

        private static bool IsSafe(List<int> setOfElements, int value, int divisor)
        {
            return setOfElements.All(result => ((result + value)%divisor) != 0);
        }
    }
}
