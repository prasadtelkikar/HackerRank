using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class MakingAnagrams
    {
        public static void Main(string[] args)
        {
            int count = 0;
            List<AnagramCheck> anagramChecks = new List<AnagramCheck>();
            DeclareDefault(anagramChecks);

            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();

            foreach (char letterOne in stringOne)
                anagramChecks.Where(x => x.letter == letterOne).First().firstStringCount++;

            foreach (char letterOne in stringTwo)
                anagramChecks.Where(x => x.letter == letterOne).First().secondStringCount++;


            foreach (AnagramCheck item in anagramChecks)
            {
                if(item.firstStringCount != item.secondStringCount)
                {
                    count += item.firstStringCount > item.secondStringCount ? 
                        (item.firstStringCount - item.secondStringCount) : (item.secondStringCount - item.firstStringCount);
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();

        }

        private static void DeclareDefault(List<AnagramCheck> anagramChecks)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in letters)
            {
                anagramChecks.Add(new AnagramCheck(letter));
            }
        }

        private class AnagramCheck
        {
            public char letter;
            public int firstStringCount = 0;
            public int secondStringCount = 0;

            public AnagramCheck(char letter)
            {
                this.letter = letter;
            }
        }
    }
    
}
