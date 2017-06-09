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
            for (int i = 0; i < size; i++)
            {
                bool flag = false;
                for (int j = 0; j < size - i-1; j++)
                {
                    if (bInt[j] > bInt[j + 1])
                    {
                        flag = true;
                        BigInteger temp = new BigInteger();
                        temp = bInt[j];
                        bInt[j] = bInt[j + 1];
                        bInt[j + 1] = temp;
                    }
                }
                if (!flag)
                    break;
            }
            //Array.Sort(bInt);
            foreach (var element in bInt)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
