using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Find_The_Point
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            float[] nextX = new float[testCases];
            float[] nextY = new float[testCases];
            for (int i = 0; i < testCases; i++)
            {
                string[] pointsString = Console.ReadLine().Split(' ');
                float[] points = Array.ConvertAll(pointsString, float.Parse);

                float diffX = points[2] - points[0];
                float diffY = points[3] - points[1];

                nextX[i] = points[2] + diffX;
                nextY[i] = points[3] + diffY;
            }
            for (int i = 0; i < testCases; i++)
            {
                Console.WriteLine(nextX[i] +" "+nextY[i]);
            }
            Console.ReadKey();
        }
    }
}
