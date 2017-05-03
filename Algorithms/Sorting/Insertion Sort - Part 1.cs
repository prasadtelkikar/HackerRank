using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertion_Sort___Part_1
    {
        public static void Main(string[] args)
        {
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrSize];
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < arrSize; i++)
                arr[i] = Convert.ToInt32(elements[i]);

            InsertionSort(arr);

        }

        private static void InsertionSort(int[] arr)
        {
            int size = arr.Length;
            for (int i = size - 1; i >= 0; i--)
            {
                int key = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (key < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        break;
                    }
                        
                }
                DisplayArray(arr);
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }

        private static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
