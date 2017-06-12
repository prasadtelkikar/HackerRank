using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_code_33
{
    public class TwinArrays
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr1String = Console.ReadLine().Split(' ');
            int[] arr1 = Array.ConvertAll(arr1String, Int32.Parse);
            string[] arr2String = Console.ReadLine().Split(' ');
            int[] arr2 = Array.ConvertAll(arr2String, Int32.Parse);
            int result = twinArrays(arr1, arr2, size);
            
            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int twinArrays(int[] ar1, int[] ar2, int length)
        {
            int leastSum = ar1.Min() + ar2.Min();
            int max = Int32.MaxValue;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i != j)
                    {
                        int sum = ar1[i] + ar2[j];
                        if (leastSum == sum)
                            return leastSum;
                        if (max > sum)
                            max = sum;
                    }
                }
            }

            return max;
        }
    }
}
