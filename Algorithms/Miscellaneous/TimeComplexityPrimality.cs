using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public class TimeComplexityPrimality
    {
        public static void Main(string[] args)
        {
            List<bool> result = new List<bool>();
            int numberOfTestCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                double number = double.Parse(Console.ReadLine());
                result.Add(IsPrimaryNumber(number));
            }
            foreach (var item in result)
            {   
                Console.WriteLine(item ? "Prime" : "Not prime");
            }

            Console.ReadLine();
        }

        public static bool IsPrimaryNumber(double number)
        {
            if (number == 1)  // 1 is not a prime number
                return false;
            else if (number == 2) //2 is the only even number which is prime
                return true;
            else if (number % 2 == 0 || number % 3 == 0) // any even number is not prime number
                return false;

            //Square root to iterate through half loop.
            int sqrt = (int)(Math.Sqrt(number));
            for (int i = 3; i <= sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
