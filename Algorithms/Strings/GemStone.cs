using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class GemStone
    {
        public static void Main(string[] args)
        {
            int inputs = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, int> countLetters = new Dictionary<char, int>();
            string aToz = "abcdefghijklmnopqrstuvwxyz";

            foreach (char ch in aToz)
                countLetters.Add(ch, 0);

            for (int i = 0; i < inputs; i++)
            {
                string inputString = Console.ReadLine();
                foreach (char chq in inputString)
                {
                    if(countLetters.ContainsKey(chq))
                        countLetters[chq]++;
                }
                foreach (char chq in aToz)
                {
                    if (countLetters.ContainsKey(chq) && countLetters[chq] != i + 1)
                        countLetters.Remove(chq);
                }
            }


            Console.WriteLine(countLetters.Count);
            Console.ReadKey();
        }
    }
}
