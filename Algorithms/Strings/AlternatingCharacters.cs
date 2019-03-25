using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class AlternatingCharacters
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> outputs = new List<int>();

            for (int i = 0; i < input; i++)
            {
                string str = Console.ReadLine();
                string temp = str.Substring(0, str.Length - 1);
                var a = new string(temp.Where((c, k) => c == str[k + 1]).ToArray());
                outputs.Add(a.Length);
            }

            foreach (int output in outputs)
                Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
