using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Caesar_Cipher
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hi Prasad Welcome~back");
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int value = Convert.ToInt32(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                int asciiValue = Convert.ToInt32(ch);
                if ((asciiValue >= 97 && asciiValue <= 122) || (asciiValue >= 65 && asciiValue <= 90))
                {
                    int result = asciiValue + value;
                    if (result > 122 || (result > 90 && result < 96))
                        result -= 26;
                    sb.Append(Convert.ToChar(result));

                }
                else
                    sb.Append(ch);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
