using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Incomplete
namespace Implementations
{
    class CountingValleys
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string steps = Console.ReadLine();

            int count = 0, max = 0;

            foreach (char step in steps)
            {
                if (step == 'U')
                    count++;
                if (step == 'D')
                    count--;
                if (count == 0)
                    max++;
            }

            Console.WriteLine(max - 1);
            Console.ReadKey();
        }
    }
}
