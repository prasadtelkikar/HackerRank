using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_34
    {
    class MaxGcdAndSum
        {
        public static void Main (string[] args)
            {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] firstArrStr = Console.ReadLine().Split(' ');
            string[] secondArrStr = Console.ReadLine().Split(' ');
            int[] firstArr = Array.ConvertAll(firstArrStr, Int32.Parse);
            int[] secondArr = Array.ConvertAll(secondArrStr, Int32.Parse);
            int max = Int32.MinValue;
            int sum = CalculateMaxGCD(firstArr, secondArr);
            Console.WriteLine(sum);
            Console.ReadLine();
            }

        private static int CalculateMaxGCD (int[] firstArr, int[] secondArr)
            {
            int finalResult = 0;
            int max = Int32.MinValue;
            int valueOfJthElement = 0;
            for ( int i = 0; i < firstArr.Length; i++ )
                {
                int maxGCD = Int32.MinValue;
                for ( int j = 0; j < firstArr.Length; j++ )
                    {
                    int result = GetGCD(firstArr[i], secondArr[j]);
                    if ( maxGCD < result )
                        {
                        maxGCD = result;
                        valueOfJthElement = secondArr[j];
                        }
                    }
                if ( max < maxGCD )
                    {
                    finalResult = firstArr[i] + valueOfJthElement;
                    }
                }
            return finalResult;
            }

        private static int GetGCD (int firstNumber, int secondNumber)
            {
            while ( true )
                {
                var remainder = firstNumber % secondNumber;

                if ( remainder == 0 )
                    return secondNumber;

                firstNumber = secondNumber;
                secondNumber = remainder;
                }
            }
        }
    }
