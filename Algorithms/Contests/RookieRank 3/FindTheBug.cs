using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.RookieRank_3
{
    class FindTheBug
    {
        public static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] bugs = new string[size];

            for (int i = 0; i < size; i++)
                bugs[i] = Console.ReadLine();

            FindBugs(bugs, size);
            Console.ReadLine();
        }

        private static void FindBugs(string[] bugs, int size)
        {
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (bugs[i][j] == 'X')
                    {
                        Console.WriteLine(i + "," + j);
                        break;
                    }
                }
            }
        }
    }
}
