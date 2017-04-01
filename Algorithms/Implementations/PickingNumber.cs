using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class PickingNumber
    {
        public static void Main(string[] arg)
        {
             int size = Convert.ToInt32(Console.ReadLine());
            string[] integerArray_temp = Console.ReadLine().Split(' ');
            int[] integerArray = Array.ConvertAll(integerArray_temp, Int32.Parse);
            int count = 0;

            /* For input containing large number of values
            
             string[] intputs = File.ReadAllLines(Directory.GetCurrentDirectory()+ @"\PickingNumbers.txt");
             int size = Convert.ToInt32(intputs[0]);
             String[] integerArray_temp = intputs[1].Split(' ');
             int[] integerArray = Array.ConvertAll(integerArray_temp, Int32.Parse);
             int count = 0;
            
            */

            Array.Sort(integerArray);
            for (int i = 0; i < size; i++)
            {
                int countInner = 0;
                List<int> minDiffList = new List<int>();
                for (int j = 0; j < size; j++)
                {
                    if (Math.Abs(integerArray[i] - integerArray[j]) <= 1 && IsSafe(minDiffList, integerArray[j]))
                    {
                        minDiffList.Add(integerArray[j]);
                        countInner++;
                    }
                }
                count = (count > countInner) ? count : countInner;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }

        private static bool IsSafe(List<int> integerArray, int value)
        {
            return integerArray.All(absSum => Math.Abs(absSum - value) <= 1);
        }
    }
}
