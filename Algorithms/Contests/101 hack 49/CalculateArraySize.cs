using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests._101_hack_49
{
    class CalculateArraySize
    {
        public const int KBUnit = 1024;
        public static void Main(string[] args)
        {
            
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arrSizeStr = Console.ReadLine().Split(' ');
            int[] arrSize = Array.ConvertAll(arrSizeStr, Int32.Parse);

            long result = 1;
            for (int i = 0; i < size; i++)
                result *= arrSize[i];

            Console.WriteLine(Math.Floor(((double)result * 4) / KBUnit));
            Console.ReadLine();

        }
    }
}
