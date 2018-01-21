using System;
using System.Text;
/*
 * Input 1:
 * 11
 * middle-Outz
 * 2
 * 
 * Output 1:
 * okffng-Qwvb
 */
namespace Strings
{
    /// <summary>
    /// Ceasar_Cipher : Encryption and decryption of a string
    /// </summary>
    class Caesar_Cipher
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int value = Convert.ToInt32(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            foreach (char ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    int result = Convert.ToInt32(ch) + value;
                    char ch1 = (char)result;
                    if ((ch >= 'A' && ch <= 'Z'))
                    {
                        do
                        {
                            if (result > 90)
                                result -= 26;
                        } while (result > 90);

                    }
                    if (ch >= 'a' && ch <= 'z')
                    {
                        do
                        {
                            if (result > 122)
                                result -= 26;
                        } while (result > 122);
                    }

                    ch1 = (char)result;
                    sb.Append(ch1);
                }
                else
                    sb.Append(ch);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
