using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * 5
 * 4 5 3 7 2
 * Sample output 0:
 * 3 2 4 5 7
 */
namespace Sorting
{
    /// <summary>
    /// Quick sort partition: Solved as per description
    /// https://www.hackerrank.com/challenges/quicksort1
    /// </summary>
    class Quicksort_1_Partition
    {
        public static void Main(String[] args)
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            Partition(_ar);
            Console.ReadKey();
        }

        private static void Partition(int[] ar)
        {
            int p = ar[0];
            List<int> arrLeft = new List<int>();
            List<int> arrRight = new List<int>();
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < p)
                    arrLeft.Add(ar[i]);
                else if (ar[i] > p)
                    arrRight.Add(ar[i]);
            }
            foreach (int element in arrLeft)
                Console.Write(element + " ");

            Console.Write(p + " ");
            foreach (int element in arrRight)
                Console.Write(element + " ");
        }
    }
}
