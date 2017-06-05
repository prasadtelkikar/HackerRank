using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class _2D_Array___DS
    {
        public const int SIZE = 6;
        public static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int i = 0; i < SIZE; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int max = Int32.MinValue;
            for (int i = 0; i < SIZE - 2; i++)
            {
                for (int j = 0; j < SIZE - 2; j++)
                {
                    int result = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] +
                                 arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    max = (result > max) ? result : max;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
