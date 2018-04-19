using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_Code_37
{
    public class AverageRating
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] rating = new int[n];

            for (int ratingItr = 0; ratingItr < n; ratingItr++)
            {
                int ratingItem = Convert.ToInt32(Console.ReadLine());
                rating[ratingItr] = ratingItem;
            }

           double result = AverageRatingOfTopEmployee(rating);
            Console.WriteLine(string.Format("{0:0.00}",result));
            Console.ReadKey();
        }

        private static double AverageRatingOfTopEmployee(int[] rating)
        {
            int[] topEmployee = rating.Where(x => x >= 90 && x <= 100).ToArray();
            int noOfEmployee = topEmployee.Length;
            double sum = topEmployee.Sum();
            double result = sum / noOfEmployee;

            //https://stackoverflow.com/questions/311696/why-does-net-use-bankers-rounding-as-default
            return Math.Round(result, 2,MidpointRounding.AwayFromZero);
        }
    }
}
