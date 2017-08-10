using System;
using System.Text;
/*Sample input 0:
 * 4
 * 1112
 * 1912
 * 1892
 * 1234
 * Sample output 0:
 * 1112
 * 1X12
 * 18X2
 * 1234
 */
namespace Implementations
    {
    /// <summary>
    /// Cavity map
    /// https://www.hackerrank.com/challenges/cavity-map
    /// </summary>
    public class CavityMap
        {
        public static void Main (string[] args)
            {
            int size = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            string[] input = new string[size];
            
            for ( int i = 0; i < size; i++ )
                input[i] = Console.ReadLine();
            if(size != 1)
                sb.Append(input[0] + "\n");

            for ( int i = 1; i < size - 1; i++ )
                {
                string preInput = input[i - 1];
                string currentInput = input[i];
                string postInput = input[i + 1];
                StringBuilder sbTemp = new StringBuilder();
                sbTemp.Append(currentInput[0]);
                for ( int j = 1; j < size - 1; j++ )
                    {
                    int pre = Convert.ToInt32(currentInput[j - 1]);
                    int current = Convert.ToInt32(currentInput[j]);
                    int post = Convert.ToInt32(currentInput[j + 1]);

                    int top = Convert.ToInt32(preInput[j]);
                    int bottom = Convert.ToInt32(postInput[j]);

                    if ( pre < current && current > post && current > top && current > bottom )
                        sbTemp.Append('X');
                    else
                        sbTemp.Append(currentInput[j]);
                    }
                sbTemp.Append(currentInput[size - 1]);
                sb.Append(sbTemp.ToString() + "\n");
                }
            sb.Append(input[size - 1]);
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            }
        }
    }
