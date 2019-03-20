using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Cheated : https://www.techiedelight.com/print-triplets-forms-geometric-progression/
//Passed 3/13 test cases
//Correct implementation : https://www.geeksforgeeks.org/number-gp-geometric-progression-subsequences-size-3/
namespace DictionaryAndHashTables
{
    public class CountTriplets
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int n = int.Parse(numbers[0]);
            int r = int.Parse(numbers[1]);
            int count = 0;

            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int j = 1; j < n - 1; j++)
            {
                int i = j - 1;
                int k = j + 1;

                while (true)
                {
                    while(i >=0 && k < n && array[j] % array[i] == 0 && array[k] % array[j] == 0 && (array[j] % array[i] == array[k] % array[j]))
                    {
                        count++;
                        k++;
                        i--;
                    }
                    if (i < 0 || k >= n)
                        break;

                    if (array[j] % array[i] == 0 && array[k] % array[j] == 0)
                    {
                        if (array[j] % array[i] < array[k] % array[j])
                            i--;
                        else
                            k++;
                    }

                    else if (array[j] % array[i] == 0)
                        k++;
                    else
                        i--;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();

            //TODO : Complete it tomorrow.sss
        }
    }
}
