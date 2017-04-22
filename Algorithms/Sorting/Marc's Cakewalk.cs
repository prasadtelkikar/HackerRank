using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sorting
{
/*Sample input 0:
 * 3
 * 1 3 2
 * Sample output 0:
 * 11
 */
    class Marc_s_Cakewalk
    {
        /// <summary>
        /// Marc's Cakewalk
        /// https://www.hackerrank.com/challenges/marcs-cakewalk
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            Array.Sort(arr, (a, b) => b.CompareTo(a));
            double calories = 0;
            for (int i = 0; i < size; i++)
            {
                double result = arr[i] * Math.Pow(2.0, i);
                calories += result;
            }
            Console.WriteLine(calories);
            Console.ReadKey();
        }
    }
}
