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
            int result = GetNextLuckyNumber(number);
            Console.WriteLine(result);
            Console.ReadKey();
            }

        private static int GetNextLuckyNumber (int number)
        {
            while (true)
            {
                number += 1;
                if (CheckSum(number))
                    return number;
            }
        }

        private static bool CheckSum(int number)
        {
            string numString = number.ToString();

            int firstNum = Convert.ToInt32(numString.Substring(0, 3));
            int secondNum = Convert.ToInt32(numString.Substring(3, 3));

            int sumFirst = GetSum(firstNum);
            int sumSecond = GetSum(secondNum);

            if (sumFirst == sumSecond)
                return true;

            return false;
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
