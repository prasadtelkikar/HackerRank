using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int countSwap = 0;
            bool isSwapped = true;

            for (int i = 0; i < a.Length && isSwapped; i++)
            {
                isSwapped = false;
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        isSwapped = true;
                        countSwap++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {countSwap} swaps.");
            Console.WriteLine($"First Element: {a.First()}");
            Console.WriteLine($"Last Element: {a.Last()}");
            Console.ReadLine();
        }
    }
}
