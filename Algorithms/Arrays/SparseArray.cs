using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SparseArray
    {
        public static void Main(string[] args)
        {
            int sizeN = Convert.ToInt32(Console.ReadLine());
            List<string> inputStrings = new List<string>();
            for (int i = 0; i < sizeN; i++)
                inputStrings.Add(Console.ReadLine());

            int sizeQ = Convert.ToInt32(Console.ReadLine());
            List<string> findString = new List<string>();

            for (int i = 0; i < sizeQ; i++)
                findString.Add(Console.ReadLine());

            foreach (string fstring in findString)
            {
                int count = 0;
                foreach (string iString in inputStrings)
                {
                    if (iString.Equals(fstring))
                        count++;
                }
                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
