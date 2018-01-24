using System;
using System.Collections.Generic;

namespace Strings
{
    class GemStone
    {
        public static void Main(string[] args)
        {
            int inputs = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, bool> countLetters = new Dictionary<char, bool>();
            string aToz = "abcdefghijklmnopqrstuvwxyz";

            foreach (char ch in aToz)
                countLetters.Add(ch, false);

            for (int i = 0; i < inputs; i++)
            {
                string inputString = Console.ReadLine();
                if(i == 0)
                {
                    foreach (char ch in inputString)
                    {
                        countLetters[ch] = true;
                    }
                    foreach (char chq in aToz)
                    {
                        if (countLetters.ContainsKey(chq) && (!countLetters[chq]))
                            countLetters.Remove(chq);
                        else
                            countLetters[chq] = false;
                    }
                }
                else
                {
                    foreach (char ch in inputString)
                    {
                        if(countLetters.ContainsKey(ch))
                            countLetters[ch] = true;
                    }
                    foreach (char chq in aToz)
                    {
                        if (countLetters.ContainsKey(chq) && (!countLetters[chq]))
                            countLetters.Remove(chq);
                        else if(countLetters.ContainsKey(chq))
                            countLetters[chq] = false;
                    }

                }
            }


            Console.WriteLine(countLetters.Count);
            Console.ReadKey();
        }
    }
}
