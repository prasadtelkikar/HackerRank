using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class AbsoluteDifference
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            int minValue = Int32.MaxValue;
            Array.Sort(arr);
            for (int i = 0; i < size - 1; i++)
            {
                int result = Math.Abs(arr[i] - arr[i + 1]);
                if (minValue > result)
                    minValue = result;
            }
            Console.WriteLine(minValue);
            Console.ReadKey();
        }
    }
}
