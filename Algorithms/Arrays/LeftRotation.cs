using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Sample Inputs 0:
 * 5 4
 * 1 2 3 4 5
 * Sample Output 0:
 * 5 1 2 3 4
 */
namespace Arrays
{
    /// <summary>
    /// Left Rotation
    /// https://www.hackerrank.com/challenges/array-left-rotation
    /// </summary>
    public class LeftRotation
    {
        public static void Main(string[] args)
        {
            string[] nq = Console.ReadLine().Split(' ');
            int[] sizeShift = Array.ConvertAll(nq, Int32.Parse);

            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);

            var count = arr.Length;
            int[] leftRotatedArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                leftRotatedArray[i] = arr[(i + sizeShift[1]) % sizeShift[0]];
            }
            foreach (int value in leftRotatedArray)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
    }
}
