using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_32
{
    class CircularWalk
    {
        public static void Main(String[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(firstLine[0]);
            int s = Convert.ToInt32(firstLine[1]);
            int t = Convert.ToInt32(firstLine[2]);

            int[] r = new int[n];
            r[0] = Convert.ToInt32(secondLine[0]);
            int g = Convert.ToInt32(secondLine[1]);
            int seed = Convert.ToInt32(secondLine[2]);
            int p = Convert.ToInt32(secondLine[3]);

            for (int i = 1; i < n; i++)
                r[i] = ((r[i - 1]*g) + seed)%p;

            int initial = s;
            while (true)
            {
                int clockwise = s + r[initial];
                if (clockwise >= n)
                    clockwise %= n;
                int anticlockwise = s - r[initial];
                if (anticlockwise < 0)
                {
                    anticlockwise = n - anticlockwise;
                }
                //if(r[initial])

            }
            Console.ReadKey();
        }
    }
}
