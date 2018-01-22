using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class MarsExploration
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int length = 0;
            int count = 0;
            while(length < (str.Length - 2))
            {
                if (str[length] != 'S')
                    count++;
                if (str[length + 1] != 'O')
                    count++;
                if (str[length + 2] != 'S')
                    count++;

                length += 3;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
