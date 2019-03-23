using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MarkAndToys
    {
        public static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            long k = long.Parse(nk[1]);

            long[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            //Using inbuild sort function. : this need to be done by some sorting technique
            List<long> pricesList = prices.OrderBy(x => x).ToList();

            long sum = 0;
            long toyCount = 0;
            foreach (long price in pricesList)
            {
                sum += price;
                if (sum > k)
                    break;
                else
                    toyCount++;
            }

            Console.WriteLine(toyCount);
            Console.ReadLine();
        }
    }
}
