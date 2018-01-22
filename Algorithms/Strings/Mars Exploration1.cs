using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Mars_Exploration1
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string sos = "SOS";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
                if (!str[i].Equals(sos[i % 3]))
                    count++;

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
