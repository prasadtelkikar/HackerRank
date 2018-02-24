using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Incomplete.Do it tomorrow...25/02/2018
namespace Implementations
{
    class NonDivisibleSubset
    {
        public static void Main(String[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int length = Convert.ToInt32(inputs[0]);
            int divisor = Convert.ToInt32(inputs[1]);
            string[] stringArr = Console.ReadLine().Split(' ');
            
            int[] arr = Array.ConvertAll(stringArr, Int32.Parse);
            int[] outputArr = new int[divisor];

            foreach (int element in arr)
            {
                outputArr[(element%divisor)]++;
            }
            int count = 0;
            bool flag = true;
            for (int i = 1; i <= divisor / 2; i++)
            {
                flag = false;
                if (outputArr[i] > outputArr[divisor - i])
                    count += outputArr[i];
                else
                    count += outputArr[divisor - i];
            }
            Console.WriteLine(flag ? 1 : count);

            Console.ReadKey();
        }
    }
}
