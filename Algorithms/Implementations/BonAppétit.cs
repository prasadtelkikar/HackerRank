using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class BonAppétit
    {
        public static void Main(String[] args)
        {
            string[] nkInString = Console.ReadLine().Split(' ');
            int[] nk = Array.ConvertAll(nkInString, Int32.Parse);

            string[] costOfItemsInString = Console.ReadLine().Split(' ');
            int[] costOfItems = Array.ConvertAll(costOfItemsInString, Int32.Parse);

            string billChargedInString = Console.ReadLine();
            int billCharged = Convert.ToInt32(billChargedInString);

            int actualBill = 0;
            for (int i = 0; i < nk[0]; i++)
            {
                if(i == nk[1])
                    continue;

                actualBill += costOfItems[i];
            }
            int result = billCharged - (actualBill / 2);
            if (result == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
