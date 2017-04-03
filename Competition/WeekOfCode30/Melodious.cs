using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodious
{
    class Melodious
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>(5);
            vowels = "aeiou".ToList();

            List<char> consonants = new List<char>(20);
            consonants = "bcdfghjklmnpqrstvwxz".ToList();

            int r = Convert.ToInt32(Console.ReadLine());

            Melodious.PrintCombinations(vowels, consonants, r);

            Console.ReadKey();
        }

        private static void PrintCombinations(List<char> vowels, List<char> consonants, int r)
        {
            List<char> data = new List<char>(r);
            if (r == 1)
            {
                for (char c = 'a'; c <= 'z'; c++)
                    if (c != 'y')
                        Console.WriteLine(c);
            }
            else if(r == 2)
            {
                foreach (char c in vowels)
                {
                    CombineUtil(consonants, data, 0, consonants.Count, 0, r, c);
                }
            }
            else if (r == 3)
            {
                foreach (char c in consonants)
                {
                    CombineUtilConsFirst(vowels, data, c, r, 0, vowels.Count, 0);
                }
            }
        }

        private static void CombineUtilConsFirst(List<char> vowels, List<char> data, char c, int r, int startVowels,
            int endVowels, int index)
        {

            foreach (char vowelOuter in vowels)
            {
                foreach (var vowelInner in vowels)
                {
                    data.Insert(0, vowelOuter);
                    data.Insert(1, c);
                    data.Insert(2, vowelInner);
                    if (data.Count == r)
                    {
                        Console.WriteLine(data.ToArray());
                        Console.ReadKey();
                        data.Clear();
                    }
                }
            }

        }

        private static void CombineUtil(List<char> consonants, List<char> data, int startConsonant, int endConsonant, int index, int r, char c)
        {
            if (index == r)
            {
                Console.WriteLine(data.ToArray());
                Console.ReadKey();
                data.Clear();
                return;
            }
            for (int i = startConsonant; i < endConsonant; i++)
            {
                data.Add(consonants[i]);
                if (data.Count % 2 != 0 && data.Count != r)
                    data.Add(c);
                CombineUtil(consonants, data, i + 1, endConsonant, data.Count, r, c);
            }
        }
    }
}
