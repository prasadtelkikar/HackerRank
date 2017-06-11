using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class TheTimeInWords
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> minutes = new Dictionary<int, string>();
            Dictionary<int, string> hours = new Dictionary<int, string>();

            InsertMinutes(minutes);
            InsertHours(hours);

            int hour = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            string time = string.Empty;
            switch (min)
            {
                case 0:
                    time = hours[hour] + " o' clock";
                    break;
                case 15:
                    time = "quarter past " + hours[hour];
                    break;
                case 30:
                    time = "half past " + hours[hour];
                    break;
                case 45:
                    time = "quarter to " + hours[hour + 1];
                    break;
                default:
                    if (min < 30)
                    {
                        string singularPlural = (min == 1) ? " minute " : " minutes ";
                        time = minutes[min] + singularPlural + "past " + hours[hour];
                    }
                    else
                    {
                        min = 60 - min;
                        string singularPlural = (min == 1) ? " minute " : " minutes ";
                        time = minutes[min] + singularPlural + "to " + hours[hour + 1];
                    }                   
                    break;
            }
            Console.WriteLine(time);
            Console.ReadKey();
        }

        private static void InsertHours(Dictionary<int, string> hours)
        {
            hours.Add(1,"one");
            hours.Add(2, "two");
            hours.Add(3, "three");
            hours.Add(4, "four");
            hours.Add(5, "five");
            hours.Add(6, "six");
            hours.Add(7, "seven");
            hours.Add(8, "eight");
            hours.Add(9, "nine");
            hours.Add(10, "ten");
            hours.Add(11, "eleven");
            hours.Add(12, "twelve");

        }

        private static void InsertMinutes(Dictionary<int, string> minutes)
        {
            minutes.Add(1,"one");
            minutes.Add(2, "two");
            minutes.Add(3, "three");
            minutes.Add(4, "four");
            minutes.Add(5, "five");
            minutes.Add(6, "six");
            minutes.Add(7, "seven");
            minutes.Add(8, "eight");
            minutes.Add(9, "nine");
            minutes.Add(10, "ten");
            minutes.Add(11, "eleven");
            minutes.Add(12, "twelve");
            minutes.Add(13, "thirteen");
            minutes.Add(14,"fourteen");
            minutes.Add(15, "fifteen");
            minutes.Add(16, "sixteen");
            minutes.Add(17, "seventeen");
            minutes.Add(18, "eighteen");
            minutes.Add(19, "nineteen");
            minutes.Add(20, "twenty");
            minutes.Add(21, "twenty one");
            minutes.Add(22, "twenty two");
            minutes.Add(23, "twenty three");
            minutes.Add(24, "twenty four");
            minutes.Add(25, "twenty five");
            minutes.Add(26, "twenty six");
            minutes.Add(27, "twenty seven");
            minutes.Add(28, "twenty eight");
            minutes.Add(29, "twenty nine");
        }
    }
}
