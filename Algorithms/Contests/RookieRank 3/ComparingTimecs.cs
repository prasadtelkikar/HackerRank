using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.RookieRank_3
{
    class ComparingTimecs
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            string[] inputs = new string[testCases];

            for (int i = 0; i < testCases; i++)
                inputs[i] = Console.ReadLine();

            List<string> results =  GetResults(inputs);
            foreach (string result in results)
                Console.WriteLine(result);
            Console.ReadKey();
        }

        private static List<string> GetResults(string[] inputs)
        {
            List<string> Results = new List<string>();
            foreach (string input in inputs)
            {
                string time1 = input.Split(' ')[0];
                string time2 = input.Split(' ')[1];
                int time1Length = time1.Length;
                string AMPM1= time1.Substring(time1Length - 2, 2);
                string AMPM2 = time2.Substring(time1Length - 2, 2);
                if (AMPM1.Equals("AM") && AMPM2.Equals("PM"))
                    Results.Add("First");
                else if (AMPM1.Equals("PM") && AMPM2.Equals("AM"))
                    Results.Add("Second");
                else
                {
                    
                    time1 = (time1.Substring(0, 5).Remove(2, 1));
                    time2 = (time2.Substring(0, 5).Remove(2, 1));
                    int hrTime1 = Convert.ToInt32(time1.Substring(0, 2));
                    int minTime1 = Convert.ToInt32(time1.Substring(2));
                    int hrTime2 = Convert.ToInt32(time2.Substring(0, 2));
                    int minTime2 = Convert.ToInt32(time2.Substring(2));
                    if (hrTime1 == 12 && AMPM1.Equals("AM"))
                        hrTime1 = 0;
                    if (hrTime2 == 12 && AMPM2.Equals("AM"))
                        hrTime2 = 0;
                    if (AMPM1.Equals("PM") && hrTime1 != 12)
                        hrTime1 += 12;
                    if (AMPM2.Equals("PM") && hrTime2 != 12)
                        hrTime2 += 12;

                    DateTime firstTiming = new DateTime(1, 1, 1, hrTime1, minTime1, 0);
                    DateTime secondTiming = new DateTime(1, 1, 1, hrTime2, minTime2, 0);
                    if(firstTiming.TimeOfDay.TotalSeconds == 0)
                        Results.Add("First");
                    else if(secondTiming.TimeOfDay.TotalSeconds == 0)
                        Results.Add("Second");
                    else
                        Results.Add(firstTiming.TimeOfDay > secondTiming.TimeOfDay ? "Second" : "First");
                }
            }
            return Results;
        }
    }
}
