using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Big_Sorting
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            ulong[] arrLong = new ulong[size];
            string[] arrLongString = new string[size];
            for (int i = 0; i < size; i++)
                arrLongString[i] = Console.ReadLine();

            for (int i = 0; i < size; i++)
                arrLong[i] = ulong.Parse(arrLongString[i]);

            Array.Sort(arrLong);

            foreach (long value in arrLong)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
