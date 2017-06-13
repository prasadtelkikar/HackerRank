using System;
using System.Numerics;

//Need optimal: Time out error due to bubble sort.
namespace Arrays
{
    public class BigSorting
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            ulong[] uLArray = new ulong[size];
            BigInteger[] bInt = new BigInteger[size];
            for (int i = 0; i < size; i++)
            {
                bInt[i] = BigInteger.Parse(Console.ReadLine());
            }

            //Quicksort with O(nLog n) time complexity
            Array.Sort(bInt);

            foreach (var element in bInt)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
