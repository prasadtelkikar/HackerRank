using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Sample input 0:
 * abacaba
 * Sample output 0:
 * Yes
 * Sample input 1:
 * badd
 * Sample output 1:
 * No
 * Sample input 2:
 * yes
 * Sample output 2:
 * No 
 */
namespace Contests.Week_of_Codes_31
{
    /// <summary>
    /// Easy problem from contest Week of Codes 31
    /// https://www.hackerrank.com/contests/w31/challenges/beautiful-word
    /// </summary>
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
