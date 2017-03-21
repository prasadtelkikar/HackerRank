using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        public static void Main(string[] args)
        {

            long remainder = 0, numberOfa = 0, quotient = 0, remainderCount = 0;
            string infiniteString = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            remainder = n % infiniteString.Length;
            quotient = n / infiniteString.Length;

            foreach(char ch in infiniteString)
            {
                if (ch == 'a')
                    numberOfa++;
            }

            for (int i = 0; i < remainder; i++)
            {
                if (infiniteString[i] == 'a')
                    remainderCount++;
            }

            Console.WriteLine(((quotient * numberOfa) + remainderCount));
        }
    }
}
