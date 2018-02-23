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
                int count = 0;
                string str = Console.ReadLine();
                for (int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j] == str[j + 1])
                    {
                        str.Remove(j, 1);
                        count++;
                    }
                }
                outputs.Add(count);
            }

            foreach (int output in outputs)
                Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
