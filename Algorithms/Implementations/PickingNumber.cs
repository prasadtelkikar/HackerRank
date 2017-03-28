using System;
using System.Collections.Generic;
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
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int mid = (int)Math.Floor((decimal)size/2);
            Array.Sort(values);
            foreach (int i in values)
            {
                Console.Write("\t"+i);
            }

            int leftCount = GetLeftCount(values, mid);
            int rightCount = GetRightCount(values, mid);

            Console.WriteLine(leftCount+rightCount);

            Console.ReadKey();
        }

        private static int GetRightCount(int[] values, int mid)
        {
            int count = 0;
            for (int i = 0; i < mid; i++)
            {
                int absDiff = Math.Abs(values[mid] - values[i]);
                if (absDiff <= 1)
                    count++;
            }
            return count;
        }

        private static int GetLeftCount(int[] values, int mid)
        {
            int count = 0;
            for (int i = mid + 1; i < values.Length; i++)
            {
                int absDiff = Math.Abs(values[mid] - values[i]);
                if (absDiff <= 1)
                    count++;
            }
            return count;
        }
    }
}
