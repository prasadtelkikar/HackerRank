using System;
using System.Linq;

namespace Strings
{
    class CamelCase
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int count = str.Where(c => c >= 'A' && c <= 'Z').Count();

            Console.WriteLine(count + 1);
            Console.ReadKey();
        }
    }
}
