using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
    {
    public class ArrayManipulation
        {
        public static void Main (string[] args)
            {
            string[] argArr = Console.ReadLine().Split(' ');
            long arrSize = Convert.ToInt64(argArr[0]);
            long arrInp = Convert.ToInt64(argArr[1]);
            long[] output = new long[arrSize];
            for ( long i = 0; i < arrInp; i++ )
                {
                string[] inputs = Console.ReadLine().Split(' ');
                long startIndex = Convert.ToInt64(inputs[0]) - 1;
                long endIndex = Convert.ToInt64(inputs[1]) - 1;
                long value = Convert.ToInt64(inputs[2]);

                output[startIndex] += value;
                if(endIndex < arrSize) output[endIndex] -= value;
                }
            Console.WriteLine(output.Max());
            Console.ReadKey();
            }
        }
    }
