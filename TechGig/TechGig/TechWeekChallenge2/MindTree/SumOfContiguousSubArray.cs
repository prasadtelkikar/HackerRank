using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechWeekChallenge2.MindTree
{
    //https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    //My Approach
    public class SumOfContiguousSubArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int sumOfSubArray = FindSumOfContiguousSubArray(array);
            Console.WriteLine("Sum of array is " + sumOfSubArray);
            Console.ReadKey();
        }

        private static int FindSumOfContiguousSubArray(int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                Stack<int> sum = new Stack<int>();
                sum.Push(array[i]);

                for (int j = i+1; j < array.Length; j++)
                {
                    int top = sum.Pop();
                    top += array[j];

                    if (max < top)
                        max = top;

                    sum.Push(top);
                }
            }
            return max;
        }
    }
}
