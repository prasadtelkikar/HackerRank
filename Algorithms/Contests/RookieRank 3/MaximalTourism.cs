using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests.RookieRank_3
{
    class MaximalTourism
    {
        public static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            List<LinkedList<int>> busRoutes = new List<LinkedList<int>>();

            for (int i = 0; i < k; i++)
            {
                LinkedList<int> route = new LinkedList<int>();
                int firstCity, secondCity;
                string[] connection = Console.ReadLine().Split(' ');
                secondCity = Convert.ToInt32(connection[1]);
                firstCity = Convert.ToInt32(connection[0]);
                route.AddFirst(firstCity);
                route.AddLast(secondCity);
                busRoutes.Add(route);
            }
            foreach (LinkedList<int> br in busRoutes)
            {
                Console.WriteLine("New LinkedList: ");
                foreach (var element in br)
                {
                    Console.WriteLine(element);
                }
            }
            Console.ReadKey();
        }
    }
}
