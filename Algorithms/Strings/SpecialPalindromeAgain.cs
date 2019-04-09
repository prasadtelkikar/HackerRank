using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    //Referred implemnetation from https://github.com/charles-wangkai/hackerrank/blob/master/special-palindrome-again/Solution.java
    public class SpecialPalindromeAgain
    {
        public static void Main(string[] args)
        {
            string[] f = File.ReadAllLines(Environment.CurrentDirectory + @"\TestCases\SpecialPalindromeAgain.txt");
            int n = int.Parse(f[0]);
            string input = f[1];
            List<SpecialPalindrome> specialPalindromes = new List<SpecialPalindrome>();
            long result = 0;

            char letter = char.MinValue;
            int occurance = -1;
            for (int i = 0; i <= input.Length; i++)
            {
                if (i < input.Length && input[i] == letter)
                    occurance++;
                else
                {
                    if (letter > char.MinValue)
                        specialPalindromes.Add(new SpecialPalindrome(letter, occurance));
                    if(i < input.Length)
                    {
                        letter = input[i];
                        occurance = 1;
                    }
                }
            }

            for (int i = 0; i < specialPalindromes.Count; i++)
            {
                result += (specialPalindromes[i].occurance * (specialPalindromes[i].occurance + 1)) / 2;

                if (i > 0 && i + 1 < specialPalindromes.Count && specialPalindromes[i - 1].letter == specialPalindromes[i + 1].letter && specialPalindromes[i].occurance == 1)
                    result += Math.Min(specialPalindromes[i - 1].occurance, specialPalindromes[i + 1].occurance);

            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private class SpecialPalindrome
        {
            public char letter;
            public int occurance;

            public SpecialPalindrome(char letter, int occurance)
            {
                this.letter = letter;
                this.occurance = occurance;
            }
        }
    }
}
