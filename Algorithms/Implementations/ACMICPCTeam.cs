using System;
using System.Text;
/*Sample inputs 0:
 * 4 5
 * 10101
 * 11100
 * 11010
 * 00101
 * Sample output 0:
 * 5
 * 2
 */
namespace Implementations
    {
    /// <summary>
    /// ACM ICPC Team
    /// https://www.hackerrank.com/challenges/acm-icpc-team/problem
    /// </summary>
    public class ACMICPCTeam
        {
        public static void Main (string[] args)
            {
            string[] nm = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nm[0]);
            int max = 0;
            int count = 0;

            string[] arr = new string[n];
            for ( int i = 0; i < n; i++ )
                {
                arr[i] = Console.ReadLine();
                }
            for ( int i = 0; i < n; i++ )
                {
                for ( int j = i + 1; j < n; j++ )
                    {
                    char[] iChar = arr[i].ToCharArray();
                    char[] jChar = arr[j].ToCharArray();
                    StringBuilder sb = new StringBuilder();

                    for ( int k = 0; k < iChar.Length; k++ )
                        {
                        if ( iChar[k] == '0' && jChar[k] == '0' )
                            sb.Append('0');
                        else
                            sb.Append('1');
                        }

                    int temp = sb.ToString().Replace("0", "").Length;

                    if ( temp > max )
                        {
                        max = temp;
                        count = 1;
                        }
                    else if (temp == max)
                        count++;
                    }
                }
            Console.WriteLine(max);
            Console.WriteLine(count);
            Console.ReadKey();
            }
        }
    }
