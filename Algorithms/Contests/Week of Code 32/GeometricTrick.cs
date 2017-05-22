using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_32
{
    public class GeometricTrick
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string charArray = Console.ReadLine();
            List<int> indexA = new List<int>();
            List<int> indexB = new List<int>();
            List<int> indexC = new List<int>();

            for (int i = charArray.IndexOf('a'); i > -1 && i < size; i = charArray.IndexOf('a', i+1))
            {
                indexA.Add(i + 1);
            }
            for (int i = charArray.IndexOf('b'); i > -1; i = charArray.IndexOf('b', i + 1))
            {
                int temp = (int)Math.Pow((i + 1), 2);
                indexB.Add(temp);
            }
            for (int i = charArray.IndexOf('c'); i > -1; i = charArray.IndexOf('c', i + 1))
            {
                indexC.Add(i + 1);
            }
            int count = 0;
            
            foreach (int b in indexB)
            {
                foreach (int a in indexA)
                {
                    if (b%a == 0)
                    {
                        int result = b / a;
                        if (indexC.Contains(result))
                            count++;
                    }
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}

