using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //TODO: Solve it with mod (%) operator
    public class LeftRotation
    {
        public static void Main(string[] args)
        {
            string[] nq = Console.ReadLine().Split(' ');
            int[] sizeShift = Array.ConvertAll(nq, Int32.Parse);

            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            int[] temp = new int[sizeShift[0]];
            Array.Copy(arr, temp, sizeShift[1]);
            
            for (int i = 0; i < sizeShift[1]; i++)
            {
                for (int j = 0; j < sizeShift[0] - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[sizeShift[0] - 1] = temp[i];
            }
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.ReadKey();
        }
    }
}
