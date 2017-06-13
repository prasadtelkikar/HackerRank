using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_code_33
{
    public class PatternCount
    {
        public static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> count = new List<int>();

            for (int i = 0; i < size; i++)
            {
                int iCount = 0;
                string input = Console.ReadLine();
                int index = input.IndexOf('1');
                for (int j = index; j >= 0; j = input.IndexOf('1', j + 1))
                {

                    int length = input.IndexOf('1', j + 1) - j - 1;
                    if(length == 0)
                        continue;
                    if (length < 0)
                        break;
                    string temp = input.Substring(j + 1, length);
                    if (temp.TrimEnd('0').Length == 0)
                        iCount++;
                }
                count.Add(iCount);
            }
            foreach (var value in count)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
