using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
    {
    public class ManasaAndStones
        {
        public static void Main (string[] args)
            {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for ( int i = 0; i < testCases; i++ )
                {
                int length = Convert.ToInt32(Console.ReadLine());
                int startPoint = Convert.ToInt32(Console.ReadLine());
                int endPoint = Convert.ToInt32(Console.ReadLine());

                string output = GetFinalList(length - 1, startPoint, endPoint);
                results.Add(output);
                }
            foreach ( string item in results )
                {
                Console.WriteLine(item);
                }
            Console.ReadKey();
            }

        private static string GetFinalList (int length, int startPoint, int endPoint)
            {
            StringBuilder sb = new StringBuilder();
            int lowerBound = startPoint * (length);
            int upperBound = endPoint * (length);
            sb.Append(lowerBound + " ");
            int diff = (upperBound - lowerBound) / (length);
            int temp = lowerBound;
            while ( lowerBound < upperBound )
                {
                temp += diff;
                sb.Append(temp + " ");
                lowerBound = temp;
                }
            return sb.ToString();
            }
        }
    }
