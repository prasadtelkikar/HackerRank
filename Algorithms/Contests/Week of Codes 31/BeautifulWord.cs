using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Codes_31
{
    class BeautifulWord
    {
        public static void Main()
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
            string word = Console.ReadLine();
            bool flag = true;
            for (int i = 0; i < (word.Length -1); i++)
                if (word[i] == word[i + 1] || (vowels.Contains(word[i])) && vowels.Contains(word[i + 1]))
                    flag = false;

            Console.WriteLine(flag ? "Yes" : "No");
            Console.ReadKey();
        }
    }
}
