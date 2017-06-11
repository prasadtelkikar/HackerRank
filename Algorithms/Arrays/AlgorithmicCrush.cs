using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AlgorithmicCrush
    {
        public static void Main(string[] args)
        {
            string[] f = File.ReadAllLines(@"D:\input.txt");
            string[] mn = f[0].Split(' ');

            //string[] mn = Console.ReadLine().Split(' ');
            long sizeOfArray = Convert.ToInt64(mn[0]);
            long numberOfOperations = Convert.ToInt64(mn[1]);
            long maxValue = long.MinValue;
            long[] result = new long[sizeOfArray];
            long[] start = new long[numberOfOperations + 1];
            long[] end = new long[numberOfOperations + 1];
            long[] value = new long[numberOfOperations + 1];

            for (int i = 1; i <= numberOfOperations; i++)
            {
                string[] lineOfInputs = f[i].Split(' ');//Console.ReadLine().Split(' ');
                int startRangeValue = (Convert.ToInt32(lineOfInputs[0]) - 2);
                int endRangeValue = (Convert.ToInt32(lineOfInputs[1]) - 1);
                long valueInput = Convert.ToInt64(lineOfInputs[2]);
                start[i] = startRangeValue;
                end[i] = endRangeValue;
                value[i] = valueInput;
                
            }
            long j = 0;
            while (j < start.Length)
            {
                if (start[j] == end[j])
                    j++;
                else
                {
                    start[j] += 1;
                    result[start[j]] += value[j];
                }
            }
            maxValue = result.Max();
            Console.WriteLine(maxValue);
            Console.ReadKey();
        }
    }
}
