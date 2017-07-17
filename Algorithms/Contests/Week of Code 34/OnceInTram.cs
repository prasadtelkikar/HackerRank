using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_34
    {
    public class OnceInTram
        {
        public static void Main (string[] args)
            {
            string numString = Console.ReadLine();
            int number = Convert.ToInt32(numString);
            string firstSubNumber = numString.Substring(0, 3);
            string secondSubNumber = numString.Substring(3, 3);
            int firstNum = Convert.ToInt32(firstSubNumber);
            int secondNum = Convert.ToInt32(secondSubNumber);

            if ( firstNum != secondNum )
                {
                int sumFirst = GetSum(firstNum);
                int sumSecond = GetSum(secondNum);
                //Failing for 123456
                //number += (sumFirst > sumSecond) ? (sumFirst - sumSecond) : (sumSecond - sumFirst);
                }
            else
                {
                int temp1 = firstNum % 100;
                int temp2 = secondNum % 100;
                    if (temp1 == 0 && temp2 == 0)
                    {
                        number = Convert.ToInt32(string.Concat((firstNum + 1).ToString(), (secondNum + 1).ToString()));
                    }
                    else
                        number += 9;
                }
            Console.WriteLine(number);
            Console.ReadKey();
            }

        private static int GetSum (int number)
            {
            int sum = 0;
            while ( number > 0 )
                {
                sum += number % 10;
                number /= 10;
                }
            return sum;
            }
        }
    }
