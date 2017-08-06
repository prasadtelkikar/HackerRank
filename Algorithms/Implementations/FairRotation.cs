using System;
using System.Linq;
/*Sample input 0:
 * 5
 * 2 3 4 5 6
 * Sample output 0:
 * 4
 * Sample input 1:
 * 2
 * 1 2
 * Sample output 1:
 * NO
*/
namespace Implementations
    {
    /// <summary>
    /// Fair Rotation
    /// https://www.hackerrank.com/challenges/fair-rations
    /// </summary>
    public class FairRotation
        {
        public static void Main (string[] args)
            {
            int count = Convert.ToInt32(Console.ReadLine());
            string[] arrString = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arrString, Int32.Parse);
            int result = 0;

            int sum = arr.Sum();

            if ( sum % 2 != 0 )
                Console.WriteLine("NO");
            else
                {
                for ( int i = 0; i < count - 2; i++ )
                    {
                    int firstNumber = arr[i];
                    int secondNumber = arr[i + 1];
                    int rem = (firstNumber + secondNumber) % 2;
                    if ( rem == 0 )
                        {
                        if ( firstNumber % 2 != 0 && secondNumber % 2 != 0 )
                            {
                            arr[i] += 1;
                            arr[i + 1] += 1;
                            result += 2;
                            }
                        }
                    else
                        {
                        if ( firstNumber % 2 != 0 )
                            {
                            arr[i] += 1;
                            arr[i + 1] += 1;
                            result += 2;
                            }
                        else
                            {
                            arr[i + 1] += 1;
                            arr[i + 2] += 1;
                            result += 2;
                            }
                        }
                    }
                Console.WriteLine(result);
                }
            Console.ReadKey();
            }
        }
    }

