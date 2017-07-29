using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
    {
    public class FlatLandSpaceStation
        {
        public static void Main (string[] args)
            {
            string[] limits = Console.ReadLine().Split(' ');
            string[] stringArr = Console.ReadLine().Split(' ');
            int noOfCities = Convert.ToInt32(limits[0]);
            int spaceStations = Convert.ToInt32(limits[1]);
            bool[] cities = new bool[noOfCities];
            List<int> indexSpaceStation = Array.ConvertAll(stringArr, Int32.Parse).ToList();
            indexSpaceStation.Sort();
            int maxDist = 0;
            for ( int i = 0; i < spaceStations - 1; i++ )
            {
                int startPoint, endPoint;
                if ( i == 0 && indexSpaceStation[i] != 0 )
                    {
                    startPoint = 0;
                    endPoint = indexSpaceStation[i];
                    }
                else
                    {
                    startPoint = indexSpaceStation[i];
                    endPoint = indexSpaceStation[i + 1];
                    }
                
                int mid = (endPoint - startPoint) / 2;
                int temp = mid - startPoint;
                int temp1 = endPoint - mid;
                mid = (temp > temp1) ? temp : temp1;

                if ( maxDist < mid )
                    maxDist = mid;
                }
            Console.WriteLine(maxDist);
            Console.ReadKey();
            }
        }
    }
