using System;

/* Sample Input 0:
 * 2017
 * Sample output 0:
 * 13.09.2017
 * Sample Input 1:
 * 2016
 * Sample output 1:
 * 12.09.2016
 */

namespace Implementations
    {
    /// <summary>
    /// Day of The Programmer (the 256th day of the year)
    /// https://www.hackerrank.com/challenges/day-of-the-programmer/problem
    /// </summary>
    public class DayOfTheProgrammer
        {
        public static void Main (string[] args)
            {
            string yearString = Console.ReadLine();
            int year = Convert.ToInt32(yearString);
            if ( year < 1918 )
                {
                Console.WriteLine(year % 4 == 0 ? "12.09." + year : "13.09." + year);
                }
            else if ( year > 1918 )
                {
                Console.WriteLine((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) ? "12.09." + year : "13.09." + year);
                }
            else
                {
                Console.WriteLine("26.09."+year);
                }
            }
        }
    }
