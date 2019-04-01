using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public class FlippingBits
    {
        public static void Main(string[] args)
        {
            List<long> results = new List<long>();
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                long number = long.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(number, 2).PadLeft(32, '0');
                string flippedBinary = string.Join("", binaryNumber.Select(x => x == '0' ? '1' : '0'));
                results.Add(Convert.ToInt64(flippedBinary, 2));
            }

            foreach (long result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
